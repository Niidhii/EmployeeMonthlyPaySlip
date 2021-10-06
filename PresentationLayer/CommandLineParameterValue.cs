
namespace EmployeeMonthlyPaySlip.PresentationLayer
{
    public class CommandLineParameterValue
    {
       
        public CommandLineParameterValue()
        {
            Function = FunctionType.None;
        }
       
        public  string EmployeeName { get; set; }
        public decimal AnnualSalary { get; set; }
       
        public FunctionType Function { get; set; }

       
    }
}
