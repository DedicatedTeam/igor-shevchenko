using Company_OOP.Employees;
using System;

namespace Company_OOP.Calculators
{
    public class SalaryCalculator_Developer : Calculator_Employee
    {
        public override decimal CalculateSalary(Employee employee)
        {
            if (employee != null)
            {
                Developer developer = employee as Developer;
                if(developer != null)
                {
                    return base.CalculateSalary(developer);
                }
                else
                {
                    throw new NullReferenceException();
                }
            }
            else
            {
                throw new NullReferenceException();
            }
        }
    }
}
