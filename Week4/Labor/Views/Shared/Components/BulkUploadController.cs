using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Infra;
using Labor.Filters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Core;
using Labor.Controllers;

namespace Labor.Views.Shared.Components
{
    public class BulkUploadController : Controller
    {
        private readonly SalesDbContex db;

        public BulkUploadController(SalesDbContex dababase)
        {
            db = dababase;
        }

        [AdminFilter]
        public ActionResult Index()
        {
            return View(new FileUploadViewModel());
        }

        [AdminFilter]
        public ActionResult Upload(IFormFile fileUpload)
        {
            List<Core.Employee> employees = GetEmployees(fileUpload);
            Employees e = new Employees();
            e.UploadEmployees(employees, db);
            return RedirectToAction("Index", "Employee");
        }


        private List<Core.Employee> GetEmployees(IFormFile file)
        {
            List<Core.Employee> employees = new List<Core.Employee>();
            StreamReader csvreader = new StreamReader(file.OpenReadStream());
            csvreader.ReadLine();
            while (!csvreader.EndOfStream)
            {
                var line = csvreader.ReadLine();
                var values = line.Split(',');
                Core.Employee e = new Core.Employee();
                e.FirstName = values[0];
                e.LastName = values[1];
                e.Salary = int.Parse(values[2]);
                employees.Add(e);
            }
            return employees;
        }
    }
}
