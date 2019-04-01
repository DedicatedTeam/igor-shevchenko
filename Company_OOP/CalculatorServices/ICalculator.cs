using Company_OOP.CompanyDAL.EmployeeModels;

namespace Company_OOP.CompanyBLL.CalculatorServices
{
    // This intercase able to define any types of calculator
    public interface ICalculator
    {
        decimal CalculateSalary(Employee employee);
    }
}
