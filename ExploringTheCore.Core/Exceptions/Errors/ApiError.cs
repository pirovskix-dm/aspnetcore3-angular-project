using Newtonsoft.Json;
using System.Net;

namespace ExploringTheCore.Core.Exceptions.Errors
{
    public class ApiError
    {
        [JsonProperty("status")]
        public HttpStatusCode Status { get; }

        [JsonProperty("code")]
        public string Code { get; }

        [JsonProperty("message")]
        public string Message { get; }

        public ApiError(HttpStatusCode status, string code, string message)
        {
            Status = status;
            Code = code;
            Message = message;
        }
    }
}
