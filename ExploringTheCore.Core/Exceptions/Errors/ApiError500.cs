using System.Net;

namespace ExploringTheCore.Core.Exceptions.Errors
{
    public class ApiError500 : ApiError
    {
        public ApiError500(string message)
            : base(HttpStatusCode.InternalServerError, "internal_server_error", message)
        {
        }
    }
}
