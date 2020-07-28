using System;
using System.Collections.Generic;

namespace Belt.Models
{
    public class DashboardWrapper
    {
         public User LoggedUser { get; set; }
        public List<Hobby> AllHobbys { get; set; }

        public int HobbyCount {get;set;}
        
    }
}