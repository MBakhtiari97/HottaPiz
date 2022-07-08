using AspNetCoreHero.ToastNotification.Abstractions;
using HottaPiz.Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HottaPiz.Web.Pages.Admin.Order
{
    [Authorize]
    public class RemoveOrderModel : PageModel
    {
        private IOrderServices _orderServices;
        private INotyfService _notyfService;

        public RemoveOrderModel(IOrderServices orderServices, INotyfService notyfService)
        {
            _orderServices = orderServices;
            _notyfService = notyfService;
        }

        public async Task<IActionResult> OnGet(int orderId)
        {
            if (await _orderServices.RemoveOrderFromHistory(orderId))
            {
                _notyfService.Success("Order Removed From History Successfully !");
            }
            else
            {
                _notyfService.Error("Something Went Wrong !");
            }

            return Redirect("/Admin/ManageOrders");
        }
    }
}
