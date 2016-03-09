using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace FunWithASPNETCore.Controllers
{
  [Route("root")]
  public class RootController : Controller
  {
    [HttpGet("index/{page:int?}")]
    public IActionResult Index(int page = 0)
    {
      ViewBag.Title = "Home Page";

      throw new InvalidOperationException();

      return View();
    }

    [HttpGet("contact")]
    public IActionResult Contact()
    {
      return View();
    }
  }
}
