using OAuthConstans;
using OAuthService.Exceptions.Base;
using System;

namespace OAuthService.Exceptions
{
    public class UnauthorizedClientException : OAuthErrorException
    {
        public override string ErrorCode => ErrorResponseErrorCode.UnauthorizedClient;

        public UnauthorizedClientException()
            : base() { }
        public UnauthorizedClientException(string? errorDescription)
            : base(errorDescription) { }
        public UnauthorizedClientException(string? errorDescription, Exception? innerException)
            : base(errorDescription, innerException) { }
    }
}
