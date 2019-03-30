using Company_OOP.Employees;
using System;

namespace Company_OOP.Calculators
{
    public class SalaryCalculator_Designer : Calculator_Employee
    {
        public override decimal CalculateSalary(Employee employee)
        {
            if (employee != null)
            {
                Designer designer = employee as Designer;
                if(designer != null)
                {
                    return base.CalculateSalary(designer) * (decimal)designer.EffectivnessCoefficient;
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
