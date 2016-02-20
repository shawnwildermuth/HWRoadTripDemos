using System;
using System.Linq;
using HelloASPNET.Data;
using Microsoft.AspNet.Mvc;

namespace HelloASPNET.Controllers
{
  [Route("/root/")]
  public class RootController : Controller
  {
    private FunContext _ctx;

    public RootController(FunContext ctx)
    {
      _ctx = ctx;
    }

    [HttpGet("index")]
    public IActionResult Index()
    {
      return View(_ctx.People.ToList());
    }

    [HttpGet("contact/{id?}")]
    public IActionResult Contact(string id)
    {
      return View();
    }
  }
}
