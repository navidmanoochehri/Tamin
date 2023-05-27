using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Dapper;
using Tamin.Data;
using Tamin.Data.Models;
using Microsoft.VisualBasic;
using System.Security.Cryptography.X509Certificates;

namespace Tamin.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class LoginModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ILogger<LoginModel> _logger;
        private IDateData _datedata;
        public LoginModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<LoginModel> logger,
            IDateData datedata)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _datedata = datedata;
        }
        [BindProperty]
        public InputModel Input { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }
        public bool ShowResend { get; set; }
        public string UserId { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "نام کاربری را وارد کنید.")]
            public string UserName { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "رمز عبور")]
            [Required(ErrorMessage = "لطفا رمز عبور را وارد کنید")]
            public string Password { get; set; }

            public bool RememberMe { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            returnUrl = returnUrl ?? Url.Content("/");

            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("/index");

            if (ModelState.IsValid)
            {
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                var result = await _signInManager.PasswordSignInAsync
                             (Input.UserName,
                              Input.Password,
                              Input.RememberMe,
                              lockoutOnFailure: true);


                if (result.Succeeded)
                {
                    _logger.LogInformation("User logged in.");
                    IdentityUser identityUser = await _userManager.FindByNameAsync(Input.UserName);
                    
                    var user = identityUser;
                    Date date = new Date();
                    List<Date> DateList = new List<Date>();
                    DateList = await _datedata.GetDate();
                    DateList = DateList.Where(x => x.Id == user.Id).ToList();
                   

                    if(DateList.Count()==0)
                    {
                        date.Id = user.Id;
                        date.UserName = Input.UserName;
                        date.Lastlogin = (DateAndTime.Now).ToString("yyyy/MM/dd");
                        await _datedata.InsertDate(date);
                    }
                    else 
                    { 
                        date.Id = user.Id;
                        date.UserName = Input.UserName;
                        date.Lastlogin = (DateAndTime.Now).ToString("yyyy/MM/dd");
                        date.Lastlogout = DateList.Select(s => s.Lastlogout).ElementAtOrDefault(0);

                        await _datedata.UpdateDate(date);
                    }
                  
                    return LocalRedirect(returnUrl);
                }
                if (result.RequiresTwoFactor)
                {
                    return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = Input.RememberMe });
                }
                if (result.IsLockedOut)
                {
                    _logger.LogWarning("User account locked out.");
                    return RedirectToPage("./Lockout");
                }
                if (result.IsNotAllowed)
                {
                    _logger.LogWarning("ایمیل شما تایید نشده است.");

                    ModelState.AddModelError(string.Empty, "ایمیل تایید نشده است");

                    var user = await _userManager.FindByNameAsync(Input.UserName);
                    UserId = user.Id;
                    ShowResend = true;
                    return Page();
                }
                if (!result.Succeeded)
                {
                    ModelState.AddModelError(string.Empty, "نام کاربری یا کلمه عبور اشتباه می باشد.");
                    return Page();
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
