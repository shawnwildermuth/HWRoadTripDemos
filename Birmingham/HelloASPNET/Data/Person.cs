using System;
using System.Collections.Generic;

namespace HelloASPNET.Data
{
  public class Person
  {
    public int Id { get; set; }
    public string Name { get; set; }

    public ICollection<Color> FavoriteColors { get; set; }
  }
}
