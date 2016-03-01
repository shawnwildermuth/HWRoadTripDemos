using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace FunInPhoenix.Controllers.Api
{
  [Route("api/person")]
  public class PersonService : Controller
  {
    [HttpGet("")]
    public JsonResult Get()
    {
      return Json(new { Name = "Shawn" });
    }
  }
}
