using AspNetCoreHero.ToastNotification.Abstractions;
using HottaPiz.DataLayer.DTOs.Customer;
using HottaPiz.DataLayer.Entities.Customer;
using HottaPiz.DataLayer.Repositories.Interfaces;
using HottaPiz.Infrastructure.Security.PasswordHasher;
using HottaPiz.Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HottaPiz.Web.Pages.Customer
{
    public class RegisterCustomerModel : PageModel
    {
        private ICustomerServices _customerServices;
        private readonly INotyfService _notyfService;

        public RegisterCustomerModel(ICustomerServices customerServices, INotyfService notyfService)
        {
            _customerServices = customerServices;
            _notyfService = notyfService;
        }

        [BindProperty]
        public RegisterCustomerVM Register { get; set; }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var newCustomer = new DataLayer.Entities.Customer.Customer()
            {
                CustomerEmailAddress = Register.CustomerEmailAddress,
                CustomerFirstAddress = Register.CustomerFirstAddress,
                CustomerLastName = Register.CustomerLastName,
                CustomerFirstName = Register.CustomerFirstName,
                CustomerPhoneNumber = Register.CustomerPhoneNumber,
                CustomerSecondAddress = Register.CustomerSecondAddress,
                Password = PasswordHelper.EncodePasswordMd5(Register.CustomerPassword)
            };

            if (await _customerServices.RegisterCustomer(newCustomer))
            {
                _notyfService.Success("Registered Completed !");
                return Redirect("/Login");
            }
            else
            {
                _notyfService.Error("Phone Number Is Currently Existed!");
                return Page();
            }
        }
    }
}
