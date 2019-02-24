using System.Collections.Generic;
using Core;
using Facade;
using Infra;
using Microsoft.AspNetCore.Mvc;

namespace Labor.Controllers
{
    public class TestController : Controller
    {
        private readonly SalesDbContex db;
        public TestController(SalesDbContex db){this.db = db;}
        public ActionResult GetView()
        {

            var model = new EmployeeListViewModel();
            var employees = Employees.Get(db);
            var list = new List<EmployeeViewModel>();
            foreach (var e in employees)
            {
                var employee = new EmployeeViewModel(e);
                list.Add(employee);

            }

            model.Employees = list;
            model.UserName = "Admin";
            return View("MyView", model);
        }
    }
}