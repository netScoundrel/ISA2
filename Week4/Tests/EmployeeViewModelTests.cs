using Facade;
using Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Tests
{
    [TestClass]
    public class EmployeeViewModelTests
    {

        private EmployeeViewModel o;

        [TestInitialize]
        public void TestInitialize()
        {
            o = new EmployeeViewModel(null);
        }

        [TestMethod]
        public void SalaryColorIsRedByDefaultTest()
        {
            Assert.AreEqual("red", o.SalaryColor);
        }

        [TestMethod]
        public void SalaryColorIsRedIfSetColorArgumentIsNullTest()
        {
            o.SetColor(null);
            Assert.AreEqual("red", o.SalaryColor);
        }

        [TestMethod]
        public void SalaryColorIsYellowForHighSalariesTest()
        {
            o.SetColor(new Employee(null, null, 15001));
            Assert.AreEqual("yellow", o.SalaryColor);
        }

        [TestMethod]
        public void SalaryColorIsGreenForSmallSalariesTest()
        {
            o.SetColor(new Employee(null, null, 15000));
            Assert.AreEqual("green", o.SalaryColor);
        }

        [TestMethod]
        public void SalaryIsZeroByDefaultTest()
        {
            Assert.AreEqual(0.ToString("C"), o.Salary);
        }

        [TestMethod]
        public void SalaryTest()
        {
            o.SetSalary(new Employee(null, null, 100));
            Assert.AreEqual(100.ToString("C"), o.Salary);
        }

        [TestMethod]
        public void EmployeeNameTest()
        {
            o.SetName(new Employee("First", "Last", 0));
            Assert.AreEqual("First Last", o.EmployeeName);
        }
    }
}
