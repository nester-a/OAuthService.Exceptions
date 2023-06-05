using OAuthConstans;
using OAuthService.Exceptions.Base;
using System;
using System.Net;

namespace OAuthService.Exceptions
{
    public class InvalidGrantException : OAuthErrorException
    {
        public override string ErrorCode => ErrorResponseErrorCode.InvalidGrant;

        public InvalidGrantException()
            : base() { }
        public InvalidGrantException(string? errorDescription)
            : base(errorDescription) { }
        public InvalidGrantException(string? errorDescription, Exception? innerException)
            : base(errorDescription, innerException) { }
    }
}
