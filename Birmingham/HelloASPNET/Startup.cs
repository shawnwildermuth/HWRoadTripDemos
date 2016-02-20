using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloASPNET.Data;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;

namespace HelloASPNET
{
  public class Startup
  {
    private IConfigurationRoot _root;

    public Startup(IApplicationEnvironment appEnv)
    {
      var builder = new ConfigurationBuilder()
        .SetBasePath(appEnv.ApplicationBasePath)
        .AddJsonFile("config.json")
        .AddEnvironmentVariables();

      _root = builder.Build();
    }

    // This method gets called by the runtime. Use this method to add services to the container.
    // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddInstance(typeof(IConfigurationRoot), _root);

      services.AddEntityFramework()
        .AddDbContext<FunContext>()
        .AddSqlServer();

      services.AddMvc();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app)
    {

      app.UseStaticFiles();

      app.UseDeveloperExceptionPage();

      app.UseMvc();
    }

    // Entry point for the application.
    public static void Main(string[] args) => WebApplication.Run<Startup>(args);
  }
}
