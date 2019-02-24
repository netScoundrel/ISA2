﻿using System;
using System.Collections.Generic;
using System.Linq;
using Core;

namespace Infra
{
    public static class Employees
    {
        public static List<Employee> Get(SalesDbContex db)
        {
            return db.Employees.ToList();
        }
    }
}
