using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FunWithASPNETCore.Controllers
{
  public class RootController : Controller
  {
    [HttpGet("/")]
    public IActionResult Index()
    {
      throw new InvalidOperationException("Bad things happen to good developers");


      ViewBag.Title = "Hello World";
      return View();
    }

    [HttpGet("/api/foo")]
    public IActionResult Foo()
    {
      if (false) return BadRequest("Bad bad bad");

      return Ok(new Person() { Name = "Shawn" });
    }

    [HttpPost("/api/foo")]
    public IActionResult Foo([FromBody] Person newPerson)
    {
      return Created($"/api/foo/{newPerson.Name}", new Person() { Name = "Shawn" });
    }

  }

  public class Person
  {
    public string Name { get; set; }

  }
}









