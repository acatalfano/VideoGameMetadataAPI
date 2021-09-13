using Microsoft.AspNetCore.Mvc;

namespace VideoGameMetadataApi.Core.Result.ResultCommand
{
    class InternalServerErrorResultCommand : ResultCommand
    {

        public override ActionResult GetResult(ControllerBase controller)
            => controller.StatusCode(500, new { Ex.Message, Ex.StackTrace });
    }
}
