using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VideoGameMetadataApi.Model.Entities;

namespace VideoGameMetadataApi.Model.EntityTypeConfigurations
{
    internal class CategoryEntityTypeConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(category => category.Name)
                .IsRequired();

            builder.HasIndex(category => category.Name)
                .IsUnique();
        }
    }
}
