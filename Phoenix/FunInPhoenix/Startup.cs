using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;

namespace FunInPhoenix
{
  public class Startup
  {
    private IConfigurationRoot _config;

    public Startup(IApplicationEnvironment env)
    {
      var builder = new ConfigurationBuilder()
        .SetBasePath(env.ApplicationBasePath)
        .AddJsonFile("config.json")
        .AddEnvironmentVariables();

      _config = builder.Build();

      var color = _config["FavoriteColors:Tuesday"];
      var j = color;
    }

    // This method gets called by the runtime. Use this method to add services to the container.
    // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddMvc(config => {
      });
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app)
    {
      app.UseStaticFiles();

      app.UseMvc();
    }

    // Entry point for the application.
    public static void Main(string[] args) => WebApplication.Run<Startup>(args);
  }
}
