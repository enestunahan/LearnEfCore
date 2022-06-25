using Microsoft.EntityFrameworkCore;

namespace LearnEfCore.Models
{
    public class AppDbContext :  DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }
        public DbSet<Book> Books { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasKey(e => e.Id);
            modelBuilder.Entity<Book>().Property(e => e.Title).IsRequired();    
            base.OnModelCreating(modelBuilder);
        }
    }
}
