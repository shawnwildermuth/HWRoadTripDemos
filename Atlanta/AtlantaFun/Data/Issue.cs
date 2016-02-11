using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtlantaFun.Data
{
  public class Issue
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Created { get; set; }

    public ICollection<Person> Owners { get; set; }

  }
}
