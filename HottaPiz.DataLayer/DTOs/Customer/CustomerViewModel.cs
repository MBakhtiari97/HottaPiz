using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HottaPiz.DataLayer.DTOs.Customer
{
    public class RegisterCustomerVM
    {
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please Enter {0}")]
        [MaxLength(50,ErrorMessage = "Length Is Too Long")]
        public string CustomerFirstName { get; set; }

        [Display(Name = "Second Name")]
        [Required(ErrorMessage = "Please Enter {0}")]
        [MaxLength(50, ErrorMessage = "Length Is Too Long")]
        public string CustomerLastName { get; set; }

        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Please Enter {0}")]
        [MaxLength(50, ErrorMessage = "Length Is Too Long")]
        public string CustomerPhoneNumber { get; set; }

        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Please Enter {0}")]
        [MaxLength(255, ErrorMessage = "Length Is Too Long")]
        public string? CustomerEmailAddress { get; set; }

        [Display(Name = "First Address")]
        [Required(ErrorMessage = "Please Enter {0}")]
        [MaxLength(800, ErrorMessage = "Length Is Too Long")]
        public string CustomerFirstAddress { get; set; }

        [Display(Name = "Second Address")]
        [Required(ErrorMessage = "Please Enter {0}")]
        [MaxLength(800, ErrorMessage = "Length Is Too Long")]
        public string? CustomerSecondAddress { get; set; }
    }
}
