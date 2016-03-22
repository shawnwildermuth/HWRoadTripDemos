using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FunWithASPNET
{
  public class Startup
  {
    private IConfigurationRoot _config;

    public Startup()
    {
      var builder = new ConfigurationBuilder()
        //.AddJsonFile("config.json")
        .AddEnvironmentVariables();

      _config = builder.Build();
      var favoriteColor = _config["FavoriteColors"];
    }

    // This method gets called by the runtime. Use this method to add services to the container.
    // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddMvc();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      if (env.IsEnvironment("Development"))
      {
        app.UseDeveloperExceptionPage();
      }

      app.UseStaticFiles();

      app.UseMvc();
    }

    // Entry point for the application.
    public static void Main(string[] args) => WebApplication.Run<Startup>(args);
  }
}
