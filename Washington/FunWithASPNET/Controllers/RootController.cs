using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FunWithASPNET.Controllers
{

  public class RootController : Controller
  {
    [HttpGet("/")]
    public IActionResult Index()
    {

      //throw new InvalidOperationException("Bad things happen to good developers");

      ViewBag.SiteName = "Hello World";

      return View();
    }
  }
}
