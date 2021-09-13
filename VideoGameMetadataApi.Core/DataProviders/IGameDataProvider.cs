using System.Collections.Generic;
using System.Threading.Tasks;
using VideoGameMetadataApi.Model.Entities;

namespace VideoGameMetadataApi.Core.DataProviders
{
    public interface IGameDataProvider
    {
        Task<IEnumerable<Game>> GetAll();
    }
}
