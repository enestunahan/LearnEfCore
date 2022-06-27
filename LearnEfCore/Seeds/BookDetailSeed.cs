using LearnEfCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnEfCore.Seeds
{
    public class BookDetailSeed : IEntityTypeConfiguration<BookDetail>
    {
        public void Configure(EntityTypeBuilder<BookDetail> builder)
        {
            builder.HasData(

                new BookDetail { Id = 1, BookId = 1 , City="Turkey" , Year=2020});
        }
    }
}
