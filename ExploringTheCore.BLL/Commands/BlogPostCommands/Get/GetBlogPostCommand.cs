using ExploringTheCore.BLL.Models;
using MediatR;
using System;

namespace ExploringTheCore.BLL.Commands.BlogPostCommands.Get
{
    public class GetBlogPostCommand : IRequest<BlogPostDTO>
    {
        public Guid Id { get; set; }
    }
}
