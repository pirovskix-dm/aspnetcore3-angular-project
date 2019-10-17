using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;

namespace ExploringTheCore.Core.Exceptions.Errors
{
    public class ApiError422 : ApiError
    {
        [JsonProperty("fields")]
        public Dictionary<string, string> Fields { get; }

        public ApiError422(Dictionary<string, string> fields)
            : base(HttpStatusCode.UnprocessableEntity, "invalid_request", "Invalid request")
        {
            Fields = fields;
        }
    }
}
