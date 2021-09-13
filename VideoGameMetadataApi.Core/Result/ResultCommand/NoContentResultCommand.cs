using Microsoft.AspNetCore.Mvc;

namespace VideoGameMetadataApi.Core.Result.ResultCommand
{
    class NoContentResultCommand : ResultCommand
    {
        public override ActionResult GetResult(ControllerBase controller) => controller.NoContent();
    }
}
