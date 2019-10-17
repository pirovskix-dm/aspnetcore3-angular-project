using ExploringTheCore.Core.Contracts.Exceptions;
using ExploringTheCore.Core.Exceptions.Errors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ExploringTheCore.Filters
{
    public class ApiExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if (context.Exception is IApiException apiException)
            {
                context.Result = apiException.GetResult();
            }
            else
            {
                HandleInternalServerError(context);
            }
        }

        private void HandleInternalServerError(ExceptionContext context)
        {
            var error = new ApiError500(context.Exception.Message);
            context.Result = new ObjectResult(error) { StatusCode = (int)error.Status };
        }
    }
}
