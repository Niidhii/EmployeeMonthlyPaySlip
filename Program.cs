using System;
using System.Linq;
using System.Reflection;
using EmployeeMonthlyPaySlip.BusinessLayer;
using EmployeeMonthlyPaySlip.PresentationLayer;

namespace EmployeeMonthlyPaySlip
{
    class Program
    {
        
        static readonly string Usage = String.Format(Properties.Settings.Default.UsagePattern, Assembly.GetEntryAssembly().ManifestModule);
      
        static void Main(string[] args)
        {
            //Check for Parameters if any
            if (!args.Any())
            {
                Console.WriteLine(Usage);
                return;
            }

            // Get all command line paramters
            var commandLineParameterValue = CommandLineParameters.GetCommandLineParameterValues(args);
            if (commandLineParameterValue!=null)
            { 
            //Validate CommandLine Parameters
                if (CommandLineParameters.ValidateCommandLineParameters(commandLineParameterValue))
               {
                //Execute the function
                  switch (commandLineParameterValue.Function)
                  {
                    case FunctionType.GenerateMonthlyPayslip:
                    {
                        BaseEmployee employee = new EmployeePayslip(commandLineParameterValue.EmployeeName,
                            commandLineParameterValue.AnnualSalary);
                        employee.GenerateMonthlyPayslipValues();
                       
                        // Print the values on the console
                        IPrintOutput print = new PrintOutput();
                        print.PrintPayslip(employee);
                    }
                        break;
                  }
                }
            }
        }
        
       
       

       
    }
}
