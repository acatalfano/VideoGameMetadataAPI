using Microsoft.AspNetCore.Mvc;
using System;

namespace VideoGameMetadataApi.Core.Result.ResultCommand
{
    class OkResultCommand<T> : ResultCommand<T> where T : class
    {
        public override ActionResult<T> GetResult(ControllerBase controller)
        {
            if (!(Body is null))
            {
                return controller.Ok(Body);
            }
            else
            {
                throw new InvalidOperationException("Use GetEmptyResult() instead");
            }
        }
    }

    class OkResultCommand : ResultCommand
    {
        public override ActionResult GetResult(ControllerBase controller) => controller.Ok();
    }
}
