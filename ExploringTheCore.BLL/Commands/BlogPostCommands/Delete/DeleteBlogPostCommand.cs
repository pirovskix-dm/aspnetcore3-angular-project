using MediatR;
using System;

namespace ExploringTheCore.BLL.Commands.BlogPostCommands.Delete
{
    public class DeleteBlogPostCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
    }
}
