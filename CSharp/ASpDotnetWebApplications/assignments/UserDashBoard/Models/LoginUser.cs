using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserDashBoard.Models
{
    public class LoginUser
    {
        [Required(ErrorMessage="Must input an email address")]
        [EmailAddress(ErrorMessage="Invalid Email address")]
        public string LoginEmail{get;set;}

        [Required(ErrorMessage="Must input an Password")]
        public string LoginPassword{get;set;}
    }
}