﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContosoUniversityRazor.Models;

namespace ContosoUniversityRazor.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly ContosoUniversityRazor.Models.SchoolContext _context;

        public IndexModel(ContosoUniversityRazor.Models.SchoolContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Student.ToListAsync();
        }
    }
}
