using OAuthConstans;
using OAuthService.Exceptions.Base;
using System;
using System.Net;

namespace OAuthService.Exceptions
{
    public class ServerErrorException : OAuthErrorException
    {
        public override string ErrorCode => ErrorResponseErrorCode.ServerError;
        public override HttpStatusCode AssociatedStatusCode => HttpStatusCode.InternalServerError;

        public ServerErrorException()
            : base() { }
        public ServerErrorException(string? errorDescription)
            : base(errorDescription) { }
        public ServerErrorException(string? errorDescription, Exception? innerException)
            : base(errorDescription, innerException) { }
    }
}
