using Microsoft.EntityFrameworkCore;
using VideoGameMetadataApi.Model.Entities;
using VideoGameMetadataApi.Model.EntityTypeConfigurations;

namespace VideoGameMetadataApi.Model
{
    public partial class VideoGameDbContext : DbContext
    {
        public VideoGameDbContext(DbContextOptions<VideoGameDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new GameEntityTypeConfiguration().Configure(modelBuilder.Entity<Game>());
            new GameCategoryEntityTypeConfiguration().Configure(modelBuilder.Entity<GameCategory>());
            new CategoryEntityTypeConfiguration().Configure(modelBuilder.Entity<Category>());
            new PublisherEntityTypeConfiguration().Configure(modelBuilder.Entity<Publisher>());
            //TODO: OR see if can do modelBuilder.ApplyConfigurationsFromAssembly(typeof(VideoGameMetadataApi.Model).Assembly);
        }
    }
}
