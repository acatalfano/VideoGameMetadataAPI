using System;
using VideoGameMetadataApi.Core.Result.ResultCommand;

namespace VideoGameMetadataApi.Core.Result
{
    public partial class Result
    {
        public void SetInternalServerError(Exception ex)
            => resultCommand =
                new InternalServerErrorResultCommand()
                    #if DEBUG
                        .WithException(ex)
                    #endif

            ;
    }
}
