using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using orenji_backend.Data;

namespace orenji_backend
{
    public class Startup
    {
        private readonly string orenjiConnectionString = "Server=localhost; Uid=root; Database=orenji; Pwd=root;"; //Environment.GetEnvironmentVariable("orenji_connection_string");
        
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<OrenjiContext>(options => 
                options.UseMySql(orenjiConnectionString, 
                    ServerVersion.AutoDetect(orenjiConnectionString))); 
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo {Title = "orenji_backend", Version = "v1"});
            });
            services.AddCors(options =>
            {
                options.AddPolicy("AllowCORS", builder => builder.WithOrigins("localhost:3000"));
                options.AddPolicy("ClientPermission", policy =>
                {
                    policy.AllowAnyHeader()
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .WithOrigins("http://localhost:3000")
                        .AllowCredentials();
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "orenji_backend v1"));
            }
            else
            {
                app.UseHsts();
            }
            
            using (IServiceScope scope = app.ApplicationServices.CreateScope())
            using (var context = scope.ServiceProvider.GetService<OrenjiContext>())
            {
                context.Database.EnsureCreated();
            }

            app.UseCors(x => x
                .AllowAnyMethod()
                .AllowAnyHeader()
                .SetIsOriginAllowed(origin => true)
                .AllowCredentials());
            
            app.UseHttpsRedirection();

            app.UseAuthentication();
            
            app.UseRouting();
            
            app.UseCors();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}