using ExploringTheCore.Core.Exceptions.Errors;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace ExploringTheCore.Api.SwaggerRepsonses
{
    public class Error422Attribute : SwaggerResponseAttribute
    {
        public Error422Attribute()
            : base((int)HttpStatusCode.UnprocessableEntity, type: typeof(ApiError422))
        {
        }
    }
}
