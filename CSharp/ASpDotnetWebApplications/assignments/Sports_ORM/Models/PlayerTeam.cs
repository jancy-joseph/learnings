using System.ComponentModel.DataAnnotations;

namespace Sports_ORM.Models
{
    public class PlayerTeam
    {
        [Key]
        public int PlayerTeamId {get;set;}
        public int PlayerId {get;set;}
        public Player PlayerOnTeam {get;set;}
        public int TeamId {get;set;}
        public Team TeamOfPlayer {get;set;}
    }
}