using Core;

namespace Facade
{
    public class EmployeeViewModel
    {
        public string EmployeeName { get; set; }
        public string Salary { get; set; }
        public string SalaryColor { get; private set; } = "red";
        public string UserName { get; set; }


        public EmployeeViewModel(Employee emp, string userName)
        {
            SetName(emp);
            SetSalary(emp);
            SetColor(emp);
            SetUserName(userName);
        }

        internal void SetName(Employee e)
        {
            EmployeeName = e.FirstName + " " + e.LastName;
        }

        internal void SetColor(Employee e)
        {
            switch (e)
            {
                case null:
                    SalaryColor = e.Salary > 15000 ? "yellow" : "green";
                    break;
                default:
                    SalaryColor = "red";
                    break;
            }
        }

        internal void SetSalary(Employee e)
        {
            Salary = e.Salary.ToString("C");
        }

        internal void SetUserName(string userName)
        {
            UserName = userName ?? string.Empty;
        }
    }
}
