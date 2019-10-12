using FluentValidation;

namespace ExploringTheCore.BLL.Commands.BlogPostCommands.Create
{
    public class CreateBlogPostCommandValidator : AbstractValidator<CreateBlogPostCommand>
    {
        public CreateBlogPostCommandValidator()
        {
            RuleFor(p => p.Title).MaximumLength(100).NotEmpty();
            RuleFor(p => p.Content).NotEmpty();
        }
    }
}
