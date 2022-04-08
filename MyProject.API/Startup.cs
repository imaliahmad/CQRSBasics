using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MyProject.CQRS.Commands;
using MyProject.CQRS.Commands.interfaces;
using MyProject.CQRS.Data;
using MyProject.CQRS.Queries;
using MyProject.CQRS.Queries.interfaces;
using MyProject.CQRS.Repositories;
using MyProject.CQRS.Repositories.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.API
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
            services.AddControllers();

            #region Register Sevices
            //DbContext
            services.AddDbContext<EFCoreDbContext>();

            //Commands
            services.AddTransient<IDepartmentsCommands, DepartmentsCommands>();

            //Queries
            services.AddTransient<IDepartmentsQueries, DepartmentsQueries>();

            //Repositories
            services.AddTransient<IDepartmentsCommandRepository, DepartmentsCommandRepository>();
            services.AddTransient<IDepartmentsQueriesRepository, DepartmentsQueriesRepository>(); 
            #endregion

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

           // app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
