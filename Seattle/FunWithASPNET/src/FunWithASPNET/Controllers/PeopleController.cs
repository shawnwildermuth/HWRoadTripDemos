using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace FunWithASPNET.Controllers
{
  public class PeopleController : Controller
  {
    [HttpGet("api/people")]
    public IActionResult Get()
    {
      return Json(new { name = "Hello" });
    }
  }
}
