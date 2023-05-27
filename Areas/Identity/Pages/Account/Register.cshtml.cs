using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;


namespace Tamin.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly Services.IEmailSender _emailSender;
      
        public RegisterModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<RegisterModel> logger,
            Services.IEmailSender emailSender)
            
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
         
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "لطفا نام کاربری را وارد کنید")]
            [StringLength(20, MinimumLength = 4, ErrorMessage = ". نام کاربری باید بین 4 تا 20 کاراکتر باشد")]
            [Display(Name = "نام کاربری")]
            public string UserName { get; set; }

            [DataType(DataType.EmailAddress)]
            [Display(Name = "رایانامه")]
            [StringLength(250, MinimumLength = 5, ErrorMessage = ". رایانامه باید بین ۵ تا ۲۵۰ کاراکتر باشد")]
            [Required(ErrorMessage = "لطفا رایانامه را وارد کنید")]
            [EmailAddress(ErrorMessage = "لطفا آدرس پست الکترونیکی را درست وارد کنید.")]
            public string Email { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "رمز عبور")]
            [Required(ErrorMessage = "لطفا رمز عبور را وارد کنید")]
            [StringLength(20, MinimumLength = 6, ErrorMessage = ". رمز عبور باید حداقل 6 و حداکثر ۲۰ کاراکتر باشد")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "تکرار رمز عبور")]
            [Required(ErrorMessage = "لطفا تکرار رمز عبور را وارد کنید")]
            [Compare("Password", ErrorMessage = "رمز عبور و تکرار رمز عبور باید یکسان باشد.")]
            public string ConfirmPassword { get; set; }

    }

    public async Task OnGetAsync(string returnUrl = null)
    {
        ReturnUrl = returnUrl;
        ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
    }

    public async Task<IActionResult> OnPostAsync(string returnUrl = null)
    {
       
        returnUrl = returnUrl ?? Url.Content("~/index");
        ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        if (ModelState.IsValid)
        {
            var user = new IdentityUser { UserName = Input.UserName, Email = Input.Email };
            var result = await _userManager.CreateAsync(user, Input.Password);
            if (result.Succeeded)
            {
                _logger.LogInformation("User created a new account with password.");

                await _userManager.AddToRoleAsync(user, "Users");

                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                var callbackUrl = Url.Page(
                    "/Account/ConfirmEmail",
                    pageHandler: null,
                    values: new { area = "Identity", userId = user.Id, code = code },
                    protocol: Request.Scheme);

                await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                    $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                if (_userManager.Options.SignIn.RequireConfirmedAccount)
                {
                    return RedirectToPage("RegisterConfirmation", new { email = Input.Email });
                }
                else
                {
                    return RedirectToPage("./CheckEmail");
                }
            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }

        // If we got this far, something failed, redisplay form
        return Page();
    }
}
}
