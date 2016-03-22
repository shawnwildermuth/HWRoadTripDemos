using System;
using Microsoft.AspNet.Mvc;

namespace FunWithASPNET.Controllers
{
  public class RootController : Controller
  {
    [HttpGet("")]
    public ActionResult Index()
    {
      //throw new InvalidProgramException("Bad things happen to good developers");

      return View();
    }
  }
}
