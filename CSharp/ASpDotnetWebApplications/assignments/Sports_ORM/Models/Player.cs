using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sports_ORM.Models
{
    public class Player
    {
        [Key]
        public int PlayerId {get;set;}
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public int TeamId {get;set;}
        public Team CurrentTeam {get;set;}
        public List<PlayerTeam> AllTeams {get;set;}
    }
}