using Microsoft.EntityFrameworkCore;
 
namespace BeltTake2.Models
{
    public class MyContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public MyContext(DbContextOptions options) : base(options) { }

         public DbSet<User> Users {get;set;}
          public DbSet<Like> Likes {get;set;}
          public DbSet<Idea> Ideas {get;set;}
       //  public DbSet<UserHobbyConn> UserHobbyConns{get;set;}

    }
}
