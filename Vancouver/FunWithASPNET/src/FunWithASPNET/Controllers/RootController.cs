using System;
using Microsoft.AspNet.Mvc;

namespace FunWithASPNET.Controllers
{
  public class RootController : Controller
  {
    [HttpGet("root/index")]
    public ActionResult Index()
    {
      //throw new InvalidOperationException("Bad things happen to good developers");

      ViewBag.Title = "Did the Canucks win last night?";
      return View();
    }
  }
}
