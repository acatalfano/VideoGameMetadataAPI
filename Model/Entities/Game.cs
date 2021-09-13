using System.Collections.Generic;

namespace VideoGameMetadataApi.Model.Entities
{
    public class Game
    {
        public string Id { get; set; }
        public int PublisherId { get; set; }
        public string Name { get; set; }
        public int ReleaseYear { get; set; }
        public int Players { get; set; }


        public Publisher Publisher { get; set; }

        public ICollection<GameCategory> GameCategories { get; set; }
    }
}
