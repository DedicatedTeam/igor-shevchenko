using Company_OOP.Employees;
using System;

namespace Company_OOP.Calculators
{
    public static class Factory_Calculator
    {
        public static ICalculator GetCalculatorRealisation(Employee employee)
        {
            if(employee != null)
            {
                if (employee is Designer)
                {
                    return new SalaryCalculator_Designer();
                }
                if (employee is Developer)
                {
                    return new SalaryCalculator_Developer();
                }
                if (employee is Manager)
                {
                    return new SalaryCalculator_Manager();
                }

                throw new ArgumentOutOfRangeException();
            }

            throw new NullReferenceException();
        }
    }
}
