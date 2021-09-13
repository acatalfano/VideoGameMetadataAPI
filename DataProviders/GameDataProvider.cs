using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using VideoGameMetadataApi.Core.DataProviders;
using VideoGameMetadataApi.Model;
using VideoGameMetadataApi.Model.Entities;

namespace VideoGameMetdataApi.DataProviders
{
    public class GameDataProvider : IGameDataProvider
    {
        private readonly VideoGameDbContext dbContext;
        public GameDataProvider(VideoGameDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<Game>> GetAll()
        {
            return await dbContext.Games.ToListAsync();
        }
    }
}
