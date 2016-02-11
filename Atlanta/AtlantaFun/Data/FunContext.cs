using System;
using Microsoft.Data.Entity;
using Microsoft.Extensions.Configuration;

namespace AtlantaFun.Data
{
  public class FunContext : DbContext
  {
    IConfigurationRoot _config;
    public FunContext(IConfigurationRoot config)
    {
      _config = config;
    }

    public DbSet<Issue> Issues { get; set; }
    public DbSet<Person> People { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer(_config["Data:ConnectionString"]);
    }


  }
}