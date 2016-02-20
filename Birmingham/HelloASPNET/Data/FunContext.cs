using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using Microsoft.Extensions.Configuration;

namespace HelloASPNET.Data
{
  public class FunContext : DbContext
  {
    private IConfigurationRoot _config;

    public FunContext(IConfigurationRoot config)
    {
      _config = config;

      Database.EnsureCreated();
      Database.Migrate();
    }

    public DbSet<Person> People { get; set; }
    public DbSet<Color> Colors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      base.OnConfiguring(optionsBuilder);

      optionsBuilder.UseSqlServer(_config["Data:TheConnectionString"]);
    }
  }
}
