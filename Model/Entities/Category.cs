using System.Collections.Generic;

namespace VideoGameMetadataApi.Model.Entities
{
    public class Category
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public ICollection<GameCategory> GameCategories { get; set; }
    }
}
