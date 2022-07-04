using System.Security.Claims;
using AspNetCoreHero.ToastNotification.Abstractions;
using HottaPiz.Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HottaPiz.Web.Pages.Pizza
{
    [Authorize]
    public class RemovePizzaModel : PageModel
    {
        private readonly IPizzaServices _pizzaServices;
        private readonly INotyfService _notyfService;

        public RemovePizzaModel(IPizzaServices pizzaServices, INotyfService notyfService)
        {
            _pizzaServices = pizzaServices;
            _notyfService = notyfService;
        }

        public async Task<IActionResult> OnGet(int id)
        {
            if (await _pizzaServices.RemovePizzaByPizzaIdAsync(id))
            {
                _notyfService.Success("Pizza Remove Successfully !");
            }
            else
            {
                _notyfService.Error("Something Went Wrong !");
            }

            return Redirect("/");
        }
    }
}
