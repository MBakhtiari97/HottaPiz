using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HottaPiz.DataLayer.DTOs;
using HottaPiz.DataLayer.Entities.Order;

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
    }
}
