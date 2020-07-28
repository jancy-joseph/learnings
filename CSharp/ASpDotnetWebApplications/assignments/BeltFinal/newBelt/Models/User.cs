using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace newBelt.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
     //   [RegularExpression(@"^[A-Za-z ]+$",ErrorMessage="Letters and spaces only")]
        [RegularExpression(@"^\D*$",ErrorMessage="Digits are not allowed.Letters only")]
        [Required(ErrorMessage = "You must put a First Name here.")]
        public string FirstName { get; set; }
        [RegularExpression(@"^\D*$",ErrorMessage="Digits are not allowed.Letters only")]
        [Required(ErrorMessage = "You must put a LastName here.")]
        //[RegularExpression(@"^[A-Za-z]+$",ErrorMessage="Letters and numbers only")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "You must put an Email here.")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MinLength(8, ErrorMessage = "Must be at least 8 characters long.")]
        [RegularExpression(@"^(?=.*[a-z A-Z])(?=.*\d)(?=.*[!@#$%^&*()\-_=+`~\[\]{}?|])(?=.*[^\da-zA-Z]).{8,}$",
        ErrorMessage="Password Must have one special character,one number and letter")]
       // [Password]
        public string Password { get; set; }

        [NotMapped]
        [Required]
        [Compare("Password")]
        public string ConfirmPW { get; set; }

         public List<ActivityMember> ActivitiesOfuser{get;set;}

         //Navigation property for the 12M with Idea
    //    public List<Idea> Ideas { get; set; }
        //Navigation property for the 12M with Like
      //  public List<Like> Likes {get;set;}
        public List<Activity> UserActivities{get;set;}
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
