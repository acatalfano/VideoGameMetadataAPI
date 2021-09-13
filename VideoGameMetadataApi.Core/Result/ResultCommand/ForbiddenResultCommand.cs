using Microsoft.AspNetCore.Mvc;

namespace VideoGameMetadataApi.Core.Result.ResultCommand
{
    class ForbiddenResultCommand : ResultCommand
    {
        public override ActionResult GetResult(ControllerBase controller) => controller.Forbid();
    }
}
