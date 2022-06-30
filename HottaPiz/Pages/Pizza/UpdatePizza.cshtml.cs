using AspNetCoreHero.ToastNotification.Abstractions;
using HottaPiz.DataLayer.DTOs.Pizza;
using HottaPiz.Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HottaPiz.Web.Pages.Pizza
{
    public class UpdatePizzaModel : PageModel
    {
        private IPizzaServices _pizzaServices;
        private INotyfService _notyfService;

        public UpdatePizzaModel(IPizzaServices pizzaServices, INotyfService notyfService)
        {
            _pizzaServices = pizzaServices;
            _notyfService = notyfService;
        }
        [BindProperty]
        public UpdatePizzaVM Pizza { get; set; }

        [BindProperty]
        public IFormFile PizzaNewImage { get; set; }

        public void OnGet(int id)
        {
            Pizza = _pizzaServices.GetUpdatePizzaVMById(id);
        }
    }
}
