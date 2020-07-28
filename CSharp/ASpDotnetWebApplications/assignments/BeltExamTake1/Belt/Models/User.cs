using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Belt.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "You must put a First Name here.")]
        [MinLength(2, ErrorMessage = "First Name must be at least 2 characters long.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "You must put a Last Name here.")]
        [MinLength(2, ErrorMessage = "Last Name must be at least 2 characters long.")]
        public string LastName { get; set; }

        [NotMapped]
        public string FullName
        {
            get 
            {
                return $"{FirstName} {LastName}";
            }
        }

        [Required(ErrorMessage = "You must put an Username here.")]
        [MinLength(2, ErrorMessage = "Must be at least 3 characters long.")]
        [MaxLength(15, ErrorMessage = "Must be at  max 15 characters long.")]

        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MinLength(8, ErrorMessage = "Must be at least 8 characters long.")]
        public string Password { get; set; }

        [NotMapped]
        [Required]
        [Compare("Password")]
        public string ConfirmPW { get; set; }

        // Navigation property for the M2M with Style
        public List<Enthusiast> Enthusiasts { get; set; }


        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
