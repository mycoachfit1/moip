using System;
using System.Net;

namespace MoipClient
{
    public class MoipException : Exception
    {
        public readonly HttpStatusCode StatusCode;
        public readonly ResponseError Error;
        
        public MoipException(string message, HttpStatusCode statusCode) : base(message)
        {
            StatusCode = statusCode;
        }

        public MoipException(string message, HttpStatusCode statusCode, ResponseError error) : this(message, statusCode)
        {
            Error = error;
        }
    }
}
