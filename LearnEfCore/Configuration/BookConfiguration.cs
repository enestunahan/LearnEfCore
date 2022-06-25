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
        }
    }
}
