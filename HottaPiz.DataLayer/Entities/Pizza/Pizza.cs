using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HottaPiz.DataLayer.Entities.Common;

namespace HottaPiz.DataLayer.Entities.Pizza
{
    #nullable disable
    public class Pizza:BaseEntity
    {
        public Pizza()
        {
            
        }

        #region Properties

        [MaxLength(50)]
        public string PizzaName { get; set; }
        public decimal PizzaBasePrice { get; set; }
        public decimal PizzaTotalPrice { get; set; }
        public string? Description { get; set; } = string.Empty;
        [MaxLength(255)] 
        public string PizzaImageName { get; set; } = "Default.png";
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public bool IsCustomPizza { get; set; }
        public int? CustomerId { get; set; }

        #endregion
    }
}
