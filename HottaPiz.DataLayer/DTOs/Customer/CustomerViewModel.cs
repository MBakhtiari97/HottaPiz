﻿using System;
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
}
