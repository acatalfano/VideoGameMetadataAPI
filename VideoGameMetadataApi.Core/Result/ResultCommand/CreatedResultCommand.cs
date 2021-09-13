using Microsoft.AspNetCore.Mvc;
using System;

namespace VideoGameMetadataApi.Core.Result.ResultCommand
{
    class CreatedResultCommand<T> : ResultCommand<T> where T : class
    {
        public override ActionResult<T> GetResult(ControllerBase controller)
        {
            if (Body is null)
            {
                throw new InvalidOperationException("Must return the created resource");
            }
            else if (string.IsNullOrEmpty(Uri))
            {
                throw new InvalidOperationException("Must return the created resource URI");
            }

            return controller.Created(Uri, Body);
        }
    }
}