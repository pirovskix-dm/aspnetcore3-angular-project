using ExploringTheCore.Core.Contracts.Repositories;
using ExploringTheCore.Core.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ExploringTheCore.BLL.Commands.BlogPostCommands.Create
{
    public class CreateBlogPostCommandHandler : IRequestHandler<CreateBlogPostCommand, Guid>
    {
        private readonly IBlogPostRepository blogPostRepository;
        private readonly IUnitOfWork unitOfWork;

        public CreateBlogPostCommandHandler(IBlogPostRepository blogPostRepository, IUnitOfWork unitOfWork)
        {
            this.blogPostRepository = blogPostRepository;
            this.unitOfWork = unitOfWork;
        }

        public async Task<Guid> Handle(CreateBlogPostCommand request, CancellationToken cancellationToken)
        {
            var now = DateTime.UtcNow;

            var newPost = new BlogPost()
            {
                Title = request.Title,
                Content = request.Content,
                DateCreated = now,
                DateLastUpdated = now
            };

            blogPostRepository.Add(newPost);
            await unitOfWork.SaveAsync(cancellationToken);
            return newPost.Id;
        }
    }
}
