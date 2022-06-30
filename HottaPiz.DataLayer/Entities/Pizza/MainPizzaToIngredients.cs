using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HottaPiz.DataLayer.Entities.Common;

namespace HottaPiz.DataLayer.Entities.Pizza
{
    public class MainPizzaToIngredients:BaseEntity
    {
        #nullable disable
        public MainPizzaToIngredients()
        {

        }

        #region Properties

        public int PizzaId { get; set; }
        public int PizzaIngredientId { get; set; }

        #endregion
    }
}
