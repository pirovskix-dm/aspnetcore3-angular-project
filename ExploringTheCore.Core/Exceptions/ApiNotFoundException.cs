using System.Net;

namespace ExploringTheCore.Core.Exceptions
{
    public class ApiNotFoundException : BaseApiException
    {
        public ApiNotFoundException(string message)
            : base(HttpStatusCode.NotFound, "not_found", message)
        {

        }
    }
}
