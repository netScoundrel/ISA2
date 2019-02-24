﻿using System.Collections.Generic;
using Core;
using Facade;
using Infra;
using Microsoft.AspNetCore.Mvc;

namespace Labor.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly SalesDbContex db;
        public EmployeeController(SalesDbContex db){this.db = db;}

        public ActionResult Index()
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
            return View("Index", model);
        }

        public ActionResult AddNew()
        {
            return View("CreateEmployee");
        }

        public ActionResult SaveEmployee(Employee e, string BtnSubmit)
        {
            switch (BtnSubmit)
            {
                case "Save Employee":
                    Employees emp = new Employees();
                    emp.Save(e, db);
                    return RedirectToAction("Index");
                case "Cancel":
                    return RedirectToAction("Index");
            }
            return new EmptyResult();
        }


    }
}