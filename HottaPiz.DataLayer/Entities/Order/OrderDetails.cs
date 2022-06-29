using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HottaPiz.DataLayer.Entities.Common;

namespace HottaPiz.DataLayer.Entities.Order
{
    public class OrderDetails:BaseEntity
    {
        public OrderDetails()
        {
            
        }

        #region Properties

        public int PizzaId { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
        public int OrderId { get; set; }

        #endregion

    }
}
