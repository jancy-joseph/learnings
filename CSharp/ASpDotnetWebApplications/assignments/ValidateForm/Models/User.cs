using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ValidateForm.Models
{
    public class FutureDateAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        // You first may want to unbox "value" here and cast to to a DateTime variable!
        if((DateTime)value > DateTime.Now){
            return new ValidationResult("No Future Dates are allowed!");
        }
        return ValidationResult.Success;

    }
}
    public class User
    {
        // [Key]
        //public int UserId { get; set; }

         [Required(ErrorMessage = "You must put a First Name here.")]
         [MinLength(2, ErrorMessage = "First Name must be at least 2 characters long.")]
        public string FirstName { get; set; }
         [Required(ErrorMessage = "You must put a Last Name here.")]
         [MinLength(2, ErrorMessage = "Last Name must be at least 2 characters long.")]
        public string LastName { get; set; }

        // [NotMapped]
        public string FullName
        {
            get 
            {
                return $"{FirstName} {LastName}";
            }
        }
         [Required]
         [Range(0,int.MaxValue,ErrorMessage="You must enter a Positive number")]
        public int Age { get; set; }

         [Required(ErrorMessage = "You must put an Email here.")]
         [MinLength(2, ErrorMessage = "Email must be at least 2 characters long.")]
         [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

         [Required(ErrorMessage = "Password is required")]
         [MinLength(3, ErrorMessage = "Must be at least 3 characters long.")]
        public string Password { get; set; }

        // [NotMapped]
         [Required]
         [Compare("Password")]
        public string ConfirmPW { get; set; }

        [FutureDate]
        public DateTime mydate{get;set;}
        // public DateTime CreatedAt { get; set; } = DateTime.Now;
        // public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public User()
        {
            FirstName = "George";
            LastName = "Thomas";
            Age= 25;
            Email= "George@Thomas.com";
            Password ="12345678";
            ConfirmPW ="12345678";
            mydate = DateTime.Now;
        }

        public User( string fname, string lname, int age, string email,string pwd,string cpwd,DateTime myd)
        {
            FirstName =fname;
            LastName=lname;
            Age= age;
            Email= email;
            Password = pwd;
            ConfirmPW = cpwd;
            mydate=myd;
        }

    }
}