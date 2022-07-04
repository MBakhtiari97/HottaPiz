using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HottaPiz.DataLayer.Entities.Order;

namespace HottaPiz.DataLayer.DTOs.Order
{
    public class AddToOrderVM
    {
        public int PizzaId { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        public int CustomerId { get; set; }
    }

    public class ShowOrderBasketVM
    {
        public int PizzaId { get; set; }
        public string PizzaName { get; set; } = string.Empty;
        public string PizzaImageName { get; set; } = string.Empty;
        public decimal PizzaPrice { get; set; }
        public int Count { get; set; }
    }

    public class OrderBasketItemsVM
    {
        public Entities.Pizza.Pizza pizzas { get; set; }
        public OrderDetails OrderDetails { get; set; }

    }

    public class CustomerOrdersHistoryVM
    {
        public int OrderId { get; set; }
        public int OrderNumber { get; set; }
        public decimal TotalOrderPrice { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int CustomerId { get; set; }
        public string PaymentTraceCode { get; set; } = string.Empty;
        public string PaymentMethod { get; set; } = string.Empty;
    }
}
