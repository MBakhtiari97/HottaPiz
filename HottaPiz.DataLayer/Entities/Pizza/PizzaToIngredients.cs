using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HottaPiz.DataLayer.Entities.Common;

namespace HottaPiz.DataLayer.Entities.Pizza
{
    public class PizzaToIngredients:BaseEntity
    {
        #nullable disable
        public PizzaToIngredients()
        {
            
        }

        #region Properties

        public int PizzaId { get; set; }
        public int PizzaIngredientId { get; set; }

        #endregion

        // #region Relations
        //
        // [ForeignKey("Id")]
        // public virtual Pizza Pizza { get; set; }
        //
        // [ForeignKey("Id")]
        // public virtual PizzaIngredients PizzaIngredients { get; set; }
        //
        // #endregion
    }
}
