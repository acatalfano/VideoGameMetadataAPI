using System;

namespace VideoGameMetadataApi.Core.Result.ResultCommand
{
    internal static class ResultCommandExtensions
    {
        public static ResultCommand<T> WithUri<T>(this ResultCommand<T> resultCommand, string uri)
            where T : class
        {
            resultCommand.Uri = uri;
            return resultCommand;
        }

        public static ResultCommand WithException(
            this InternalServerErrorResultCommand resultCommand,
            Exception ex
        )
        {
            resultCommand.Ex = ex;
            return resultCommand;
        }

        public static ResultCommand<T> WithBody<T>(this ResultCommand<T> resultCommand, T body)
            where T : class
        {
            resultCommand.Body = body;
            return resultCommand;
        }
    }
}
