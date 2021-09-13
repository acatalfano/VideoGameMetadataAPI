using Microsoft.EntityFrameworkCore;
using VideoGameMetadataApi.Model.Entities;

namespace VideoGameMetadataApi.Model
{
    public partial class VideoGameDbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Game> Games { get; set; }
    }
}
