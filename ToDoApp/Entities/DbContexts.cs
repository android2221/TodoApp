using Microsoft.EntityFrameworkCore;

namespace ToDoApp.Entities
{
    public class DbContexts : DbContext
    {        
        public DbSet<ToDo> Todos {get; set;}

        public DbContexts(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<ToDo>().ToTable("Todos");
            modelBuilder.Entity<Event>().ToTable("Events");
        }
    }
}