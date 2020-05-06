using System.Collections.Generic;

namespace ProductCategories.Models
{
    public class editProdAssociationWrapper
    {
        public Product currProduct { get; set; }

        public Association association {get;set;}
        public List<Category> AllCategory{get;set;}       
    }
}