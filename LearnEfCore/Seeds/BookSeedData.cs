using LearnEfCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnEfCore.Seeds
{
    public class BookSeedData : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
                new Book { Id = 1, Title = "Tutanamayanlar" },
                new Book { Id = 2, Title = "Çalıkuşu" },
                new Book { Id = 3, Title = "Kürk Mantolu Madonna" });
        }
    }
}
