using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ExploringTheCore.Configuration
{
    public static class SwaggerConfiguration
    {
        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new Info()
                    {
                        Title = "Exploring the Core",
                        Version = "v1",
                        Description = string.Empty,
                        Contact = new Contact()
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
            app.UseSwagger(c =>
            {
                var basepath = "/v1";
                c.PreSerializeFilters.Add((swaggerDoc, httpReq) => swaggerDoc.BasePath = basepath);

                var regex = new Regex(Regex.Escape(basepath));
                c.PreSerializeFilters.Add((swaggerDoc, httpReq) =>
                {
                    IDictionary<string, PathItem> paths = new Dictionary<string, PathItem>();
                    foreach (var path in swaggerDoc.Paths)
                    {
                        paths.Add(regex.Replace(path.Key, "", 1), path.Value);
                    }
                    swaggerDoc.Paths = paths;
                });
            });

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
            });
        }
    }
}
