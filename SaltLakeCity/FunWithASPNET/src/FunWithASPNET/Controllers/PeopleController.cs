using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;

namespace FunWithASPNET.Controllers
{
  [Route("api/people")]
  public class PeopleController : Controller
  {
    [HttpGet("")]
    public IActionResult Get()
    {
      return Ok(new Person[]
      {
        new Person() { Name = "Shawn" }
      });
    }

    //[HttpPost("")]
    //public IActionResult Post(Person p)
    //{
    //  return Created();
    //}
  }

  public class Person
  {
    public string Name { get; internal set; }
  }
}