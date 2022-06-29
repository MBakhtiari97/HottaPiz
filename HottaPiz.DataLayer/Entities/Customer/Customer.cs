using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HottaPiz.DataLayer.Entities.Common;

namespace HottaPiz.DataLayer.Entities.Customer
{
    public class Customer : BaseEntity
    {
        public Customer()
        {
             
        }

        #region Properties

        [MaxLength(50)]
        public string CustomerFirstName { get; set; }

        [MaxLength(50)]
        public string CustomerLastName { get; set; }

        [MaxLength(50)]
        public string CustomerPhoneNumber { get; set; }

        [MaxLength(255)] 
        public string? CustomerEmailAddress { get; set; }

        [MaxLength(50)]
        public string Password { get; set; }

        [MaxLength(800)]
        public string CustomerFirstAddress { get; set; }

        [MaxLength(800)]
        public string? CustomerSecondAddress { get; set; }

        public DateTime CustomerRegisterDate { get; set; } = DateTime.Now;
        public bool IsAdmin { get; set; }

        #endregion
    }
}
