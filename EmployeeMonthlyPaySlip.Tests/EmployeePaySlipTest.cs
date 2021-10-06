using EmployeeMonthlyPaySlip.BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeMonthlyPaySlip.Tests
{
    /// <summary>
    /// Summary description for UnitTests
    /// </summary>
    [TestClass]
    public class EmployeePayslipTest
    {
        BaseEmployee employee = new EmployeePayslip("Test user", 60000);
        
        [TestMethod]
        public void ShouldGenerateMonthlyPayslipValuesForEmployee() 
        {
                employee.GenerateMonthlyPayslipValues();
                Assert.AreEqual("Test user", employee.EmployeeName);
                Assert.AreEqual(60000, employee.AnnualSalary);
                Assert.AreEqual(5000, employee.GrossMonthlyIncome);
                Assert.AreEqual(500, employee.MonthlyIncomeTax);
                Assert.AreEqual(4500, employee.NetMonthlyIncome);
        }

    }
}

