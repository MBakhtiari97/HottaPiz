using System.Security.Claims;
using HottaPiz.DataLayer.DTOs.Order;
using HottaPiz.Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HottaPiz.Web.Pages.Customer
{
    public class CustomerOrdersModel : PageModel
    {
        private ICustomerServices _customerServices;

        public CustomerOrdersModel(ICustomerServices customerServices)
        {
            _customerServices = customerServices;
        }

        public List<CustomerOrdersHistoryVM> Orders { get; set; }

        public async Task OnGet()
        {
            int customerId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier.ToString()));
            Orders = await _customerServices.GetCustomerOrdersHistory(customerId);
        }
    }
}
