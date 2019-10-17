using System.Net;

namespace ExploringTheCore.Core.Exceptions.Errors
{
    public class ApiError404 : ApiError
    {
        public ApiError404(string message)
            : base(HttpStatusCode.NotFound, "not_found", message)
        {
        }
    }
}
