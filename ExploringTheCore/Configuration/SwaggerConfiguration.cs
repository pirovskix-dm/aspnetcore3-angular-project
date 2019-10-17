using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Swagger;

namespace ExploringTheCore.Configuration
{
    public static class SwaggerConfiguration
    {
        public static void ConfigureSwagger(this IServiceCollection services)
        {

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new OpenApiInfo()
                    {
                        Title = "Exploring the Core",
                        Version = "v1",
                        Description = string.Empty,
                        Contact = new OpenApiContact()
                        {
                            Name = "Pirovskix Dmitry",
                            Email = "pirovskix_dm@mail.ru"
                        }
                    }
                );
                c.EnableAnnotations();
                c.AddFluentValidationRules();
            });
        }

        public static void UseApiSwagger(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
            });
        }
    }
}
