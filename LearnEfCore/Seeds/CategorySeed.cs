using LearnEfCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnEfCore.Seeds
{
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { Id=1, Name="Health"},
                new Category { Id=2, Name="Computer Science"},
                new Category { Id =3, Name="Novel"}
                );
        }
    }
}
