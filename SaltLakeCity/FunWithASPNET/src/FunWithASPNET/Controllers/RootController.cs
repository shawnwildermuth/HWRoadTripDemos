using System;
using Microsoft.AspNet.Mvc;

namespace FunWithASPNET
{
  public class RootController : Controller
  {
    [HttpGet("root/index")]
    public ActionResult Index()
    {
      //throw new InvalidOperationException("Bad things happen to good developers");

      return View();
    }
  }
}
