using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserDashBoard.Models
{
    public class Message
    {
        [Key]
        public int MessageId { get; set; }

        [Required(ErrorMessage="You must input a Message")]
        [MinLength(2,ErrorMessage="Mesage is not long enough,Minimum 2 characters")]
        public string MessageText { get; set; }

        // // Like/Unlike a comment
        // [Required]
        // public bool MLike{get;set;}= false;

        // [Required]
        // public int MLikeCount{get;set;}= 0;
        //         [NotMapped]
        // public double AvgRating{
        //     get{
        //         double avg =0;
        //         foreach (Review review in Reviews)
        //         {
        //             avg+= review.Rating;
        //         }
        //         avg/=Reviews.Count;
        //         if(Reviews.Count ==0) return 0;
        //         return avg;
        //     }
        // }

        //Foreign key and Navigation for Message creator
        [Required]
        public int UserId { get; set; }
        public User User{get;set;}

        //List of comments on this message
        public List<Comment> Mcomments{get;set;} =new List<Comment>();
        
        // //M2M navigation

        // public List<UMLike> UMLikes{get;set;}

        // [NotMapped]
        // public int MLikeCount{
        //     get{
        //         int count =0;
        //         foreach (UMLike umlike in UMLikes)
        //         {
        //             if(umlike.MessageId == MessageId)
        //             {
        //             count+= umlike.Like;
        //             }
        //         }
        //         if(UMLikes.Count ==0) return 0;
        //         return count;
        //     }
        // }   
        [NotMapped]

        public string mydatestring{
            get{
                var diff = DateTime.Now - CreatedAt;
                if(diff.Seconds < 60)
                {
                    return $"{diff.Seconds} seconds ago";

                }
                else if(diff.Minutes < 60)
                {
                    return $"{diff.Minutes} Minutes ago";
                }
                else if(diff.Hours <24)
                {
                    return $"{diff.Hours} Hours ago";   
                }
                else if(diff.Days<7)
                {
                    return $"{diff.Days} Days ago";      
                }
                else
                {
                    var ddate =  string.Format("{0:MMMM dd, yyyy}", CreatedAt.Date);
                    return ddate;      
                }

            }
        }

        public DateTime CreatedAt{get;set;} =DateTime.Now;
        public DateTime UpdatedAt{get;set;}= DateTime.Now;
    }
}