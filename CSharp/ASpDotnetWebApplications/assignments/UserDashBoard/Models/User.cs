using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserDashBoard.Models
{
    public class User
    {
        [Key]
        public int UserId{get; set;}

        [Required(ErrorMessage="Your must put a first name here.")]
        [MinLength(2,ErrorMessage="First Name must be Two Characters long")]
        public string FirstName{get;set;}
        
        [Required(ErrorMessage="Your must put a last name here.")]
        [MinLength(2,ErrorMessage="Last Name must be Two Characters long")]
        public string LastName{get;set;}

        [NotMapped]
        public string FullName{
            get{
                return $"{FirstName} {LastName}";
                }
        }

        [Required(ErrorMessage="Your must put a email here.")]
        [MinLength(2,ErrorMessage="Email must be Two Characters long")]
        [EmailAddress(ErrorMessage="Invalid Email address")]
        public string Email {get;set;}

        [Required(ErrorMessage="Your must put a password here.")]
        [MinLength(8,ErrorMessage="Password must be 8 Characters long")]
        public string Password{get;set;}

        [NotMapped]
        [Required]
        [Compare("Password")]
        public string ConfirmPW {get;set;}

      //  [Required(ErrorMessage="Your must enter your description here.")]
       // [MinLength(8,ErrorMessage="Descrtiption must be 10 Characters long")]
        [Required]
        public string Description { get; set; }="Hello!";

        //this is not a paramter outside world sees so may make it private later.
        [Required]
        public string user_level{get;set;}="normal";

        // public string userlevel { 
        //     get 
        //     {
        //         //Console.WriteLine("get: this.health :" +this.health);
        //         return this.user_level;
        //     }
        //     set
        //     {
        //         //Console.WriteLine("set: this.health :" +this.health);
        //         this.user_level = "normal";
        //     }
        //  }// need to come with logic to find admin.
        
        //Navigation property for food trucks created and reviews left by user
        public List<Message> Messages{get;set;}
        public List<Comment> Comments{get;set;}

        // //M2M navigation
        // public List<UCLike> UCLikes{get;set;}

        // //M2M navigation

        // public List<UMLike> UMLikes{get;set;}

        public DateTime CreatedAt{get;set;} =DateTime.Now;
        public DateTime UpdatedAt{get;set;}= DateTime.Now;
    }
}