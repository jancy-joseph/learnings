using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace newBelt.Models
{
    public class ActivityMember
    {
         [Key]
         public int ActivityMemberId { get; set; }
         public int UserId{get;set;}
         public User User{get;set;}
         public int ActivitiyId{get;set;}
         public Activity Activity{get;set;}
         
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
    
}