using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HottaPiz.DataLayer.Entities.Common;

namespace HottaPiz.DataLayer.Entities.Order
{
    public class Order:BaseEntity
    {
        public Order()
        {
            
        }

        #region Properties

        public int OrderNumber { get; set; }
        public decimal TotalOrderPrice { get; set; }
        public bool IsPaid { get; set; }
        [MaxLength(50)]
        public string? PaymentTraceCode { get; set; }
        public DateTime? PaymentDate { get; set; }
        [MaxLength(50)]
        public string? PaymentGateWay { get; set; }
        public int CustomerId { get; set; }

        #endregion

    }
}
