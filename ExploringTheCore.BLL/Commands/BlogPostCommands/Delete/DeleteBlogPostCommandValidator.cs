using FluentValidation;
using System;

namespace ExploringTheCore.BLL.Commands.BlogPostCommands.Delete
{
    public class DeleteBlogPostCommandValidator : AbstractValidator<DeleteBlogPostCommand>
    {
        public DeleteBlogPostCommandValidator()
        {
            RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty);
        }
    }
}
