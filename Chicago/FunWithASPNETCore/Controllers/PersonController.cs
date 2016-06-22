using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FunWithASPNETCore.Controllers
{
  [Route("api/people")]
  public class PersonController : Controller
  {
    [HttpGet("")]
    public IActionResult Get()
    {
      if (false) return BadRequest("Bad things happen");

      return Ok(new Person { Name = "hello" });
    }
  }
}
