using OAuthConstans;
using OAuthService.Exceptions.Base;
using System;

namespace OAuthService.Exceptions
{
    public class InvalidScopeException : OAuthErrorException
    {
        public override string ErrorCode => ErrorResponseErrorCode.InvalidScope;

        public InvalidScopeException()
            : base() { }
        public InvalidScopeException(string? errorDescription)
            : base(errorDescription) { }
        public InvalidScopeException(string? errorDescription, Exception? innerException)
            : base(errorDescription, innerException) { }
    }
}
