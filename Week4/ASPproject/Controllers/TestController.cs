﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ASPproject.Controllers
{
    public class TestController : Controller
    {
        public ActionResult GetView()
        {
            return View("MyView");
        }
    }
}