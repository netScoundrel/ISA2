using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContosoUniversityRazor.Models.SchoolViewModels;
using ContosoUniversityRazor.Models;

namespace ContosoUniversityRazor.Pages.Instructors
{
    public class IndexModel : PageModel
    {
        private readonly ContosoUniversityRazor.Data.SchoolContext _context;

        public IndexModel(ContosoUniversityRazor.Data.SchoolContext context)
        {
            _context = context;
        }

        public InstructorIndexData Instructor { get; set; }
        public int InstructorID { get; set; }
        public int CourseID { get; set; }


        public async Task OnGetAsync(int? id, int? courseID)
        {
            Instructor = new InstructorIndexData();
            Instructor.Instructors = await _context.Instructors
                  .Include(i => i.OfficeAssignment)
                  .Include(i => i.CourseAssignments)
                    .ThenInclude(i => i.Course)
                        .ThenInclude(i => i.Department)
                    .Include(i => i.CourseAssignments)
                        .ThenInclude(i => i.Course)
                            .ThenInclude(i => i.Enrollments)
                                .ThenInclude(i => i.Student)
                  .AsNoTracking()
                  .OrderBy(i => i.LastName)
                  .ToListAsync();

            if (id != null)
            {
                InstructorID = id.Value;
                Instructor instructor = Instructor.Instructors.Where(
                    i => i.ID == id.Value).Single();
                Instructor.Courses = instructor.CourseAssignments.Select(s => s.Course);
            }

            if (courseID != null)
            {
                CourseID = courseID.Value;
                Instructor.Enrollments = Instructor.Courses.Where(
                    x => x.CourseID == courseID).Single().Enrollments;
            }
        }
    }
}
