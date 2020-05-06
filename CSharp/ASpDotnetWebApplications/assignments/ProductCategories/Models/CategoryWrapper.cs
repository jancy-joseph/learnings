using System.Collections.Generic;

namespace ProductCategories.Models
{
    public class CategoryWrapper
    {
        public Category newCategory { get; set; }
        public List<Category> AllCategories{get;set;}
    }
}