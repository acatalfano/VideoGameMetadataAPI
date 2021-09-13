using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VideoGameMetadataApi.Model.Entities;

namespace VideoGameMetadataApi.Model.EntityTypeConfigurations
{
    internal class GameEntityTypeConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.HasOne(game => game.Publisher)
                .WithMany();

            builder.Property(game => game.PublisherId)
                .IsRequired();

            builder.Property(game => game.Name)
                .IsRequired();

            builder.Property(game => game.ReleaseYear)
                .IsRequired();

            builder.Property(game => game.Players)
                .IsRequired();
        }
    }
}
