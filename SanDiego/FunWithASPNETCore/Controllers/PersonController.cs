using System;
using Microsoft.AspNet.Mvc;

namespace FunWithASPNETCore.Controllers
{
  [Route("api/people")]
  public class PersonController : Controller
  {
    [HttpGet("")]
    public JsonResult Get()
    {
      return Json(new[] { new { Name = "Shawn" } });
    }
  }
}
