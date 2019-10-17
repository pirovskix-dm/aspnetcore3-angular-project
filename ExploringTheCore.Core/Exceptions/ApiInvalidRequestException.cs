using ExploringTheCore.Core.Exceptions.Errors;
using System.Collections.Generic;

namespace ExploringTheCore.Core.Exceptions
{
    public class ApiInvalidRequestException : BaseApiException
    {
        public ApiInvalidRequestException(string field, string message)
            : base(new ApiError422(new Dictionary<string, string>() { { field, message } }))
        {

        }

        public ApiInvalidRequestException(Dictionary<string, string> fields)
            : base(new ApiError422(fields))
        {
        }
    }
}
