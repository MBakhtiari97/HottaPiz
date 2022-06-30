using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HottaPiz.Web.Pages.Customer
{
    public class LogoutCustomerModel : PageModel
    {
        private readonly INotyfService _notyfService;

        public LogoutCustomerModel(INotyfService notyfService)
        {
            _notyfService = notyfService;
        }

        public async Task<IActionResult> OnGet()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            _notyfService.Success("Successful Logout !");
            return Redirect("/");
        }
    }
}
