using System.Security.Claims;
using HottaPiz.Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HottaPiz.Web.Pages.Order
{
    [Authorize]
    public class ThankYouModel : PageModel
    {
        IOrderServices _orderServices;

        public ThankYouModel(IOrderServices orderServices)
        {
            _orderServices = orderServices;
        }

        public string Username { get; set; }
        public void OnGet()
        {
            var customerId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier.ToString()));

            Username = _orderServices.GetCustomerNameByCustomerId(customerId);
            _orderServices.FinalizeCustomerOrder(customerId);
        }
    }
}
