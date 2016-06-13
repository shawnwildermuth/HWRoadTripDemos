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
    [HttpGet("api/people")]
    public IActionResult Get()
    {
      if (true) return BadRequest("Try again");

      return Ok(new { Name = "Shawn " });
    }
  }
}
