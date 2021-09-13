namespace VideoGameMetadataApi.Model.Entities
{
    public class GameCategory
    {
        public long GameId { get; set; }
        public Category Game { get; set; }
        public long CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
