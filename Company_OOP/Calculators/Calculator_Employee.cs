using Company_OOP.Employees;
using System;

namespace Company_OOP.Calculators
{
    public abstract class Calculator_Employee : ICalculator
    {
        public virtual decimal CalculateSalary(Employee employee)
        {
            if(employee != null)
            {
                decimal salary = employee.SalaryValue;

                if (employee.Experiance >= 5)
                {
                    salary = employee.SalaryValue * 1.2M + 500;
                }

                if (employee.Experiance >= 2 && employee.Experiance < 5)
                {
                    salary = employee.SalaryValue + 200;
                }

                return salary;
            }
            else
            {
                throw new NullReferenceException();
            }
        }
    }
}
