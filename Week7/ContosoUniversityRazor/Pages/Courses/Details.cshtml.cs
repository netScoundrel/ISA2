using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContosoUniversityRazor.Models;

namespace ContosoUniversityRazor.Pages.Courses
{
    public class DetailsModel : PageModel
    {
        private readonly Data.SchoolContext _context;

        public DetailsModel(Data.SchoolContext context)
        {
            _context = context;
        }

        public Course Course { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Course = await _context.Courses
                .Include(c => c.Department).SingleOrDefaultAsync(m => m.CourseID == id);

            if (Course == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
