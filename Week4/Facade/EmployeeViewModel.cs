using Core;

namespace Facade
{
    public class EmployeeViewModel
    {
        public string EmployeeName { get; set; }
        public string Salary { get; set; }
        public string SalaryColor { get; private set; } = "red";

        public EmployeeViewModel(Employee emp)
        {
            if(emp is null) return;
            SetName(emp);
            SetSalary(emp);
            SetColor(emp);
        }

        internal void SetName(Employee e)
        {
            EmployeeName = e.FirstName + " " + e.LastName;
        }

        internal void SetColor(Employee e)
        {
            if (!ReferenceEquals(null, e))
                SalaryColor = e.Salary > 15000 ? "yellow" : "green";
            else SalaryColor = "red";
        }

        internal void SetSalary(Employee e)
        {
            Salary = e.Salary.ToString("C");
        }
    }
}
