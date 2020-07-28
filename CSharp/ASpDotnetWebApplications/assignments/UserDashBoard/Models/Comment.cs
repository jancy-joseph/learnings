using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserDashBoard.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }

        [Required(ErrorMessage="You must input a Comment")]
        [MinLength(2,ErrorMessage="comment is not long enough,Minimum 2 characters")]

        public string CommentText { get; set; }

        // [Required]
        // public bool CLike{get;set;}= false;

        // [Required]
        // public int CLikeCount{get;set;}= 0;

        //Foreign key and Navigation for User who posted comments
        [Required]
        public int UserId { get; set; }
        public User User{get;set;}

        //Foreign key and Navigation for the message where this comment was posted
        [Required]
        public int MessageId { get; set; }
        public Message Message{get;set;}

        // //M2M for User comment Like
        // public List<UCLike> UCLikes{get;set;}
        
        // [NotMapped]
        // public int MLikeCount{
        //     get{
        //         int count =0;
        //         foreach (UCLike uclike in UCLikes)
        //         {
        //             if(uclike.CommentId == CommentId)
        //             {
        //             count+= uclike.Like;
        //             }
        //         }
        //         if(UCLikes.Count ==0) return 0;
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