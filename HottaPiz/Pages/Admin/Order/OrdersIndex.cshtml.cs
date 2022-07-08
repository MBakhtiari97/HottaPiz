using HottaPiz.Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HottaPiz.Web.Pages.Admin.Order
{
    [Authorize]
    [BindProperties]
    public class OrdersIndexModel : PageModel
    {
        private IOrderServices _orderServices;

        public OrdersIndexModel(IOrderServices orderServices)
        {
            _orderServices = orderServices;
        }

        public List<DataLayer.Entities.Order.Order> Orders { get; set; }
        public decimal TotalOrdersPrice { get; set; }

        public async Task OnGet()
        {
            Orders = await _orderServices.GetAllOrdersAsync();
            TotalOrdersPrice = _orderServices.GetTotalOrdersPrices();
        }
    }
}
