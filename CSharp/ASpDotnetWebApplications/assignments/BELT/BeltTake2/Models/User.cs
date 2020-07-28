using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeltTake2.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [RegularExpression(@"^[A-Za-z ]+$",ErrorMessage="Letters and spaces only")]
        [Required(ErrorMessage = "You must put a Name here.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "You must put a Alias here.")]
        [RegularExpression(@"^[0-9A-Za-z]+$",ErrorMessage="Letters and numbers only")]
        public string Alias { get; set; }

        [Required(ErrorMessage = "You must put an Email here.")]
        [MinLength(2, ErrorMessage = "Email must be at least 2 characters long.")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MinLength(8, ErrorMessage = "Must be at least 8 characters long.")]
        public string Password { get; set; }

        [NotMapped]
        [Required]
        [Compare("Password")]
        public string ConfirmPW { get; set; }

         //Navigation property for the 12M with Idea
        public List<Idea> Ideas { get; set; }
        //Navigation property for the 12M with Like
        public List<Like> Likes {get;set;}

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
