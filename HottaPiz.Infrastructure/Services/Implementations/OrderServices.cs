using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HottaPiz.DataLayer.Context;
using HottaPiz.DataLayer.DTOs.Order;
using HottaPiz.DataLayer.Entities.Order;
using HottaPiz.DataLayer.Entities.Pizza;
using HottaPiz.Infrastructure.Services.Interfaces;
using HottaPiz.Infrastructure.Utilities.Generator;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace HottaPiz.Infrastructure.Services.Implementations
{
    public class OrderServices : IOrderServices
    {
        HottaPizContext _context;

        public OrderServices(HottaPizContext context)
        {
            _context = context;
        }

        public async Task<bool> AddToOrderBasket(AddToOrderVM order)
        {
            try
            {
                if (!CheckCustomerHaveAnOpenOrder(order.CustomerId))
                {
                    var newOrder = new Order()
                    {
                        CustomerId = order.CustomerId,
                        OrderNumber = Generator.UniqueNumberGenerator(),
                        TotalOrderPrice = order.TotalPrice
                    };

                    await _context.Orders.AddAsync(newOrder);
                    await _context.SaveChangesAsync();

                    var newOrderDetail = new OrderDetails()
                    {
                        Count = order.Count,
                        OrderId = newOrder.Id,
                        PizzaId = order.PizzaId,
                        Price = order.Price
                    };

                    await _context.OrdersDetails.AddAsync(newOrderDetail);
                    await _context.SaveChangesAsync();

                    return true;
                }
                else
                {
                    var orderId = GetCustomerOpenOrderId(order.CustomerId);

                    if (CheckOrderHaveSpecificPizza(orderId, order.PizzaId))
                    {
                        var orderDetails = GetOrderDetailsByOrderIdAndPizzaId(orderId, order.PizzaId);

                        orderDetails.Count += 1;
                        await _context.SaveChangesAsync();

                        var currentOrder = GetOrderByOrderId(orderId);
                        currentOrder.TotalOrderPrice += orderDetails.Price;
                        await _context.SaveChangesAsync();

                    }
                    else
                    {
                        var newOrderDetails = new OrderDetails()
                        {
                            Count = order.Count,
                            OrderId = orderId,
                            PizzaId = order.PizzaId,
                            Price = order.Price
                        };
                        await _context.OrdersDetails.AddAsync(newOrderDetails);
                        await _context.SaveChangesAsync();

                        var currentOrder = GetOrderByOrderId(newOrderDetails.OrderId);
                        currentOrder.TotalOrderPrice += newOrderDetails.Price;
                        await _context.SaveChangesAsync();
                    }

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool CheckCustomerHaveAnOpenOrder(int customerId)
        {
            return _context.Orders
                .Any(o => o.CustomerId == customerId && !o.IsPaid);
        }

        public int GetCustomerOpenOrderId(int customerId)
        {
            return _context.Orders
                .Single(o => o.CustomerId == customerId).Id;
        }

        public bool CheckOrderHaveSpecificPizza(int orderId, int pizzaId)
        {
            return _context.OrdersDetails
                .Any(od => od.OrderId == orderId && od.PizzaId == pizzaId);
        }

        public OrderDetails GetOrderDetailsByOrderIdAndPizzaId(int orderId, int pizzaId)
        {
            return _context.OrdersDetails
                .Single(od =>
                    od.OrderId == orderId && od.PizzaId == pizzaId);
        }

        public Order GetOrderByOrderId(int orderId)
        {
            return _context.Orders
                .Find(orderId);
        }

        public async Task<List<ShowOrderBasketVM>> GetOrderBasketItems(int customerId)
        {
            var orderId = GetCustomerOpenOrderId(customerId);
            var orderDetails = await _context.OrdersDetails
                .Where(od => od.OrderId == orderId)
                .ToListAsync();

            var orderRequiredItems = new List<OrderBasketItemsVM>();
            foreach (var item in orderDetails)
            {
                var pizza = GetPizzaByPizzaId(item.PizzaId);
                orderRequiredItems.Add(new OrderBasketItemsVM()
                {
                    pizzas = pizza,
                    OrderDetails = item
                });
            }

            var showOrderBasket = new List<ShowOrderBasketVM>();
            foreach (var item in orderRequiredItems)
            {
                showOrderBasket.Add(new ShowOrderBasketVM()
                {
                    PizzaImageName = item.pizzas.PizzaImageName,
                    Count = item.OrderDetails.Count,
                    PizzaId = item.OrderDetails.PizzaId,
                    PizzaName = item.pizzas.PizzaName,
                    PizzaPrice = item.OrderDetails.Price*item.OrderDetails.Count
                });
            }

            return showOrderBasket;
        }

        public Pizza GetPizzaByPizzaId(int pizzaId)
        {
            return _context.Pizzas.Find(pizzaId);
        }
    }
}
