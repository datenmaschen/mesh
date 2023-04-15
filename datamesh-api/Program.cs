using Datamesh.Models;
using Datamesh.Data;
using System.Reflection;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;


public class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddDbContext<DatameshContext>((provider, options) =>
        {
            options.UseSqlServer(builder.Configuration.GetConnectionString("DatameshConnString"));
            //options.AddInterceptors(provider.GetRequiredService<AadAuthenticationDbConnectionInterceptor>());
        });
        
        // Add services to the container.
        builder.Services.AddControllers();
        //builder.Services.AddDatabaseDeveloperPageExceptionFilter();

        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1", new()
            {
                Version = "v1",
                Title = "Datamesh API",
                Description = "A simple ASP.NET Core Web API",
                TermsOfService = new Uri("https://example.com/terms"),
                Contact = new OpenApiContact
                {
                    Name = "Philipp Frenzel",
                    Email = "Philipp@Frenzel.net",
                },
                License = new OpenApiLicense
                {
                    Name = "Use under MIT",
                }
            });
            // using System.Reflection;
            var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
        });

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger(options =>
            {
                options.SerializeAsV2 = true;
            });

            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "Datamesh v1");
                options.RoutePrefix = string.Empty;
            });
        }

        //app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}