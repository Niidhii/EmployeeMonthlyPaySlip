using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EmployeeMonthlyPaySlip.PresentationLayer
{
    public class CommandLineParameters
    {
        static readonly string Usage = String.Format(Properties.Settings.Default.UsagePattern, Assembly.GetEntryAssembly().ManifestModule);
        internal static CommandLineParameterValue GetCommandLineParameterValues(string[] args)
        {
            var value = new CommandLineParameterValue();
            try
            {
                if (args.Length == 3)
                {
                    value.EmployeeName = args[1];
                    value.AnnualSalary = decimal.Parse(args[2]);
                    value.Function = (FunctionType) Enum.Parse(typeof(FunctionType), args[0]);
                    return value;
                }
                else
                {
                    Console.WriteLine("Caution: Invalid Parameters "
                                      + "\r\n" + "Please enter valid parameters only. " +
                                      "For Usage please see below : " + "\r\n" + Usage);
                    return null;

                }
               
            }
            catch (Exception)
            {

                Console.WriteLine("Caution: Invalid Parameters " 
                                  + "\r\n" + "Please enter valid parameters only." +
                                    " For Usage please see below : " + "\r\n" + Usage);
                return null;
            }
        }


        public static bool ValidateCommandLineParameters(CommandLineParameterValue commandLineValue)
        {
            try
            {
                if (commandLineValue.Function != FunctionType.GenerateMonthlyPayslip)
                {
                    Console.WriteLine("Please provide function name " +
                                      "'GenerateMonthlyPayslip' to see monthly payslip.");
                    return false;
                }

                if (string.IsNullOrEmpty(commandLineValue.EmployeeName))
                {
                    Console.WriteLine("Please Enter Employee Name.");
                    return false;
                }

                if (commandLineValue.AnnualSalary <= 0)
                {
                    Console.WriteLine("Please enter correct salary.");
                    return false;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Caution: Invalid Parameters " +
                                  "\r\n" + "Please enter valid parameters only." +
                                  " For Usage please see below : " + "\r\n" + Usage);
                return false;
            }

            return true;
        }
    }
}
