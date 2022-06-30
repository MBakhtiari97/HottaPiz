using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HottaPiz.DataLayer.Entities.Common;

namespace HottaPiz.DataLayer.Entities.Pizza
{
    public class CustomPizza:BaseEntity
    {
        #nullable disable

        [MaxLength(50)] 
        public string PizzaName { get; set; }

        public decimal PizzaTotalPrice { get; set; }

        public int CustomerId { get; set; }
    }
}
