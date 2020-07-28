using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace newBelt.Models
{
    
    public class FutureDateAttribute : ValidationAttribute
    {
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        // You first may want to unbox "value" here and cast to to a DateTime variable!
        if((DateTime)value < DateTime.Now){
            return new ValidationResult("No Past Dates are allowed!");
        }
        return ValidationResult.Success;

        }
    }

    
    public class FuturetimeAttribute : ValidationAttribute
    {
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        // You first may want to unbox "value" here and cast to to a DateTime variable!
        if((DateTime)value < DateTime.Now){
            return new ValidationResult("No Past Dates are allowed!");
        }
        return ValidationResult.Success;

        }
    }

    public class Activity
    {
        [Key]
        public int ActivityId { get; set; }
       [Required(ErrorMessage = "Title is required")]
       [MinLength(2,ErrorMessage="Title - Min length is 2.Please try again.")]
        public string Title { get; set; }
       [FutureDate]
       [Required(ErrorMessage = "Date is required")]

        public DateTime ActivityDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Time)]

        [Required(ErrorMessage = "Time of Event is required")]

        public DateTime TimeOfEvent { get; set; }
        
        public int Duration {get;set;}

        public string DurationUnits{get;set;}

        // [NotMapped]
        // public string Durationstring
        // {
        //     get{
        //         if(Duration!= null && DurationUnits != null)
        //         {
        //          string dt = Duration.ToString();
        //         return dt+" "+DurationUnits;
        //         }
        //         else
        //         {
        //             return " ";
        //         }
        //     }
        // }

        [Required(ErrorMessage = "Description is required")]

        [MinLength(10,ErrorMessage="Minimum 10 characters needed")]
        public string Description{get;set;}

        public int UserId {get;set;}
        public User User{get;set;}


        [NotMapped]
        public string CoordiantorName
        {
            get
            {
                if(User != null)
                {
                    return User.FirstName+" "+User.LastName;
                
                }
                return " ";
            }
        }
         public List<ActivityMember> UsersInActivities{get;set;}

        //  [NotMapped]
        // public int TotalNoOfMembers
        // {
        //     get
        //     {
        //         int avg =0;
        //         if(UsersInActivities.Count == 0) return avg;
        //         if(UsersInActivities != null)
        //         {
        //             avg = UsersInActivities.Count;
        //         }
        //         return avg;

        //     }
        // }



        // [NotMapped]

        // public string DateAndTime{
        //     get{
        //         if(ActivityDate!=null && TimeOfEvent!=null )
        //         {
        //         var date1 =ActivityDate.ToString("MM/dd");
        //         var time1 = TimeOfEvent.ToString("t");
        //         return date1+"@ "+time1;
        //         }
        //         return " ";
        //     }
        // }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

    }
}