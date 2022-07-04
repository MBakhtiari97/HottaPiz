using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HottaPiz.DataLayer.DTOs.Pizza
{
    public class UpdatePizzaVM
    {
#nullable disable
        public int Id { get; set; }

        [Display(Name = "Pizza Name")]
        [Required(ErrorMessage = "Please Enter {0}")]
        [MaxLength(50, ErrorMessage = "Length Is Too Long")]
        public string PizzaName { get; set; }

        [Display(Name = "Pizza Price")]
        [Required(ErrorMessage = "Please Enter {0}")]
        public decimal PizzaTotalPrice { get; set; }

        [Display(Name = "Pizza Description")]
        [MaxLength(800, ErrorMessage = "Length Is Too Long")]
        public string? Description { get; set; }

        [Display(Name = "Pizza Image")]
        public string PizzaImageName { get; set; }
    }

    public class CreatePizzaVM
    {
#nullable disable

        [Display(Name = "Pizza Name")]
        [Required(ErrorMessage = "Please Enter {0}")]
        [MaxLength(50, ErrorMessage = "Length Is Too Long")]
        public string PizzaName { get; set; }

        [Display(Name = "Pizza Price")]
        [Required(ErrorMessage = "Please Enter {0}")]
        public decimal PizzaTotalPrice { get; set; }

        [Display(Name = "Pizza Description")]
        [MaxLength(800, ErrorMessage = "Length Is Too Long")]
        public string? Description { get; set; }

        [Display(Name = "Pizza Image")]
        public string? PizzaImageName { get; set; }
    }

    public class PizzaIngredientsVM
    {
        public int IngredientId { get; set; }
        public string IngredientName { get; set; }
        public decimal IngredientPrice { get; set; }

    }

    public class CustomerPizzasVM
    {
        public int CustomerId { get; set; }
        [Display(Name = "Pizza Name")]
        [Required(ErrorMessage = "Please Enter {0}")]
        [MaxLength(50, ErrorMessage = "Length Is Too Long")]
        public string PizzaName { get; set; }

    }
}
