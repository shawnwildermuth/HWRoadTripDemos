using System;
using Microsoft.AspNet.Mvc;

namespace FunWithASPNET.Controllers
{

  public class RootController : Controller
  {
    [HttpGet("root/index")]
    public IActionResult Index()
    {
      ViewBag.Title = "Hello from Seattle";

      throw new InvalidOperationException("bad things happen to good developers");

      return View();
    }
  }
}
