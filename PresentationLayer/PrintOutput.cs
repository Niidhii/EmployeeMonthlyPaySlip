using EmployeeMonthlyPaySlip.BusinessLayer;
using System;


namespace EmployeeMonthlyPaySlip.PresentationLayer
{
    class PrintOutput : IPrintOutput
    {
       
        public void PrintPayslip(BaseEmployee _e)
        {
            Console.WriteLine("Monthly Payslip for: " + _e.EmployeeName);
            Console.WriteLine("Gross Monthly Income: $" + _e.GrossMonthlyIncome);
            Console.WriteLine("Monthly Income Tax: $" + _e.MonthlyIncomeTax);
            Console.WriteLine("Net Monthly Income: $" +_e.NetMonthlyIncome);
            Console.WriteLine("Press any key to exit..");
            Console.ReadKey();
        }
    }
}
