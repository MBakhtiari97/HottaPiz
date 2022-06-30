using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HottaPiz.DataLayer.DTOs.Customer;
using HottaPiz.DataLayer.Entities.Customer;

namespace HottaPiz.Infrastructure.Services.Interfaces
{
    public interface ICustomerServices
    {
        public Task<bool> RegisterCustomer(Customer newCustomer);
        public bool CheckPhoneNumberExists(string phoneNumber);
        public Task<Customer?> GetCustomerForLoginAsync(LoginCustomerVM login);
    }
}
