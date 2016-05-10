using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace FunWithASPNETCore.Controllers
{
  public class RootController : Controller
  {
    [HttpGet("/foo/bar")]
    public IActionResult Index()
    {
      //throw new InvalidOperationException("Bad things happen to good developers");

      ViewBag.HelloWorld = "From the Server";
      return View();
    }
  }
}
