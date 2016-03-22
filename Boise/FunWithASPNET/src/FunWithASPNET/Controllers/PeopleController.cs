using System;
using Microsoft.AspNet.Mvc;

namespace FunWithASPNET.Controllers
{
  [Route("api/people")]
  public class PeopleController : Controller
  {
    [HttpGet("")]
    public IActionResult Get()
    {
      try
      {
        return Ok(new { name = "Shawn " });
      }
      catch
      {
        return HttpBadRequest("Should never happen");
      }
    }
  }
}
