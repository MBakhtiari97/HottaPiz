using System.Security.Claims;
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
            if (!ModelState.IsValid)
                return Page();

            Pizzas.CustomerId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier.ToString()));
            var createdCustomPizzaId = await _pizzaServices.CreateCustomPizza(Pizzas);

            if (createdCustomPizzaId != null)
            {
                if (await _pizzaServices.CreateCustomPizzaIngredients(createdCustomPizzaId, SelectedIngredients))
                {
                    await _pizzaServices.UpdateCustomPizzaPrice(createdCustomPizzaId, SelectedIngredients);
                    _notyfService.Success("Your Customized Pizza Created Successfully , You Can Order It By My Custom Pizzas Panel !");
                    return Redirect("/Customer/MyPizzas");
                }

                _notyfService.Error("Failed To Create Your Pizza !");
                return Page();
            }

            _notyfService.Error("Something Went Wrong !");
            return Page();

        }
    }
}
