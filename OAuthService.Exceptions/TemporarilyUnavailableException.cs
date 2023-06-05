using OAuthConstans;
using OAuthService.Exceptions.Base;
using System;
using System.Net;

namespace OAuthService.Exceptions
{
    public class TemporarilyUnavailableException : OAuthErrorException
    {
        public override string ErrorCode => ErrorResponseErrorCode.TemporarilyUnavailable;
        public override HttpStatusCode AssociatedStatusCode => HttpStatusCode.ServiceUnavailable;

        public TemporarilyUnavailableException()
            : base() { }
        public TemporarilyUnavailableException(string? errorDescription)
            : base(errorDescription) { }
        public TemporarilyUnavailableException(string? errorDescription, Exception? innerException)
            : base(errorDescription, innerException) { }
    }
}
