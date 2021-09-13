using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VideoGameMetadataApi.CommunicationModel.Dtos;
using VideoGameMetadataApi.Core.DataProviders;
using VideoGameMetadataApi.Core.Result;
using VideoGameMetadataApi.Core.Services;

namespace VideoGameMetadataApi.Services
{
    public class GameService : IGameService
    {
        private readonly IGameDataProvider gameDataProvider;
        private readonly IMapper mapper;
        public GameService(
            IGameDataProvider gameDataProvider,
            IMapper mapper
        )
        {
            this.gameDataProvider = gameDataProvider;
            this.mapper = mapper;
        }

        public async Task<Result<IEnumerable<GameDto>>> GetAll()
        {
            Result<IEnumerable<GameDto>> result = new Result<IEnumerable<GameDto>>();

            try
            {
                var dataResult = await gameDataProvider.GetAll();
                IEnumerable<GameDto> gameDtos = mapper.Map<IEnumerable<GameDto>>(dataResult);
                result.SetGenericOk(gameDtos);
            }
            catch (Exception ex)
            {
                result.SetInternalServerError(ex);
            }
            return result;
        }
    }
}
