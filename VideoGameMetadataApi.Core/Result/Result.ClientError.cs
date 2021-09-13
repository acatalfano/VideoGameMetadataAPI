using VideoGameMetadataApi.Core.Result.ResultCommand;

namespace VideoGameMetadataApi.Core.Result
{
    public partial class Result<T>
    {

        public void SetBadRequest(T body)
            => resultCommand =
                new BadRequestResultCommand<T>()
                    .WithBody(body);
    }

    public partial class Result
    {
        public void SetBadRequest() => resultCommand = new BadRequestResultCommand();
        public void SetUnauthorized() => resultCommand = new UnauthorizedResultCommand();
        public void SetForbidden() => resultCommand = new ForbiddenResultCommand();
        public void SetNotFound() => resultCommand = new NotFoundResultCommand();
    }
}
