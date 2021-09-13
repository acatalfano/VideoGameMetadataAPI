using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VideoGameMetadataApi.Model.Entities;

namespace VideoGameMetadataApi.Model.EntityTypeConfigurations
{
    internal class GameCategoryEntityTypeConfiguration : IEntityTypeConfiguration<GameCategory>
    {
        public void Configure(EntityTypeBuilder<GameCategory> builder)
        {
            builder.HasKey(gameCategory => new { gameCategory.GameId, gameCategory.CategoryId });

            builder.HasOne(gameCategory => gameCategory.Category)
                .WithMany(category => category.GameCategories)
                .HasForeignKey(gameCategory => gameCategory.CategoryId);

            builder.HasOne(gameCategory => gameCategory.Game)
                .WithMany(game => game.GameCategories)
                .HasForeignKey(gameCategory => gameCategory.GameId);
        }
    }
}
