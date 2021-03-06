using LearnEfCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace LearnEfCore.Configuration
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(x => x.Title).
                IsRequired().
                HasMaxLength(150);

            builder.HasKey(x => x.Id);

            builder.Property(x => x.CreatedDate).
                HasDefaultValue(DateTime.Now);

            //builder.Property(x => x.CreatedDate)
            //    .HasDefaultValueSql("GETDATE()"); Bu şekilde de kullanılabilir formatı farklı sadece.

            builder.Property(x=>x.IsDeleted)
                .HasDefaultValue(false);

            builder.HasOne(x=>x.Category)
                .WithMany(a=>a.Books)
                .HasForeignKey(x=>x.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);
            //Eğer ilişkili ana satır (parent row) silinirse yada güncellenirse bağlı olduğu alt satır (child row) da silinir yada güncellenir.
        }
    }
}
