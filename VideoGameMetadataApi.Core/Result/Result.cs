using Microsoft.AspNetCore.Mvc;
using VideoGameMetadataApi.Core.Result.ResultCommand;

namespace VideoGameMetadataApi.Core.Result
{
    public partial class Result<T> : Result where T : class
    {
        protected new ResultCommand<T> resultCommand;

        public new ActionResult<T> GetResult(ControllerBase controller)
        {
            return resultCommand.GetResult(controller);
        }
    }

    public partial class Result
    {
        protected ResultCommand.ResultCommand resultCommand;

        public ActionResult GetResult(ControllerBase controller)
        {
            return resultCommand.GetResult(controller);
        }
    }
}
