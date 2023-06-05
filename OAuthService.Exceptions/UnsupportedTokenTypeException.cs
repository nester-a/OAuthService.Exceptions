using OAuthConstans;
using OAuthService.Exceptions.Base;
using System;

namespace OAuthService.Exceptions
{
    public class UnsupportedTokenTypeException : OAuthErrorException
    {
        public override string ErrorCode => ErrorResponseErrorCode.UnsupportedTokenType;

        public UnsupportedTokenTypeException()
            : base() { }
        public UnsupportedTokenTypeException(string? errorDescription)
            : base(errorDescription) { }
        public UnsupportedTokenTypeException(string? errorDescription, Exception? innerException)
            : base(errorDescription, innerException) { }
    }
}
