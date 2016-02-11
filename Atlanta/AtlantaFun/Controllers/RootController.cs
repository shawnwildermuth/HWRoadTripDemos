using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtlantaFun.Data;
using AtlantaFun.Services;
using Microsoft.AspNet.Mvc;

namespace AtlantaFun.Controllers
{
  public class RootController : Controller
  {
    private FunContext _ctx;
    private IMailService _svc;
    public RootController(IMailService svc, FunContext ctx)
    {
      _svc = svc;
      _ctx = ctx;
    }

    [HttpGet("root/index")]
    public IActionResult Index()
    {
      _svc.SendMail("shawn", "bob", "Heya");

      _ctx.Issues.Add(new Issue()
      {
        Name = "First",
        Created = DateTime.UtcNow,
        Owners = new List<Person>()
        {
          new Person() { Name = "Bob"  }
        }
      });

      _ctx.SaveChanges();

      return View();
    }
  }
}
