using System.Security.Claims;
using HottaPiz.DataLayer.DTOs.Order;
using HottaPiz.Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HottaPiz.Web.Pages.Order
{
    public class OrderBasketModel : PageModel
    {
        private readonly IOrderServices _orderServices;

        public OrderBasketModel(IOrderServices orderServices)
        {
            _orderServices = orderServices;
        }

        [BindProperty]
        public List<ShowOrderBasketVM> Order { get; set; }

        public async Task OnGet()
        {
            var customerId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier.ToString()));
            Order = await _orderServices.GetOrderBasketItems(customerId);
        }
    }
}
