using System;
using System.Collections.Generic;

namespace BeltTake2.Models
{
    public class DashboardWrapper
    {
        public User LoggedUser { get; set; }
        public Idea newIdea {get;set;}
        public List<Idea> AllIdeas { get; set; }
        
    }
}