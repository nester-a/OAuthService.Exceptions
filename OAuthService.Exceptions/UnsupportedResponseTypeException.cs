using OAuthConstans;
using OAuthService.Exceptions.Base;
using System;

namespace OAuthService.Exceptions
{
    public class UnsupportedResponseTypeException : OAuthErrorException
    {
        public override string ErrorCode => ErrorResponseErrorCode.UnsupportedResponseType;

        public UnsupportedResponseTypeException()
            : base() { }
        public UnsupportedResponseTypeException(string? errorDescription)
            : base(errorDescription) { }
        public UnsupportedResponseTypeException(string? errorDescription, Exception? innerException)
            : base(errorDescription, innerException) { }
    }
}
