using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HottaPiz.DataLayer.Context;
using HottaPiz.DataLayer.Entities.Customer;
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

        #endregion

    }
}
