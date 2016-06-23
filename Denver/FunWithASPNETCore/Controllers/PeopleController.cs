using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FunWithASPNETCore.Controllers
{
  [Route("/api/people")]
  public class PeopleController : Controller
  {
    [HttpGet("")]
    public IActionResult Get()
    {
      if (false) return BadRequest("Bad things happen to api developers");

      return Ok(new Person { Name = "Shawn " });
    }
  }
}
