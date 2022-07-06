using HottaPiz.DataLayer.DTOs.Customer;
using HottaPiz.Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HottaPiz.Web.Pages.Admin.Customer
{
    [Authorize]
    public class ManageCustomersIndexModel : PageModel
    {
        private readonly ICustomerServices _customerServices;

        public ManageCustomersIndexModel(ICustomerServices customerServices)
        {
            _customerServices = customerServices;
        }

        [BindProperty]
        public List<ManageCustomerVM> Customer { get; set; }
        public async Task OnGet()
        {
            Customer = await _customerServices.GetCustomersForManaging();
        }
    }
}
