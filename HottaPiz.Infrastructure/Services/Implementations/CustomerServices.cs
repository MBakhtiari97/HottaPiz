using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HottaPiz.DataLayer.Context;
using HottaPiz.DataLayer.DTOs.Customer;
using HottaPiz.DataLayer.DTOs.Order;
using HottaPiz.DataLayer.Entities.Customer;
using HottaPiz.DataLayer.Entities.Pizza;
using HottaPiz.Infrastructure.Security.PasswordHasher;
using HottaPiz.Infrastructure.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HottaPiz.Infrastructure.Services.Implementations
{
    public class CustomerServices : ICustomerServices
    {
        #region Constructor

        HottaPizContext _context;

        public CustomerServices(HottaPizContext context)
        {
            _context = context;
        }

        #endregion

        #region Register

        public async Task<bool> RegisterCustomer(Customer newCustomer)
        {
            try
            {
                if (!CheckPhoneNumberExists(newCustomer.CustomerPhoneNumber))
                {
                    _context.Customer.Add(newCustomer);
                    await _context.SaveChangesAsync();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region Check Phone Number Exists

        public bool CheckPhoneNumberExists(string phoneNumber)
        {
            return _context.Customer
                .Any(c => c.CustomerPhoneNumber == phoneNumber);
        }

        public async Task<Customer?> GetCustomerForLoginAsync(LoginCustomerVM login)
        {
            return await _context.Customer
                .SingleOrDefaultAsync(c =>
                        c.CustomerPhoneNumber == login.CustomerPhoneNumber.Trim() &&
                        c.Password == PasswordHelper.EncodePasswordMd5(login.CustomerPassword));
        }

        public async Task<List<CustomerPizzasVM>?> GetAllCustomerPizzasAsync(int customerId)
        {
            var pizzas = await _context.Pizzas
                .Where(c => c.CustomerId == customerId).ToListAsync();

            List<CustomerPizzasVM>? allPizzas = new List<CustomerPizzasVM>();

            if (pizzas != null)
            {
                foreach (var pizza in pizzas)
                {
                    var customerPizza = new CustomerPizzasVM()
                    {
                        PizzaName = pizza.PizzaName,
                        PizzaId = pizza.Id,
                        PizzaPrice = pizza.PizzaTotalPrice,
                        PizzaIngredients = GetPizzaIngredientByPizzaId(pizza.Id)
                    };

                    allPizzas.Add(customerPizza);
                }
                return allPizzas;
            }

            return null;
        }

        public List<string> GetPizzaIngredientByPizzaId(int pizzaId)
        {
            var ingredientIds = _context.PizzaToIngredients
                .Where(pti => pti.PizzaId == pizzaId)
                .Select(pti => pti.PizzaIngredientId).ToList();

            List<string> ingredientsNames = new List<string>();

            foreach (var id in ingredientIds)
            {
                var ingredientName = GetIngredientNameById(id);
                ingredientsNames.Add(ingredientName);
            }

            return ingredientsNames;
        }

        public string GetIngredientNameById(int ingredientId)
        {
            return _context.PizzasIngredients
                .Single(pi => pi.Id == ingredientId).IngredientTitle;
        }

        public async Task<List<CustomerOrdersHistoryVM>> GetCustomerOrdersHistory(int customerId)
        {
            var ordersHistory = await _context.Orders
                .Where(o =>
                    o.CustomerId == customerId &&
                    o.IsPaid)
                .Select(o =>
                new CustomerOrdersHistoryVM()
                {
                    CustomerId = customerId,
                    OrderId = o.Id,
                    TotalOrderPrice = o.TotalOrderPrice,
                    OrderNumber = o.OrderNumber,
                    PaymentDate = o.PaymentDate,
                    PaymentMethod = o.PaymentGateWay,
                    PaymentTraceCode = o.PaymentTraceCode
                }).ToListAsync();
            return ordersHistory;

        }

        #region Admin

        public async Task<List<ManageCustomerVM>> GetCustomersForManaging()
        {
            return await _context.Customer
                    .Select(c =>
                    new ManageCustomerVM()
                    {
                        CustomerFirstName = c.CustomerFirstName,
                        CustomerPhoneNumber = c.CustomerPhoneNumber,
                        CustomerEmailAddress = c.CustomerEmailAddress,
                        CustomerFirstAddress = c.CustomerFirstAddress,
                        CustomerLastName = c.CustomerLastName,
                        CustomerId = c.Id,
                        CustomerSecondAddress = c.CustomerSecondAddress,
                        IsAdmin = c.IsAdmin,
                        RegisterDate = c.CustomerRegisterDate
                    })
                    .OrderByDescending(c=>c.RegisterDate)
                    .ToListAsync();
        }

        public async Task<ManageCustomerVM> GetCustomerForUpdateAsync(int customerId)
        {
            var customerInfo = await _context.Customer
                .Where(c => c.Id == customerId)
                .Select(c => new ManageCustomerVM()
                {
                    CustomerFirstName = c.CustomerFirstName,
                    CustomerPhoneNumber = c.CustomerPhoneNumber,
                    CustomerEmailAddress = c.CustomerEmailAddress,
                    CustomerFirstAddress = c.CustomerFirstAddress,
                    CustomerId = c.Id,
                    CustomerSecondAddress = c.CustomerSecondAddress,
                    IsAdmin = c.IsAdmin,
                    CustomerLastName = c.CustomerLastName,
                    RegisterDate = c.CustomerRegisterDate
                })
                .SingleAsync();

            return customerInfo;
        }

        public async Task<bool> UpdateCustomerAsync(ManageCustomerVM customerInfo)
        {
            try
            {
                var currentCustomer = await GetCustomerByIdAsync(customerInfo.CustomerId);

                currentCustomer.CustomerPhoneNumber = customerInfo.CustomerPhoneNumber;
                currentCustomer.CustomerEmailAddress = customerInfo.CustomerEmailAddress;
                currentCustomer.IsAdmin = (bool)customerInfo.IsAdmin;

                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<Customer> GetCustomerByIdAsync(int customerId)
        {
            return await _context.Customer
                .FindAsync(customerId);
        }

        public async Task<bool> RemoveCustomerAsync(int customerId)
        {
            try
            {
                var customer = await GetCustomerByIdAsync(customerId);
                customer.IsDelete = true;

                await _context.SaveChangesAsync();

                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion


        #endregion

    }
}
