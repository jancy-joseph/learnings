using Microsoft.EntityFrameworkCore;
 
namespace CRUD.Models
{
    public class MyContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public MyContext(DbContextOptions options) : base(options) { }

         public DbSet<Dish> Dishes {get;set;}
        // public DbSet<Message> Messages {get;set;}
        // // public DbSet<Style> Styles {get;set;}
        // // public DbSet<TruckStyle> TruckStyles {get;set;}      

        //  public DbSet<Comment> comments {get;set;}  

    }
}