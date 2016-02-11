using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtlantaFun.Data;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;

namespace AtlantaFun.Controllers
{
  [Route("api/issues")]
  public class IssuesController : Controller
  {
    private FunContext _ctx;

    public IssuesController(FunContext ctx)
    {
      _ctx = ctx;
    }

    [HttpGet("")]
    public IActionResult Get()
    {
      return Json(_ctx.Issues.Include(i => i.Owners).ToList());
    }
  }
}
