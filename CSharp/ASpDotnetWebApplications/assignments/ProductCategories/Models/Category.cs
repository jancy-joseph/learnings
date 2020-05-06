using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductCategories.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required(ErrorMessage="Input Name required")]

        public string  Name { get; set; }

        public List<Association> ProductswithCategories {get;set;}

        public DateTime CreatedAt { get; set; }=DateTime.Now;
        public DateTime UpDatedAt{get;set;}= DateTime.Now;
    }
}