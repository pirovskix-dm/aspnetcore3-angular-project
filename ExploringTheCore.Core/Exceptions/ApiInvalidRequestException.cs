using ExploringTheCore.Core.Contracts.Exceptions;
using ExploringTheCore.Core.Exceptions.Errors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ExploringTheCore.Core.Exceptions
{
    public class ApiInvalidRequestException : Exception, IApiException
    {
        public Dictionary<string, string> Fields { get; }

        public ApiInvalidRequestException()
        {
            this.Fields = new Dictionary<string, string>();
        }

        public ApiInvalidRequestException(string field, string message)
        {
            this.Fields = new Dictionary<string, string>()
            {
                { field, message }
            };
        }

        public ApiInvalidRequestException(Dictionary<string, string> fields)
        {
            this.Fields = fields;
        }

        public IActionResult GetResult()
        {
            var error = new ApiFieldsError(this.Fields);
            return new ObjectResult(error) { StatusCode = (int)error.Status };
        }
    }
}
