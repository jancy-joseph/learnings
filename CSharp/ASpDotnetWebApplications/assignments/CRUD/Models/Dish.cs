using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD.Models
{
    public class CalorieAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            // // You first may want to unbox "value" here and cast to to a DateTime variable!
            // if((DateTime)value > DateTime.Now){
            //     return new ValidationResult("No Future Dates are allowed!");
            // }
            // return ValidationResult.Success;
            if((int) value <=0)
            {
                return new ValidationResult("Calories should be greater than zero");
            }
            return ValidationResult.Success;

        }
    }
    public class Dish
    {
        [Key]
        public int DishId { get; set; }
        
        [Required(ErrorMessage="Input Name required")]
        public string Name{get;set;}
        [Required(ErrorMessage="Chef Name required")]
        public string Chef { get; set; }
        [Required(ErrorMessage="Tastiness required")]
        [Range(1,5,ErrorMessage="Tastiness between 1 and 5 only")]
        public int Tastiness { get; set; }
        [Required(ErrorMessage="Calories required")]
        [Calorie]
        public int Calories { get; set; }
        [Required(ErrorMessage="Description required")]
        public string Description { get; set;}
        
        public DateTime CreatedAt {get;set;}= DateTime.Now;
        public DateTime UpdatedAt {get;set;}= DateTime.Now;

    }
}