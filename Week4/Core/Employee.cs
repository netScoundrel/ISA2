using System.ComponentModel.DataAnnotations;

namespace Core
{
    public class Employee
    {
        [NameValidation]
        public string FirstName { get; set; }
        [NameValidation]
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


