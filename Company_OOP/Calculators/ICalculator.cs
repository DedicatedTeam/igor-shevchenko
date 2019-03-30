using Company_OOP.Employees;

namespace Company_OOP.Calculators
{
    // This intercase able to define any types of calculator
    public interface ICalculator
    {
        decimal CalculateSalary(Employee employee);
    }
}
