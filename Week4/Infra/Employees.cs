using System;
using System.Collections.Generic;
using System.Linq;
using Core;

namespace Infra
{
    public class Employees
    {
        public static List<Employee> Get(SalesDbContex db)
        {
            return db.Employees.ToList();
        }

        public Employee Save(Employee e, SalesDbContex db)
        {
            db.Employees.Add(e);
            db.SaveChanges();
            return e;
        }
    }
}
