using Dependency_Injection_Crud.Models;
using Dependency_Injection_Crud.StudentModel;
using Dependency_Injection_Crud.StudentRepo;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Identity.Web;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dependency_Injection_Crud.StudentService;

namespace Dependency_Injection_Crud
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
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddMicrosoftIdentityWebApi(Configuration.GetSection("AzureAd"));

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Dependency_Injection_Crud", Version = "v1" });
            });

            services.AddDbContext<CoreDbContext>(op => op.UseSqlServer(Configuration.GetConnectionString("Database"))); //Add       

            // ismai bee   jab jab hum request krnge to ye every time new instance create krega

             services.AddTransient(typeof(IStudent),typeof(StudentRepo1));   // first way inject service
            //services.AddTransient<IStudent, StudentRepo1>();    second way inject service

           // services.AddTransient(typeof(StudentRepo1), typeof(StudentRepo1));
            

            /*
             * Whenever I used AddSingleton() then  I got this Exception
             * 
             * AggregateException: 
             * Some services are not able to be constructed (Error while validating the service descriptor 'ServiceType: Dependency_Injection_Crud.StudentRepo.
             * IStudent Lifetime: Singleton ImplementationType: Dependency_Injection_Crud.StudentService.StudentRepo1': 
             * Cannot consume scoped service 'Dependency_Injection_Crud.Models.CoreDbContext' from singleton 'Dependency_Injection_Crud.StudentRepo.IStudent'.)
             */

           // services.AddSingleton(typeof(IStudent), typeof(StudentRepo1));

            // services.AddScoped(typeof(IStudent), typeof(StudentRepo1));

            // jab jab hum request krnge to ye every time new instance create krega

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Dependency_Injection_Crud v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
