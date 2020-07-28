using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeltTake2.Models
{
    public class Like
    {
        [Key]
        public int LikeId { get; set; }
        [Required]
        public int IdeaId { get; set; }
        public Idea Idea { get; set; }
        [Required]
        public int UserId{get;set;}
        public User User{get;set;}

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        
    }
}