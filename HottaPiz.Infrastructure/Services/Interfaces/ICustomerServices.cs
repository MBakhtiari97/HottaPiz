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
        #region Register Customer

        public int RegisterCustomer(RegisterCustomerVM newCustomer);

        #endregion

        #region Check Phone Number Exists

        public bool CheckPhoneNumberExists(string phoneNumber);

        #endregion

        #region Get Customer For Login

        public Task<Customer?> GetCustomerForLoginAsync(LoginCustomerVM login);

        #endregion

        #region Get All Customer Pizzas By Customer Id

        public Task<List<CustomerPizzasVM>?> GetAllCustomerPizzasAsync(int customerId);

        #endregion

        #region Get Pizza Ingredient By Pizza Id

        public List<string> GetPizzaIngredientByPizzaId(int pizzaId);

        #endregion

        #region Get Ingredient Name By Ingredient Id

        public string GetIngredientNameById(int ingredientId);

        #endregion

        #region Get Customer Orders History By Customer Id

        public Task<List<CustomerOrdersHistoryVM>> GetCustomerOrdersHistory(int customerId);

        #endregion

        #region Admin

        #region Get Customers For Managing

        public Task<List<ManageCustomerVM>> GetCustomersForManaging();

        #endregion

        #region Get Customer By CustomerId For Update 

        public Task<ManageCustomerVM> GetCustomerForUpdateAsync(int customerId);

        #endregion

        #region Update Customer

        public Task<bool> UpdateCustomerAsync(ManageCustomerVM customerInfo);

        #endregion

        #region Get Customer By Customer Id

        public Task<Customer> GetCustomerByIdAsync(int customerId);

        #endregion

        #region Remove Customer By Customer Id

        public Task<bool> RemoveCustomerAsync(int customerId);

        #endregion


        #endregion
    }
}
