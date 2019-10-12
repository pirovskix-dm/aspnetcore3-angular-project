using ExploringTheCore.BLL.Models;
using ExploringTheCore.Core.Contracts.Repositories;
using ExploringTheCore.Core.Entities;
using ExploringTheCore.Core.Exceptions;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ExploringTheCore.BLL.Commands.BlogPostCommands.Get
{
    public class GetBlogPostCommandHandler : IRequestHandler<GetBlogPostCommand, BlogPostDTO>
    {
        private readonly IBlogPostRepository blogPostRepository;

        public GetBlogPostCommandHandler(IBlogPostRepository blogPostRepository)
        {
            this.blogPostRepository = blogPostRepository;
        }

        public async Task<BlogPostDTO> Handle(GetBlogPostCommand request, CancellationToken cancellationToken)
        {
            BlogPostDTO? result = await blogPostRepository.GetAsync(request.Id, (BlogPost p) => new BlogPostDTO()
            {
                Id = p.Id,
                Title = p.Title,
                Content = p.Content,
                DateCreated = p.DateCreated,
                DateLastUpdated = p.DateLastUpdated
            }, cancellationToken);

            if (result == null)
            {
                throw new ApiNotFoundException("The specified BlogPost is not found");
            }

            return result;
        }
    }
}
