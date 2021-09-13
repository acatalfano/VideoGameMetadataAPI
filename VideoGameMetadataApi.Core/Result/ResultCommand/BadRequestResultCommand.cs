using Microsoft.AspNetCore.Mvc;

namespace VideoGameMetadataApi.Core.Result.ResultCommand
{
    class BadRequestResultCommand<T> : ResultCommand<T> where T : class
    {
        public override ActionResult<T> GetResult(ControllerBase controller)
            => controller.BadRequest(Body);
    }

    class BadRequestResultCommand : ResultCommand
    {
        public override ActionResult GetResult(ControllerBase controller)
            => controller.BadRequest();
    }
}
