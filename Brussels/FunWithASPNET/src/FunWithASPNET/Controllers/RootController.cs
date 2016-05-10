using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace FunWithASPNET.Controllers
{
  public class RootController : Controller
  {
    [HttpGet("/foo/bar")]
    public IActionResult Index()
    {
      return View();
    }
  }
}
