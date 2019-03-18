using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContosoUniversityRazor.Models;

namespace ContosoUniversityRazor.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly ContosoUniversityRazor.Data.SchoolContext _context;

        public IndexModel(ContosoUniversityRazor.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<Course> Course { get;set; }

        public async Task OnGetAsync()
        {
            Course = await _context.Courses
                .Include(c => c.Department)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
