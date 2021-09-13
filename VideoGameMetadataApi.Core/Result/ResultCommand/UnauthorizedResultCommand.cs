using Microsoft.AspNetCore.Mvc;

namespace VideoGameMetadataApi.Core.Result.ResultCommand
{
    class UnauthorizedResultCommand : ResultCommand
    {
        public override ActionResult GetResult(ControllerBase controller)
            => controller.Unauthorized();
    }
}