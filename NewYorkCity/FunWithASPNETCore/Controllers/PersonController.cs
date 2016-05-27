using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FunWithASPNETCore.Controllers
{
  public class PersonController : Controller
  {
    [HttpGet("/api/people")]
    public IActionResult Get()
    {
      return BadRequest("Baddie");

      return Created($"/api/people/1", new Person() { Name = "Shawn" });
    }
  }

  public class Person
  {
    public string Name { get; set; }

  }
}
