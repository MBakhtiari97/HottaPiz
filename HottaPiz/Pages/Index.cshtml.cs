using HottaPiz.DataLayer.Repositories.Interfaces;
using HottaPiz.Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HottaPiz.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IPizzaServices _pizzaServices;

        public IndexModel(IPizzaServices pizzaServices)
        {
            _pizzaServices = pizzaServices;
        }

        [BindProperty]
        public List<DataLayer.Entities.Pizza.Pizza> Pizzas { get; set; }

        public async Task OnGet()
        {
            Pizzas = await _pizzaServices.GetAllPizzasAsync();
        }
    }
}