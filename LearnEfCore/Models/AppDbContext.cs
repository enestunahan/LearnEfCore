using LearnEfCore.Configuration;
using LearnEfCore.Seeds;
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
            modelBuilder.ApplyConfiguration(new BookConfiguration());
            modelBuilder.ApplyConfiguration(new BookSeedData());
            base.OnModelCreating(modelBuilder);
        }
    }
}
