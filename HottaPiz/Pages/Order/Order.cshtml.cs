using System.Security.Claims;
using AspNetCoreHero.ToastNotification.Abstractions;
using HottaPiz.DataLayer.DTOs.Order;
using HottaPiz.Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HottaPiz.Web.Pages.Order
{
    [Authorize]
    [Route("/AddToOrderBasket")]
    public class OrderModel : PageModel
    {
        private readonly IPizzaServices _pizzaServices;
        private readonly IOrderServices _orderServices;
        private readonly INotyfService _notyfService;


        public OrderModel(IPizzaServices pizzaServices, IOrderServices orderServices, INotyfService notyfService)
        {
            _pizzaServices = pizzaServices;
            _orderServices = orderServices;
            _notyfService = notyfService;
        }

        public AddToOrderVM Order { get; set; }
        public async Task<IActionResult> OnGet()
        {
            
            int pizzaId = int.Parse(HttpContext.Request.Query["PizzaId"]);
            int customerId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier.ToString()));
            decimal pizzaPrice = _pizzaServices.GetPizzaPriceByPizzaId(pizzaId);

            Order = new AddToOrderVM()
            {
                Count = 1,
                PizzaId = pizzaId,
                CustomerId = customerId,
                Price = pizzaPrice,
                TotalPrice = pizzaPrice * 1
            };

            if (await _orderServices.AddToOrderBasket(Order))
            {
                _notyfService.Success("Pizza Added To Order Basket Successfully");
            }
            else
            {
                _notyfService.Error("Something Went Wrong !");
            }

            return Redirect("/");
        }
    }
}
