using System.Security.Claims;
using AspNetCoreHero.ToastNotification.Abstractions;
using HottaPiz.DataLayer.DTOs.Customer;
using HottaPiz.Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HottaPiz.Web.Pages.Customer
{
    public class LoginCustomerModel : PageModel
    {
        private readonly ICustomerServices _customerServices;
        private readonly INotyfService _notyfService;

        public LoginCustomerModel(ICustomerServices customerServices, INotyfService notyfService)
        {
            _customerServices = customerServices;
            _notyfService = notyfService;
        }

        [BindProperty]
        public LoginCustomerVM Login { get; set; }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var userForLogin = _customerServices.GetCustomerForLoginAsync(Login);
            if (userForLogin == null)
            {
                ModelState.AddModelError("CustomerPhoneNumber","Cannot Found Any User !");
                return Page();
            }

            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, userForLogin.Result.Id.ToString()),
                new Claim(ClaimTypes.Name, userForLogin.Result.CustomerFirstName.ToString()),
                new Claim("IsAdmin", userForLogin.Result.IsAdmin.ToString()),
                new Claim(ClaimTypes.MobilePhone, userForLogin.Result.CustomerPhoneNumber.ToString())
            };

            var identity = new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);
            var principle = new ClaimsPrincipal(identity);
            var properties = new AuthenticationProperties
            {
                IsPersistent = Login.RememberMe
            };

            await HttpContext.SignInAsync(principle, properties);
            _notyfService.Success("Successful Login !");

            return Redirect("/");
        }
    }
}
