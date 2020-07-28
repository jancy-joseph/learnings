using Microsoft.EntityFrameworkCore;
 
namespace Belt.Models
{
    public class MyContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public MyContext(DbContextOptions options) : base(options) { }

         public DbSet<User> Users {get;set;}
         public DbSet<Hobby> Hobbys {get;set;}
         public DbSet<Enthusiast> Enthusiasts {get;set;}
       //  public DbSet<UserHobbyConn> UserHobbyConns{get;set;}

    }
}
