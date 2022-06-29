using AspNetCoreHero.ToastNotification.Abstractions;
using HottaPiz.DataLayer.DTOs.Customer;
using HottaPiz.Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HottaPiz.Web.Pages
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

        public Task<IActionResult> OnPost()
        {
            return null;
        }
    }
}
