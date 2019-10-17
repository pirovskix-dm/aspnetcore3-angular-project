using ExploringTheCore.Core.Contracts.Exceptions;
using ExploringTheCore.Core.Exceptions.Errors;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ExploringTheCore.Core.Exceptions
{
    public abstract class BaseApiException : Exception, IApiException
    {
        private readonly ApiError apiError;

        protected BaseApiException(ApiError apiError)
        {
            this.apiError = apiError;
        }

        public IActionResult GetResult()
        {
            return new ObjectResult(this.apiError) { StatusCode = (int)this.apiError.Status };
        }
    }
}
