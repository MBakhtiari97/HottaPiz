using AspNetCoreHero.ToastNotification.Abstractions;
using HottaPiz.Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HottaPiz.Web.Pages.Admin.Customer
{
    [Authorize]
    public class DeleteCustomerModel : PageModel
    {
        private ICustomerServices _customerServices;
        private INotyfService _notyfService;

        public DeleteCustomerModel(ICustomerServices customerServices, INotyfService notyfService)
        {
            _customerServices = customerServices;
            _notyfService = notyfService;
        }

        public async Task<IActionResult> OnGet(int customerId)
        {
            if (await _customerServices.RemoveCustomerAsync(customerId))
            {
                _notyfService.Success("Successfully Done !");
            }
            else
            {
                _notyfService.Error("Something Went Wrong !");
            }

            return Redirect("/Admin/ManageCustomers");
        }
    }
}
