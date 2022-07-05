using HottaPiz.DataLayer.DTOs.Pizza;
using HottaPiz.Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HottaPiz.Web.Pages.Pizza
{
    [BindProperties]
    public class PizzaDetailsModel : PageModel
    {
        private readonly IPizzaServices _pizzaServices;

        public PizzaDetailsModel(IPizzaServices pizzaServices)
        {
            _pizzaServices = pizzaServices;
        }

        public PizzaDetailsVM Pizza { get; set; }
        public List<PizzaIngredientsNamesVM> Ingredients { get; set; }

        public async Task OnGet(int pizzaId)
        {
            Pizza = await _pizzaServices.GetPizzaDetailsByPizzaIdAsync(pizzaId);
            Ingredients = await _pizzaServices.GetPizzaIngredientsNamesByPizzaIdAsync(pizzaId);
        }
    }
}
