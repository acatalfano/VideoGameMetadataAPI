using Microsoft.AspNetCore.Mvc;
using VideoGameMetadataApi.Core.Result;
using VideoGameMetadataApi.Core.Result.ResultCommand;

namespace VideoGameMetadataApi.Extensions
{
    public static class ControllerBaseExtensions
    {
        public static ActionResult GetResult(
            this ControllerBase controller,
            Result result
        ) => result.GetResult(controller);

        public static ActionResult<T> GetResult<T>(
            this ControllerBase controller,
            Result<T> result
        ) where T : class
            => result.GetResult(controller);
    }
}
