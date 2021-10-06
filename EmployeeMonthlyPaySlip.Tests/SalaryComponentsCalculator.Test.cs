using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeMonthlyPaySlip.BusinessLayer;

namespace EmployeeMonthlyPaySlip.Tests
{
    [TestClass]
    public class SalaryComponentsCalculatorTest
    {
        SalaryComponentsCalculator salaryComponentsCalculator = new SalaryComponentsCalculator();
        

        [TestMethod]
        public void CalculateGrossMonthlyIncomeTest()
        {
            salaryComponentsCalculator.annualSalary = 60000;
            Assert.AreEqual(5000 , salaryComponentsCalculator.CalculateGrossMonthlyIncome());

        }


        [TestMethod]
        public void CalculateMonthlyIncomeTaxTest()
        {
            salaryComponentsCalculator.annualSalary = 60000;
            Assert.AreEqual(500, salaryComponentsCalculator.CalculateMonthlyIncomeTax());

        }


        [TestMethod]
        public void CalculateNetMonthlyIncomeTest()
        {
            salaryComponentsCalculator.grossMonthlyIncome = 5000;
            salaryComponentsCalculator.incomeTaxMonthly = 500;
            Assert.AreEqual(4500, salaryComponentsCalculator.CalculateNetMonthlyIncome());

        }
    }
}
