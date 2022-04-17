using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using TravelApi.Models;
using Microsoft.OpenApi.Models;

namespace TravelApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<TravelApiContext>(opt =>
                opt.UseMySql(Configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(Configuration["ConnectionStrings:DefaultConnection"])));
            services.AddControllers();

            // registered the Swagger generator, defining one or more Swagger documents.
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo 
            {
                Title = "TravelApi",
                Version = "v1", 
                Description = "A simple yet functional of an Travel ASP.NET Core Web API",
                // Contact = new OpenApiContact
                // {
                // Name = "Erika Debelis",
                // Email = "erika.debelis@gmail.com",
                // Url = new Uri("https://www.linkedin.com/in/erika-debelis/")
                // },
                // License = new OpenApiLicense
                // {
                // Name = "Use under AFL",
                // Url = new Uri("https://opensource.org/licenses/AFL-3.0"),
                // }
            });
        });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                // exposed the generated Swagger as JSON endpoint(s) using middleware
                app.UseSwagger(c =>
                {
                    c.SerializeAsV2 = true;
                });
                    // inserted the swagger-ui middleware to expose interactive documentation, specifying the Swagger JSON endpoint(s) to power it from
                    app.UseSwaggerUI(c => 
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Destinations v1");
                });
            }

            // app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}