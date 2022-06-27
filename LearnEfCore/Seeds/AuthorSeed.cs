using LearnEfCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnEfCore.Seeds
{
    public class AuthorSeed : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasData(
                new Author { Id = 1, FirstName = "Zafer", LastName = "Cömert" },
                new Author { Id = 2, FirstName = "Ahmet", LastName = "Yıldırım" },
                new Author { Id = 3, FirstName = "Fatih", LastName = "Çelik" }
                );
        }
    }
}
