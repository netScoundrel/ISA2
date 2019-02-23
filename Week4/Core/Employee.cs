namespace Core
{
    public class Employee
    {
        public string FirstName { get; set; }
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


