using ExploringTheCore.Core.Contracts.Repositories;
using ExploringTheCore.TestData.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace ExploringTheCore.TestData
{
    public static class ServiceConfiguration
    {
        public static void ConfigureTestData(this IServiceCollection services)
        {
            services.AddScoped<IBlogPostRepository, BlogPostRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
