using System.Collections.Generic;

namespace ProductCategories.Models
{
    public class editCatAsssociationWrapper
    {
        public Category currCategory { get; set; }
        public Association association {get;set;}
        public List<Product> AllProducts {get;set;}
        
    }
}