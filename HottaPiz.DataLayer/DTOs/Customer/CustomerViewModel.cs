using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HottaPiz.DataLayer.DTOs.Customer
{
    #nullable disable
    public class RegisterCustomerVM
    {
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please Enter {0}")]
        [MaxLength(50,ErrorMessage = "Length Is Too Long")]
        public string CustomerFirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please Enter {0}")]
        [MaxLength(50, ErrorMessage = "Length Is Too Long")]
        public string CustomerLastName { get; set; }

        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Please Enter {0}")]
        [MaxLength(50, ErrorMessage = "Length Is Too Long")]
        public string CustomerPhoneNumber { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please Enter {0}")]
        [DataType(DataType.Password)]
        [MaxLength(50, ErrorMessage = "Length Is Too Long")]
        public string CustomerPassword { get; set; }

        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "Please Enter {0}")]
        [DataType(DataType.Password)]
        [MaxLength(50, ErrorMessage = "Length Is Too Long")]
        [Compare("CustomerPassword", ErrorMessage = "Password And Confirm Password Does Not Match !")]
        public string CustomerConfirmPassword { get; set; }

        [Display(Name = "Email Address")]
        [MaxLength(255, ErrorMessage = "Length Is Too Long")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string? CustomerEmailAddress { get; set; }

        [Display(Name = "First Address")]
        [Required(ErrorMessage = "Please Enter {0}")]
        [MaxLength(800, ErrorMessage = "Length Is Too Long")]
        public string CustomerFirstAddress { get; set; }

        [Display(Name = "Second Address")]
        [MaxLength(800, ErrorMessage = "Length Is Too Long")]
        public string? CustomerSecondAddress { get; set; }
    }

    public class LoginCustomerVM
    {
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Please Enter {0}")]
        [MaxLength(50, ErrorMessage = "Length Is Too Long")]
        public string CustomerPhoneNumber { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please Enter {0}")]
        [MaxLength(50, ErrorMessage = "Length Is Too Long")]
        public string CustomerPassword { get; set; }

        public bool RememberMe { get; set; }

    }

    public class CustomerPizzasVM
    {
        public int PizzaId { get; set; }
        public string PizzaName { get; set; }
        public decimal PizzaPrice { get; set; }
        public List<string> PizzaIngredients { get; set; }
    }

    public class ManageCustomerVM
    {
        public int CustomerId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string? CustomerEmailAddress { get; set; }
        public string CustomerFirstAddress { get; set; }
        public string? CustomerSecondAddress { get; set; }
        public DateTime? RegisterDate { get; set; }
        public bool? IsAdmin { get; set; }
    }

}
