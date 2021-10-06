

namespace EmployeeMonthlyPaySlip.BusinessLayer
{
    public abstract class BaseEmployee
    {
        #region Methods
        public string EmployeeName { get; set; }
        public decimal AnnualSalary { get; set; }
        public decimal GrossMonthlyIncome { get; set; }
        public decimal MonthlyIncomeTax { get; set; }
        public decimal NetMonthlyIncome { get; set; }


        public abstract void GenerateMonthlyPayslipValues();
        
        #endregion
    }
}
