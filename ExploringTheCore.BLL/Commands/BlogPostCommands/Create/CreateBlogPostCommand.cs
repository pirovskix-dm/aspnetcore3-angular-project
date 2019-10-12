using ExploringTheCore.BLL.Models;
using MediatR;
using System;

namespace ExploringTheCore.BLL.Commands.BlogPostCommands.Create
{
    public class CreateBlogPostCommand : BlogPostDTO, IRequest<Guid>
    {

    }
}
