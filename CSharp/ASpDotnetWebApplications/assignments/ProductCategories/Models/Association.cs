using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductCategories.Models
{
    public class Association
    {
        [Key]
        public int AssocaitionId { get; set; }

        public int ProductId    {get;set;}
        public Product Product { get; set; }
        public int CategoryId { get; set; }
        public Category Category  {get;set;}

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}