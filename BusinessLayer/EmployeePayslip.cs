
using System.Collections.Generic;

namespace EmployeeMonthlyPaySlip.BusinessLayer
{
    public class EmployeePayslip : BaseEmployee
    {
        #region Properties
        
        private ISalaryComponentsCalculator _salaryComponentsCalculator;
        #endregion

        #region Methods

        public EmployeePayslip(string employeeName, decimal annualSalaray)
        {
            this.EmployeeName = employeeName;
            this.AnnualSalary = annualSalaray;
            _salaryComponentsCalculator = new SalaryComponentsCalculator();
        }

        public override  void GenerateMonthlyPayslipValues()
        {
            Dictionary<string, decimal> salarycomponents = _salaryComponentsCalculator.GenerateMonthlyPayslipValues(AnnualSalary);
            GrossMonthlyIncome = salarycomponents["grossMonthlyIncome"];
            MonthlyIncomeTax = salarycomponents["monthlyIncomeTax"];
            NetMonthlyIncome = salarycomponents["netMonthlyIncome"];

        }

        #endregion

    }
}
