using VideoGameMetadataApi.Core.Result.ResultCommand;

namespace VideoGameMetadataApi.Core.Result
{
    public partial class Result<T>
    {
        public void SetGenericOk(T body)
            => resultCommand =
                new OkResultCommand<T>()
                    .WithBody(body);

        public void SetCreated(string uri, T body)
            => resultCommand =
                new CreatedResultCommand<T>()
                    .WithUri(uri)
                    .WithBody(body);
    }

    public partial class Result
    {
        public void SetGenericOk() => resultCommand = new OkResultCommand();
        public void SetSuccessNoContent() => resultCommand = new NoContentResultCommand();
    }
}
