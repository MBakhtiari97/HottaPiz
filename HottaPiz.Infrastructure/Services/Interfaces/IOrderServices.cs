using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HottaPiz.DataLayer.DTOs.Order;
using HottaPiz.DataLayer.Entities.Order;
using HottaPiz.DataLayer.Entities.Pizza;

namespace HottaPiz.Infrastructure.Services.Interfaces
{
    public interface IOrderServices
    {
        public Task<bool> AddToOrderBasket(AddToOrderVM order);

        public bool CheckCustomerHaveAnOpenOrder(int customerId);

        public int GetCustomerOpenOrderId(int customerId);

        public bool CheckOrderHaveSpecificPizza(int orderId,int pizzaId);

        public OrderDetails GetOrderDetailsByOrderIdAndPizzaId(int orderId, int pizzaId);

        public Order GetOrderByOrderId(int orderId);

        public Task<List<ShowOrderBasketVM>> GetOrderBasketItems(int customerId);
        public Pizza GetPizzaByPizzaId(int pizzaId);
        public Task<bool> RemovePizzaFromOrderBasket(int customerId, int pizzaId);
        public decimal GetOrderPrice(int customerId);
        public string GetCustomerNameByCustomerId(int customerId);
        public Task FinalizeCustomerOrder(int customerId);
    }
}
