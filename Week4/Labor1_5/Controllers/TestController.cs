using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Labor1_5.Models;

namespace Labor1_5.Controllers
{
    public class TestController : Controller
    {
        public ActionResult GetView()
        {
            Employee emp = new Employee();
            emp.FirstName = "Paul";
            emp.LastName = "Opmann";
            emp.Salary = 1510;
            return View("MyView", emp);
        }
    }
}