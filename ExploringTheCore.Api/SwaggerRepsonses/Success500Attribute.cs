using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Net;

namespace ExploringTheCore.Api.SwaggerRepsonses
{
    public class Success500Attribute : SwaggerResponseAttribute
    {
        public Success500Attribute(Type type)
            : base((int)HttpStatusCode.OK, type: type)
        {
        }
    }
}
