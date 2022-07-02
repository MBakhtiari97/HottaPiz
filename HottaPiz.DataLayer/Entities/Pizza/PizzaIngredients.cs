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
    public class PizzaIngredients:BaseEntity
    {
        #nullable disable
        public PizzaIngredients()
        {
            
        }

        #region Properties

        [MaxLength(50)]
        public string IngredientTitle { get; set; }
        public decimal IngredientPrice { get; set; }


        #endregion

    }
}
