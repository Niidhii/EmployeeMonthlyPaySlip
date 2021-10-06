using EmployeeMonthlyPaySlip.BusinessLayer;

namespace EmployeeMonthlyPaySlip.PresentationLayer
{
    public interface IPrintOutput
    {
        void PrintPayslip(BaseEmployee employee);

    }
}
