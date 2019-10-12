using ExploringTheCore.Core.Contracts.Exceptions;
using ExploringTheCore.Core.Exceptions.Errors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;

namespace ExploringTheCore.Core.Exceptions
{
    public abstract class BaseApiException : Exception, IApiException
    {
        public string Code { get; }

        public HttpStatusCode Status { get; }

        protected BaseApiException(HttpStatusCode status, string code, string message)
            : base(message)
        {
            Status = status;
            Code = code;
        }

        public IActionResult GetResult()
        {
            var error = new ApiError(Status, Code, Message);
            return new ObjectResult(error) { StatusCode = (int)error.Status };
        }
    }
}
