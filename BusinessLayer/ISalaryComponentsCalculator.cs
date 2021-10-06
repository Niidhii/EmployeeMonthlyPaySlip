using System.Collections.Generic;


namespace EmployeeMonthlyPaySlip.BusinessLayer
{
   public interface ISalaryComponentsCalculator
    {
        Dictionary<string, decimal> GenerateMonthlyPayslipValues(decimal annualSalary);
    }
}
