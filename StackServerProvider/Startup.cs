using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Cors;

namespace StackServerProvider
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

            services.AddCors(options =>
            {
                options.AddPolicy("MyPolicy",
                builder =>
                builder
                .SetIsOriginAllowed(origin => true)
                .AllowCredentials()
                .AllowAnyHeader()
                .AllowAnyMethod());
            });
            services.AddControllers()
            .AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.IgnoreNullValues = true;
            });
            services.AddSignalR(options =>
            {
                options.EnableDetailedErrors = true;
            }).AddJsonProtocol(ele =>
            {
                ele.PayloadSerializerOptions.IgnoreNullValues = true;
            });
            //.AddJsonOptions(opts => opts.JsonSerializerOptions.Converters.Add(new System.Text.Json.Serialization.JsonStringEnumConverter()));
            //services.AddMvc(option => option.EnableEndpointRouting = false);
            // services.AddMvc().AddJsonOptions(opt =>
            //          {
            //              opt.SerializerSettings.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver();//json字符串大小写原样输出
            //          });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors("MyPolicy");//.AllowCredentials());


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapHub<Hubs.ViewsHub>("/hub");
            });
            app.UseCors("MyPolicy");//.AllowCredentials());

        }
    }
}
