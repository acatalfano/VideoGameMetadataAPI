using Microsoft.AspNetCore.Mvc;
using System;

namespace VideoGameMetadataApi.Core.Result.ResultCommand
{
    /**
     * For results with a body
     */
    public abstract class ResultCommand<T> : ResultCommand where T : class
    {

        public T Body { protected get; set; }

        abstract public new ActionResult<T> GetResult(ControllerBase controller);
    }

    /**
     * For bodiless results
     */
    public abstract class ResultCommand
    {
        public string Uri { protected get; set; }
        public Exception Ex { protected get; set; }

        virtual public ActionResult GetResult(ControllerBase controller)
        {
            throw new NotImplementedException();
        }
    }
}
