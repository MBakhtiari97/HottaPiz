using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HottaPiz.DataLayer.DTOs.Customer;
using HottaPiz.DataLayer.DTOs.Order;
using HottaPiz.DataLayer.Entities.Customer;

namespace HottaPiz.Infrastructure.Services.Interfaces
{
    public interface ICustomerServices
    {
        public Task<bool> RegisterCustomer(Customer newCustomer);
        public bool CheckPhoneNumberExists(string phoneNumber);
        public Task<Customer?> GetCustomerForLoginAsync(LoginCustomerVM login);
        public Task<List<CustomerPizzasVM>?> GetAllCustomerPizzasAsync(int customerId);
        public List<string> GetPizzaIngredientByPizzaId(int pizzaId);
        public string GetIngredientNameById(int ingredientId);
        public Task<List<CustomerOrdersHistoryVM>> GetCustomerOrdersHistory(int customerId);

        #region Admin

        public Task<List<ManageCustomerVM>> GetCustomersForManaging();
        public Task<ManageCustomerVM> GetCustomerForUpdateAsync(int customerId);
        public Task<bool> UpdateCustomerAsync(ManageCustomerVM customerInfo);
        public Task<Customer> GetCustomerByIdAsync(int customerId);
        public Task<bool> RemoveCustomerAsync(int customerId);

        #endregion
    }
}
