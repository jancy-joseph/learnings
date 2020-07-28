using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Belt.Models
{
    public class LoginUser
    {
        [Required(ErrorMessage="Must input an Valid Username")]
        public string LoginUsername { get; set; }
        
        [Required(ErrorMessage="Must input a  Valid password")]
        public string LoginPassword { get; set; }

    }
}