﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace FunInAustin.Controllers.Root
{
  public class RootController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
