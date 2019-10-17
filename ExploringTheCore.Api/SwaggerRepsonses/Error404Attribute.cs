using ExploringTheCore.Core.Exceptions.Errors;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace ExploringTheCore.Api.SwaggerRepsonses
{
    public class Error404Attribute : SwaggerResponseAttribute
    {
        public Error404Attribute()
            : base((int)HttpStatusCode.NotFound, type: typeof(ApiError404))
        {

        }
    }
}
