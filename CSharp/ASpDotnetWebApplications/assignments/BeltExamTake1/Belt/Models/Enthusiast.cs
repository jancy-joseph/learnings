using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Belt.Models
{
    public class Enthusiast
    {
        [Key]
        public int EnthusiastId { get; set; }

        // Foreign Key and navigation property for the user who left this review
        [Required]
        public int UserId { get; set; }
        public User User { get; set; }

        [Required]
        public int HobbyId { get; set; }
        public Hobby Hobby { get; set; }

       // [Required(ErrorMessage = "You must choose a Proficiency level")]
      //  [Range(1,5, ErrorMessage="Rating must be between 1 and 5 stars.")]
       // public string Proficiency_level { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}