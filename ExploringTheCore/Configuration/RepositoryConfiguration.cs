using ExploringTheCore.Core.Contracts.Repositories;
using ExploringTheCore.TestData.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace ExploringTheCore.Configuration
{
    public static class RepositoryConfiguration
    {
        public static void ConfigureRrepository(this IServiceCollection services)
        {
            services.AddScoped<IBlogPostRepository, BlogPostRepository>();
        }
    }
}
