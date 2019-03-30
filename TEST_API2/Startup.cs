using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TEST_API22;
using UnderstandingASPNETCore2x.Data;

namespace TEST_API2
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
       //public IGreeter Greeter { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddIdentity
            services.AddDbContext<FooContext>(options =>
                                              options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
                                              );

            services.AddScoped<IFooRepository, FooRepository>();

            services.AddSingleton<IGreeter, Greeter2>();

            services.AddMvc(config => { config.RespectBrowserAcceptHeader = true;})
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

            

            //Dog dog = new Dog();

            //Lab lab = new Lab();
            //string temp;
            //temp = dog.Foo();
            //temp = lab.Foo();
        }
    }
}
