using System.Security.Claims;
using AspNetCoreHero.ToastNotification.Abstractions;
using HottaPiz.Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HottaPiz.Web.Pages.Order
{
    [Authorize]
    public class RemoveOrderBasketModel : PageModel
    {
        private readonly IOrderServices _ordertServices;
        private readonly INotyfService _notyfService;

        public RemoveOrderBasketModel(IOrderServices ordertServices, INotyfService notyfService)
        {
            _ordertServices = ordertServices;
            _notyfService = notyfService;
        }

        public async Task<IActionResult> OnGet()
        {
            var customerId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier.ToString()));
            var pizzaId = int.Parse(HttpContext.Request.Query["PizzaId"]);
            if (await _ordertServices.RemovePizzaFromOrderBasket(customerId, pizzaId))
            {
                _notyfService.Success("Successfully Done !");
            }
            else
            {
                _notyfService.Error("Something Went Wrong !");
            }
            return Redirect("/OrderBasket");
        }
    }
}
