using OAuthConstans;
using OAuthService.Exceptions.Base;
using System;

namespace OAuthService.Exceptions
{
    public class AccessDeniedException : OAuthErrorException
    {
        public override string ErrorCode => ErrorResponseErrorCode.AccessDenied;

        public AccessDeniedException() : base() { }
        public AccessDeniedException(string? errorDescription) : base(errorDescription) { }
        public AccessDeniedException(string? errorDescription, Exception? innerException) : base(errorDescription, innerException) { }
    }
}
