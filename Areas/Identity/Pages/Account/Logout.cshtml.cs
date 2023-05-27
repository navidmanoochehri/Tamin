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

namespace Tamin.Areas.Identity.Pages.Account
{
    [IgnoreAntiforgeryToken]
    [AllowAnonymous]
    public class LogoutModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ILogger<LogoutModel> _logger;
        private IDateData _datedata;

        public LogoutModel(UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<LogoutModel> logger,
            IDateData datedata)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _datedata = datedata;
        }

        public void OnGet()
        {
      
        }

        public async Task<IActionResult> OnPost(string returnUrl = "/")
        {
            await _signInManager.SignOutAsync();
            _logger.LogInformation("User logged out.");

            Date date = new Date();
            List<Date> DateList = new List<Date>();
            DateList = await _datedata.GetDate();
            var currentUser = _userManager.GetUserName(User);
            var currentId = _userManager.GetUserId(User);
            var list = DateList.Where(x => x.Id == currentId);
            var I = list.Select(x => x.Lastlogin).ElementAtOrDefault(0);
            date.UserName = currentUser.ToString();
            date.Id = currentId;
            date.Lastlogin = I;
            date.Lastlogout = (DateAndTime.Now).ToString("yyyy/MM/dd");
            await _datedata.UpdateDate(date);

            if (returnUrl != null)
            {

                return LocalRedirect(returnUrl);
            }
            else
            {
                return RedirectToPage();
            }
        }
    }
}
