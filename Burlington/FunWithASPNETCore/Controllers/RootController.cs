using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FunWithASPNETCore.Controllers
{
  public class RootController : Controller
  {
    [HttpGet("/")]
    public IActionResult Index()
    {
      return View();
    }

    [HttpGet("/about")]
    public IActionResult About()
    {
      throw new InvalidOperationException("Bad things happen to good developers");

      return View();
    }
  }
}
