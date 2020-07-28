using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BeltTake2.Models
{
    public class Idea
    {
        [Key]
        public int IdeaId { get; set; }

        [Required(ErrorMessage = "You must put an Idea here.")]
        [MinLength(5, ErrorMessage = "Idea must be at least 5 characters long.")]
        public string Text { get; set; }
        [Required]
        public int UserId { get; set; }
        public User User{get;set;}

        // Navigation property for 12M with the Likes left for this Idea
        public List<Like> Likes { get; set; } = new List<Like>();

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
               
    }
}