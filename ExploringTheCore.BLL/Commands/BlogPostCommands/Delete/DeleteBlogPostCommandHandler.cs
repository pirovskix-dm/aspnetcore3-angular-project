using ExploringTheCore.Core.Contracts.Repositories;
using ExploringTheCore.Core.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ExploringTheCore.BLL.Commands.BlogPostCommands.Delete
{
    public class DeleteBlogPostCommandHandler : IRequestHandler<DeleteBlogPostCommand, Guid>
    {
        private readonly IBlogPostRepository blogPostRepository;
        private readonly IUnitOfWork unitOfWork;

        public DeleteBlogPostCommandHandler(IBlogPostRepository blogPostRepository, IUnitOfWork unitOfWork)
        {
            this.blogPostRepository = blogPostRepository;
            this.unitOfWork = unitOfWork;
        }

        public async Task<Guid> Handle(DeleteBlogPostCommand request, CancellationToken cancellationToken)
        {
            var deletePost = new BlogPost() { Id = request.Id };
            blogPostRepository.Remove(deletePost);
            await unitOfWork.SaveAsync(cancellationToken);
            return request.Id;
        }
    }
}
