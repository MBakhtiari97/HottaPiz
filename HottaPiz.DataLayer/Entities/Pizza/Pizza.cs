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
        [MaxLength(50)]
        public string PizzaCode { get; set; }
        public decimal PizzaBasePrice { get; set; }
        public decimal PizzaTotalPrice { get; set; }
        public string Description { get; set; }
        [MaxLength(255)]
        public string PizzaImageName { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;

        #endregion

        // #region Relations
        //
        // public virtual List<PizzaToIngredients> PizzaToIngredients { get; set; }
        //
        // #endregion

    }
}
