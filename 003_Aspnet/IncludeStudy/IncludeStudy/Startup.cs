using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IncludeStudy.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace IncludeStudy
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
            services.AddDbContext<DemoContext>(opt => opt.UseInMemoryDatabase("includeTest"));
            services.AddControllers().AddNewtonsoftJson(opt =>
                opt.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);

            var options = new DbContextOptionsBuilder<DemoContext>().UseInMemoryDatabase(databaseName: "includeTest").Options;
            using (var context = new DemoContext(options))
            {
                AddTestData(context);
            }
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }

        public void AddTestData(DemoContext context)
        {
            var company1 = new Company(1, "äîéÆâÔé–A");
            var company2 = new Company(2, "äîéÆâÔé–B");

            var emp1 = new Employee(1, "óÈñÿ");
            var emp2 = new Employee(2, "éRìc");
            var emp3 = new Employee(3, "çÇêô");
            var emp4 = new Employee(4, "ãgìc");

            emp1.CompanyId = company1.Id;
            emp2.CompanyId = company1.Id;
            emp3.CompanyId = company1.Id;
            emp4.CompanyId = company2.Id;

            context.Company.AddRange(company1,company2);
            context.Employee.AddRange(emp1,emp2,emp3,emp4);
            context.SaveChanges();
        }
    }
}
