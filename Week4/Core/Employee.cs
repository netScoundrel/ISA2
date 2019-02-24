using System.ComponentModel.DataAnnotations;

namespace Core
{
    public class Employee
    {
        private const string requireField = "Required field!";
        private const string lenghtIsToBig = "Lenght should be less than 20 characters!!";

        [Required(ErrorMessage = requireField)]
        [StringLength(20, ErrorMessage = lenghtIsToBig)]
        public string FirstName { get; set; }
        [StringLength(20, ErrorMessage = lenghtIsToBig)]
        public string LastName { get; set; }
        public int Salary { get; set; }
        public int EmployeeId { get; set; }
        

        public Employee()
        {

        }

        public Employee(string firstName, string lastName,
            int salary)
        {
            FirstName = firstName?? string.Empty;
            LastName = lastName?? string.Empty;
            Salary = salary;

        }
    }
}


