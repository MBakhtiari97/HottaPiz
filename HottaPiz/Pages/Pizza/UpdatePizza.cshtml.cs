using AspNetCoreHero.ToastNotification.Abstractions;
using HottaPiz.DataLayer.DTOs.Pizza;
using HottaPiz.Infrastructure.Extensions.Validator;
using HottaPiz.Infrastructure.Services.Interfaces;
using HottaPiz.Infrastructure.Utilities.PathTools;
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
        public IFormFile? PizzaNewImage { get; set; }

        public void OnGet(int id)
        {
            Pizza = _pizzaServices.GetUpdatePizzaVMById(id);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (PizzaNewImage?.Length > 0 && PizzaNewImage.IsImage())
            {

                //Deleting old image
                var oldImagePath = PathGenerator.GetSaveAndDeletePizzaImage(Pizza.PizzaImageName);
                if (System.IO.File.Exists(oldImagePath) && Pizza.PizzaImageName != "Default.png")
                {
                    System.IO.File.Delete(oldImagePath);
                }

                //Creating new image
                using (var stream = new FileStream(PathGenerator.GetSaveAndDeletePizzaImage(PizzaNewImage.FileName), FileMode.Create))
                {
                    PizzaNewImage.CopyTo(stream);
                }

                Pizza.PizzaImageName = PizzaNewImage.FileName;
            }


            if (await _pizzaServices.UpdatePizzaAsync(Pizza))
            {
                _notyfService.Success("Pizza Details Updated !");
                return Redirect("/");
            }
            else
            {
                _notyfService.Error("Something Went Wrong !");
                return Page();
            }
        }
    }
}
