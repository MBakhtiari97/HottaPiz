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
                .Single(o =>
                    o.CustomerId == customerId &&
                    !o.IsPaid).Id;

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
            //First getting the customer open order id
            var orderId = GetCustomerOpenOrderId(customerId);

            //Then Getting all order details related to the order id 
            var orderDetails = await _context.OrdersDetails
                .Where(od => od.OrderId == orderId)
                .ToListAsync();

            //Creating new list from order basket items view model , that have pizza and order detail properties
            var orderRequiredItems = new List<OrderBasketItemsVM>();

            //Getting and adding order details items and pizzas to create list of order basket items view model 
            foreach (var item in orderDetails)
            {
                var pizza = GetPizzaByPizzaId(item.PizzaId);
                orderRequiredItems.Add(new OrderBasketItemsVM()
                {
                    pizzas = pizza,
                    OrderDetails = item
                });
            }

            //Creating new list from required export view model , that is show order basket view model
            var showOrderBasket = new List<ShowOrderBasketVM>();

            //Filling the created list with proper items of orderRequiredItems that we have it already
            foreach (var item in orderRequiredItems)
            {
                showOrderBasket.Add(new ShowOrderBasketVM()
                {
                    PizzaImageName = item.pizzas.PizzaImageName,
                    Count = item.OrderDetails.Count,
                    PizzaId = item.OrderDetails.PizzaId,
                    PizzaName = item.pizzas.PizzaName,
                    PizzaPrice = item.OrderDetails.Price * item.OrderDetails.Count
                });
            }

            //Returning list
            return showOrderBasket;
        }

        public Pizza GetPizzaByPizzaId(int pizzaId)
        {
            return _context.Pizzas.Find(pizzaId);
        }

        public async Task<bool> RemovePizzaFromOrderBasket(int customerId, int pizzaId)
        {
            try
            {
                var orderId = GetCustomerOpenOrderId(customerId);
                var order = GetOrderByOrderId(orderId);
                var orderDetail = GetOrderDetailsByOrderIdAndPizzaId(orderId, pizzaId);

                if (orderDetail is { Count: 1 })
                {
                    _context.OrdersDetails.Remove(orderDetail);
                }

                if (orderDetail is { Count: > 1 })
                {
                    orderDetail.Count -= 1;
                }
                order.TotalOrderPrice -= orderDetail.Price;
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public decimal GetOrderPrice(int customerId)
        {
            var orderId = GetCustomerOpenOrderId(customerId);
            var order = GetOrderByOrderId(orderId);

            return order.TotalOrderPrice;
        }

        public string GetCustomerNameByCustomerId(int customerId)
        {
            return _context.Customer.Find(customerId).CustomerFirstName;
        }

        public async Task FinalizeCustomerOrder(int customerId)
        {
            //Getting the order id 
            var orderId = GetCustomerOpenOrderId(customerId);

            //Getting the order 
            var order = GetOrderByOrderId(orderId);

            //Finalizing the order 
            order.IsPaid = true;
            order.PaymentDate = DateTime.Now;
            order.PaymentGateWay = "PayPal/Visa/MasterCard";
            order.PaymentTraceCode = Generator.UniqueTraceCodeGenerator();

            //Creating a new open order for customer
            var newOpenOrder = new Order()
            {
                CustomerId = customerId,
                OrderNumber = Generator.UniqueNumberGenerator(),
                TotalOrderPrice = 0
            };

            //Adding new open order
            _context.Orders.Add(newOpenOrder);
            //Saving changes
            await _context.SaveChangesAsync();
        }
    }
}
