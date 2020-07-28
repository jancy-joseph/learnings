using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FormSubmission_I.Models
{
    public class User
    {
        [Required(ErrorMessage="You must enter a first name")]
        [MinLength(4, ErrorMessage="This name must be at least 4 characters long.")]
        [Display(Name = "First Name :")] 
        public string FirstName { get; set; }

        [Required(ErrorMessage="You must enter a Last name")]
        [MinLength(4, ErrorMessage="This name must be at least 4 characters long.")]
        [Display(Name = "Last Name :")] 
        public string LastName { get; set; }

        
        [Required(ErrorMessage="You must enter a Age")]
        [Range(0, Double.PositiveInfinity, ErrorMessage="The Age should be a positive number")]
        [Display(Name = "Age :")] 
        public int Age { get; set; }

        [Required(ErrorMessage="You must enter a Email address")]
        [EmailAddress]
        [Display(Name = "Email Address:")] 
        public string Email { get; set; }

        [Required(ErrorMessage="You must enter a Password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password :")] 
        [MinLength(8, ErrorMessage="Password  must be at least 8 characters long.")]
        public string Password { get; set; }
        
    }
}