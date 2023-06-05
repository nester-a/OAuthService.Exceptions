using OAuthConstans;
using OAuthService.Exceptions.Base;
using System;

namespace OAuthService.Exceptions
{
    public class UnsupportedGrantTypeException : OAuthErrorException
    {
        public override string ErrorCode => ErrorResponseErrorCode.UnsupportedGrantType;

        public UnsupportedGrantTypeException()
            : base() { }
        public UnsupportedGrantTypeException(string? errorDescription)
            : base(errorDescription) { }
        public UnsupportedGrantTypeException(string? errorDescription, Exception? innerException)
            : base(errorDescription, innerException) { }
    }
}
