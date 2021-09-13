using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VideoGameMetadataApi.Model.Entities;

namespace VideoGameMetadataApi.Model.EntityTypeConfigurations
{
    internal class PublisherEntityTypeConfiguration : IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            builder.Property(publisher => publisher.Name)
                .IsRequired();

            builder.HasIndex(publisher => publisher.Name)
                .IsUnique();
        }
    }
}
