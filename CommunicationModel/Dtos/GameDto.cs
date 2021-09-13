using System.Collections.Generic;

namespace VideoGameMetadataApi.CommunicationModel.Dtos
{
    public class GameDto
    {
        public List<string> Categories { get; set; }
        public string Name { get; set; }
        public PublisherDto Publisher { get; set; }
        public int ReleaseYear { get; set; }
    }
}
