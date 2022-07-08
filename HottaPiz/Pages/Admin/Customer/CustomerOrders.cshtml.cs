using HottaPiz.Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HottaPiz.Web.Pages.Admin.Customer
{
    [Authorize]
    public class CustomerOrdersModel : PageModel
    {
        private IOrderServices _orderServices;

        public CustomerOrdersModel(IOrderServices orderServices)
        {
            _orderServices = orderServices;
        }

        [BindProperty]
        public List<DataLayer.Entities.Order.Order> Orders { get; set; }

        public async Task OnGet(int customerId)
        {
            Orders = await _orderServices.GetCustomerOrdersAsync(customerId);
        }
    }
}
