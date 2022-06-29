using AspNetCoreHero.ToastNotification.Abstractions;
using HottaPiz.DataLayer.DTOs.Customer;
using HottaPiz.DataLayer.Entities.Customer;
using HottaPiz.DataLayer.Repositories.Interfaces;
using HottaPiz.Infrastructure.Security.PasswordHasher;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HottaPiz.Web.Pages
{
    public class RegisterCustomerModel : PageModel
    {
        private readonly IGenericRepository<Customer> _repository;
        private readonly INotyfService _notyfService;

        public RegisterCustomerModel(IGenericRepository<Customer> repository, INotyfService notyfService)
        {
            _repository = repository;
            _notyfService = notyfService;
        }

        [BindProperty]
        public RegisterCustomerVM Register { get; set; }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync()
        {
            var newCustomer = new Customer()
            {
                CustomerEmailAddress = Register.CustomerEmailAddress,
                CustomerFirstAddress = Register.CustomerFirstAddress,
                CustomerLastName = Register.CustomerLastName,
                CustomerFirstName = Register.CustomerFirstName,
                CustomerPhoneNumber = Register.CustomerPhoneNumber,
                CustomerSecondAddress = Register.CustomerSecondAddress,
                Password = PasswordHelper.EncodePasswordMd5(Register.CustomerPassword)
            };

            if (await _repository.CreateEntityAsync(newCustomer))
            {
                await _repository.SaveChangesAsync();
                _notyfService.Success("Registered Completed !");
            }
            else
            {
                _notyfService.Error("Registered Failed !");
            }
            return Redirect("/Login");
        }
    }
}
