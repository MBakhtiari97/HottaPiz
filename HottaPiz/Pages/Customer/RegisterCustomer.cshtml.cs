using AspNetCoreHero.ToastNotification.Abstractions;
using HottaPiz.DataLayer.DTOs.Customer;
using HottaPiz.DataLayer.Entities.Customer;
using HottaPiz.DataLayer.Repositories.Interfaces;
using HottaPiz.Infrastructure.Security.PasswordHasher;
using HottaPiz.Infrastructure.Services.Interfaces;
using HottaPiz.Infrastructure.Utilities.Generator;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HottaPiz.Web.Pages.Customer
{
    public class RegisterCustomerModel : PageModel
    {
        private readonly ICustomerServices _customerServices;
        private readonly IOrderServices _orderServices;
        private readonly INotyfService _notyfService;

        public RegisterCustomerModel(ICustomerServices customerServices, IOrderServices orderServices, INotyfService notyfService)
        {
            _customerServices = customerServices;
            _orderServices = orderServices;
            _notyfService = notyfService;
        }

        [BindProperty]
        public RegisterCustomerVM Register { get; set; }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //Registering customer
            var customerId = _customerServices.RegisterCustomer(Register);

            //If registration was successful 
            if (customerId != 0)
            {
                //Creating a new order 
                var newOrder = new DataLayer.Entities.Order.Order()
                {
                    CustomerId = customerId,
                    OrderNumber = Generator.UniqueNumberGenerator(),
                    TotalOrderPrice = 0
                };

                //if the new order submitted successfully 
                if (await _orderServices.CreateFirstCustomerOpenOrderAsync(newOrder))
                {
                    _notyfService.Success("Registered Completed !");
                    return Redirect("/Login");
                }
                else
                {
                    _notyfService.Error("Something Went Wrong !");
                    return Page();
                }
            }

            _notyfService.Error("Phone Number Is Currently Existed!");
            return Page();
        }
    }
}
