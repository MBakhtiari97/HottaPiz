using System.Security.Claims;
using AspNetCoreHero.ToastNotification.Abstractions;
using HottaPiz.DataLayer.DTOs.Customer;
using HottaPiz.Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HottaPiz.Web.Pages.Customer
{
    [Authorize]
    public class CustomerPizzasModel : PageModel
    {
        private readonly ICustomerServices _customerServices;
        private readonly INotyfService _notyfService;
        public CustomerPizzasModel(ICustomerServices customerServices, INotyfService notyfService)
        {
            _customerServices = customerServices;
            _notyfService = notyfService;
        }

        public List<CustomerPizzasVM> Pizza { get; set; }
        public async Task OnGetAsync()
        {
            var customerId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier.ToString()));
            Pizza = await _customerServices.GetAllCustomerPizzasAsync(customerId);
        }
    }
}
