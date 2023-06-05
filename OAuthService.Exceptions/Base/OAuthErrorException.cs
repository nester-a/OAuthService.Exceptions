using System;
using System.Net;

namespace OAuthService.Exceptions.Base
{
    public abstract class OAuthErrorException : Exception
    {
        public abstract string ErrorCode { get; }
        public virtual HttpStatusCode AssociatedStatusCode => HttpStatusCode.BadRequest;
        public string ErrorDescription => Message;

        public OAuthErrorException() 
            : base() { }
        public OAuthErrorException(string? errorDescription) 
            : base(errorDescription) { }
        public OAuthErrorException(string? errorDescription, Exception? innerException) 
            : base(errorDescription, innerException) { }
    }
}
