using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace FunWithASPNET.Controllers
{
  [Route("api/people")]
  public class PeopleController : Controller
  {
    [HttpGet("")]
    public IActionResult Get()
    {
      return Ok(new
      {
        success = true,
        count = 0,
        results = new string[0]
      });
    }

  }
}
