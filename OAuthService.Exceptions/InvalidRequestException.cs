using OAuthConstans;
using OAuthService.Exceptions.Base;
using System;
using System.Net;

namespace OAuthService.Exceptions
{
    public class InvalidRequestException : OAuthErrorException
    {
        public override string ErrorCode => ErrorResponseErrorCode.InvalidRequest;

        public InvalidRequestException()
            : base() { }
        public InvalidRequestException(string? errorDescription)
            : base(errorDescription) { }
        public InvalidRequestException(string? errorDescription, Exception? innerException)
            : base(errorDescription, innerException) { }
    }
}
