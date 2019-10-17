using ExploringTheCore.Api.SwaggerRepsonses;
using ExploringTheCore.BLL.Commands.BlogPostCommands.Create;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Threading.Tasks;

namespace ExploringTheCore.Api.Controllers.v1
{
    [Route("/v1/blog")]
    [ApiController]
    [Produces("application/json")]
    public class BlogPostController : Controller
    {
        private readonly IMediator mediator;

        public BlogPostController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        [SwaggerOperation("Create a blog post")]
        [Success500(typeof(Guid))]
        [Error422]
        public async Task<ActionResult<Guid>> CreateBlog([FromBody] CreateBlogPostCommand command)
        {
            return Ok(await mediator.Send(command));
        }
    }
}
