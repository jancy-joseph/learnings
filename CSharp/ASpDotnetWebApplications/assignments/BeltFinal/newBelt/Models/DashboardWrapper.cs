using System;
using System.Collections.Generic;

namespace newBelt.Models
{
    public class DashboardWrapper
    {
   
      public User LoggedUser{get;set;}
      public List<Activity> AllActivities {get;set;}
    }
}