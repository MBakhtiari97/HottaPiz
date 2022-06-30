using AspNetCoreHero.ToastNotification.Abstractions;
using HottaPiz.DataLayer.DTOs.Pizza;
using HottaPiz.Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HottaPiz.Web.Pages.Pizza
{
    [Authorize]
    public class CustomPizzaModel : PageModel
    {
        private readonly IPizzaServices _pizzaServices;
        private readonly INotyfService _notyfService;

        public CustomPizzaModel(IPizzaServices pizzaServices, INotyfService notyfService)
        {
            _pizzaServices = pizzaServices;
            _notyfService = notyfService;
        }

        [BindProperty]
        public CustomerPizzasVM Pizzas { get; set; }

        [BindProperty]
        public List<PizzaIngredientsVM> Ingredients { get; set; }

        [BindProperty]
        public List<int> SelectedIngredients { get; set; }

        public async Task OnGet()
        {
            Ingredients = await _pizzaServices.GetPizzasIngredients();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            return null;
        }
    }
}
