using Microsoft.EntityFrameworkCore;

namespace ProductCategories.Models
{

    public class MyContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public MyContext(DbContextOptions options) : base(options) { }

          public DbSet<Product> Products {get;set;}
           public DbSet<Category> Categories {get;set;}
           public DbSet<Association> Associations {get;set;}
    //    //  public DbSet<UserHobbyConn> UserHobbyConns{get;set;}

    }
}