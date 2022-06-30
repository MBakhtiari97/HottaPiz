using AspNetCoreHero.ToastNotification.Abstractions;
using HottaPiz.DataLayer.DTOs.Pizza;
using HottaPiz.Infrastructure.Extensions.Validator;
using HottaPiz.Infrastructure.Services.Interfaces;
using HottaPiz.Infrastructure.Utilities.PathTools;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HottaPiz.Web.Pages.Pizza
{
    public class CreateNewPizzaModel : PageModel
    {
        private readonly IPizzaServices _pizzaServices;
        private readonly INotyfService _notyfService;

        public CreateNewPizzaModel(IPizzaServices pizzaServices, INotyfService notyfService)
        {
            _pizzaServices = pizzaServices;
            _notyfService = notyfService;
        }

        [BindProperty]
        public CreatePizzaVM Pizza{ get; set; }

        [BindProperty]
        public IFormFile PizzaImage { get; set; }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (PizzaImage?.Length > 0 && PizzaImage.IsImage())
            {
                var saveImagePath = PathGenerator.GetSaveAndDeletePizzaImage(PizzaImage.FileName);

                using (var stream = new FileStream(saveImagePath,FileMode.Create))
                {
                    PizzaImage.CopyTo(stream);
                }
                Pizza.PizzaImageName = PizzaImage.FileName;
            }
            else
            {
                Pizza.PizzaImageName = "Default.png";
            }

            if (await _pizzaServices.CreatePizzaAsync(Pizza))
            {
                _notyfService.Success("Pizza Created !");
                return Redirect("/");
            }
            else
            {
                _notyfService.Error("Failed To Create Pizza !");
                return Page();
            }
        }
    }
}
