using System;
using System.Collections.Generic;


namespace EmployeeMonthlyPaySlip.BusinessLayer
{
    public class SalaryComponentsCalculator : ISalaryComponentsCalculator
    {
        #region Properties
        public decimal annualSalary,grossMonthlyIncome,incomeTaxMonthly;

        #endregion
        #region Methods

        public decimal CalculateGrossMonthlyIncome()
        {
            grossMonthlyIncome = Math.Round(annualSalary / 12);
            return grossMonthlyIncome;
        }

        public decimal CalculateMonthlyIncomeTax()
        {
            incomeTaxMonthly = Math.Round(CalculateTaxBasedOnSlabs() / 12);

            return incomeTaxMonthly;
        }

        public decimal CalculateNetMonthlyIncome()
        {
            return Math.Round(grossMonthlyIncome-incomeTaxMonthly);
        }

        public decimal CalculateTaxBasedOnSlabs()
        {
            try
            {
                var taxBands = new[]
                {
                    new {Lower = 0m, Upper = 20000m, Rate = 0.0m},
                    new {Lower = 20001m, Upper = 40000m, Rate = 0.1m},
                    new {Lower = 40001m, Upper = 80000m, Rate = 0.2m},
                    new {Lower = 80001m, Upper = 180000m, Rate = 0.3m},
                    new {Lower = 180001m, Upper = decimal.MaxValue, Rate = 0.4m}
                };

                var taxToBePaid = 0m;

                foreach (var band in taxBands)
                {
                    if (annualSalary > band.Lower)
                    {
                        var taxableAtThisRate = Math.Min(band.Upper - band.Lower, annualSalary - band.Lower);
                        var taxThisBand = taxableAtThisRate * band.Rate;
                        taxToBePaid += taxThisBand;
                    }
                }

                return taxToBePaid;


            }
            catch (Exception)
            {
                Console.WriteLine("Encountered error while calculating tax slab.");
                return 0;
                
            }
           
        }

        public Dictionary<string, decimal> GenerateMonthlyPayslipValues(decimal annualSalary)
        {
               this.annualSalary = annualSalary;
                Dictionary<string, decimal> employeeMonthlyPalyslip = new Dictionary<string, decimal>();
                employeeMonthlyPalyslip.Add("grossMonthlyIncome", CalculateGrossMonthlyIncome()); 
                employeeMonthlyPalyslip.Add("monthlyIncomeTax", CalculateMonthlyIncomeTax());
                employeeMonthlyPalyslip.Add("netMonthlyIncome", CalculateNetMonthlyIncome());
            return employeeMonthlyPalyslip;
            }
        #endregion
    }
}
