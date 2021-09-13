using Microsoft.AspNetCore.Mvc;

namespace VideoGameMetadataApi.Core.Result.ResultCommand
{
    class NotFoundResultCommand : ResultCommand
    {
        public override ActionResult GetResult(ControllerBase controller) => controller.NotFound();
    }
}
