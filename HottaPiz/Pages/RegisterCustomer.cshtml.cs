using HottaPiz.DataLayer.DTOs.Customer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HottaPiz.Web.Pages
{
    public class RegisterCustomerModel : PageModel
    {
        [BindProperty]
        public RegisterCustomerVM Register { get; set; }

        public void OnGet()
        {

        }

        public void OnPost()
        {

        }
    }
}
