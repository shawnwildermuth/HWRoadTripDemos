using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace FunInPhoenix.Controllers.Root
{
  public class RootController : Controller
  {
    [HttpGet("")]
    public IActionResult Index()
    {
      ViewBag.Title = "Hello World";
      return View();
    }
  }
}
