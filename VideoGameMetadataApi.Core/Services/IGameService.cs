using System.Collections.Generic;
using System.Threading.Tasks;
using VideoGameMetadataApi.CommunicationModel.Dtos;
using VideoGameMetadataApi.Core.Result;

namespace VideoGameMetadataApi.Core.Services
{
    public interface IGameService
    {
        public Task<Result<IEnumerable<GameDto>>> GetAll();
    }
}
