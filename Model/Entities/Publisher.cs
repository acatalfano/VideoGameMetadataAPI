using System.Collections.Generic;

namespace VideoGameMetadataApi.Model.Entities
{
    public class Publisher
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public ICollection<Category> PublishedGames { get; set; }
    }
}
