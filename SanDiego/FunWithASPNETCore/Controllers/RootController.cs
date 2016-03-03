using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace FunWithASPNETCore.Controllers
{
  //[Route("Root")]
  public class RootController : Controller
  {
    //[HttpGet("")]
    public IActionResult Index()
    {
      ViewBag.Title = "Our First Page";
      return View();
    }
  }
}
