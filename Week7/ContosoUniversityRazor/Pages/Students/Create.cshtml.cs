using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ContosoUniversityRazor.Models;

namespace ContosoUniversityRazor.Pages.Students
{
    public class CreateModel : PageModel
    {
        private readonly ContosoUniversityRazor.Data.SchoolContext _context;

        public CreateModel(ContosoUniversityRazor.Data.SchoolContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Student Student { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var emptyStudent = new Student();

            if (await TryUpdateModelAsync<Student>(
                emptyStudent,
                "student",   // Prefix for form value.
                s => s.FirstMidName, s => s.LastName, s => s.EnrollmentDate))
            {
                _context.Student.Add(emptyStudent);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }

            return null;
        }
    }
}