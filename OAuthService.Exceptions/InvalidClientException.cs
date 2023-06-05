using OAuthConstans;
using OAuthService.Exceptions.Base;
using System;
using System.Net;

namespace OAuthService.Exceptions
{
    public class InvalidClientException : OAuthErrorException
    {
        public override string ErrorCode => ErrorResponseErrorCode.InvalidClient;
        public override HttpStatusCode AssociatedStatusCode => HttpStatusCode.Unauthorized;

        public InvalidClientException()
            : base() { }
        public InvalidClientException(string? errorDescription)
            : base(errorDescription) { }
        public InvalidClientException(string? errorDescription, Exception? innerException)
            : base(errorDescription, innerException) { }
    }
}
