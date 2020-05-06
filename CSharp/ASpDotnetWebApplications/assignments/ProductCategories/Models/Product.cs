using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductCategories.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
       // [Required(ErrorMessage="Input Name required")]
        public string Name { get; set; }
      //  [Required(ErrorMessage="Input Description required")]
        public string Description { get; set; }
      //  [Required(ErrorMessage="Input Price required")]

        public List<Association> CategoriesInProducts{get;set;}

        public int Price { get; set; }
        public DateTime CreatedAt { get; set; }=DateTime.Now;
        public DateTime UpDatedAt{get;set;}= DateTime.Now;
    }
}