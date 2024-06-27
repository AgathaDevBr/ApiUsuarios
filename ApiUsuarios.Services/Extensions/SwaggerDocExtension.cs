using Microsoft.OpenApi.Models;
using System.Reflection;

namespace ApiUsuarios.Services.Extensions
{
    public static class SwaggerDocExtension
    {
        /// <summary>
        /// Personalizando o conteudo da documentação gerada pelo Swagger
        /// </summary>
        public static IServiceCollection AddSwaggerDoc
        (this IServiceCollection services)

        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "API de controle de usuários e estudantes",
                    Description = "API REST desenvolvida em AspNet 6 com EntityFramework",
                    Version = "v1",
                    Contact = new OpenApiContact
                    {
                        Name = "Ágatha Santos",
                        Email = "contatoagathaofc@gmail.com",
                    }
                });
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext
                .BaseDirectory, xmlFile);
                options.IncludeXmlComments(xmlPath);
            });
            return services;
        }

        /// <summary>
        /// Configurando a execução da página de documentação
        /// </summary>
        public static IApplicationBuilder UseSwaggerDoc

        (this IApplicationBuilder app)

        {
            app.UseSwagger(); 
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint

                ("/swagger/v1/swagger.json", "ApiUsuarios.Services");

            });
            return app;
        }
    }
}
   