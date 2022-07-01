using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HottaPiz.DataLayer.Context;
using HottaPiz.DataLayer.DTOs.Customer;
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

        public async Task<List<CustomerPizzasVM>> GetAllCustomerPizzasAsync(int customerId)
        {
            var pizzas = await _context.CustomPizzas
                .Where(c => c.CustomerId == customerId).ToListAsync();

            List<CustomerPizzasVM> allPizzas = new List<CustomerPizzasVM>();

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

        public List<string> GetPizzaIngredientByPizzaId(int pizzaId)
        {
            var ingredientIds = _context.PizzaToIngredients
                .Where(pti => pti.PizzaId == pizzaId)
                .Select(pti => pti.PizzaIngredientId).ToList();

            List<string> ingredientsNames = new List<string>() ;

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

        #endregion

    }
}
