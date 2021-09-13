using Microsoft.AspNetCore.Mvc;
using VideoGameMetadataApi.CommunicationModel.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VideoGameMetadataApi.Core.Services;
using VideoGameMetadataApi.Extensions;

namespace VideoGameMetadataApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class GameController : ControllerBase
    {
        private readonly IGameService gameService;
        public GameController(IGameService gameService)
        {
            this.gameService = gameService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GameDto>>> GetGameData(
            [FromQuery(Name ="category")] IEnumerable<string> categories,
            string orderBy
        )
        {
            //TODO: rename the GetAll() to GetBy() and implement the filter-by-categories and order-by logic
            //TODO: include a check to make sure orderBy is an acceptable value
            var gameResult = await gameService.GetAll();
            return this.GetResult(gameResult);
        }

        [HttpPost]
        public async Task<GameDto> CreateGameDatum(GameDto game)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        public async Task<GameDto> UpdateGameDatum(string id, GameDto game)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public async Task<GameDto> DeleteGameDatum(string id)
        {
            throw new NotImplementedException();
        }
    }
}
