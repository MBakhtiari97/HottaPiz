using AspNetCoreHero.ToastNotification.Abstractions;
using HottaPiz.DataLayer.DTOs.Customer;
using HottaPiz.DataLayer.Repositories.Interfaces;
using HottaPiz.Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HottaPiz.Web.Pages.Admin.Customer
{
    [Authorize]
    public class UpdateCustomerModel : PageModel
    {
        private ICustomerServices _customerServices;
        private INotyfService _notyfService;

        public UpdateCustomerModel(ICustomerServices customerServices, INotyfService notyfService)
        {
            _customerServices = customerServices;
            _notyfService = notyfService;
        }

        [BindProperty]
        public ManageCustomerVM Customer { get; set; }

        public async Task OnGet(int customerId)
        {
            Customer = await _customerServices.GetCustomerForUpdateAsync(customerId);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (await _customerServices.UpdateCustomerAsync(Customer))
            {
                _notyfService.Success("Customer Updated Successfully !");
                return Redirect("/Admin/ManageCustomers");
            }
            else
            {
                _notyfService.Error("Failed To Update The Customer !");
                return Page();
            }
        }
    }
}
