using Company_OOP.CompanyDAL.EmployeeModels;
using System;
using System.Collections.Generic;

namespace Company_OOP.CompanyBLL.CalculatorServices
{
    public static class FactoryCalculator
    {
        private static IDictionary<Type, ICalculator> calculators = new Dictionary<Type, ICalculator>();
        private static ICalculator _salaryCalculatorDesigner = new SalaryCalculatorDesigner();
        private static ICalculator _salaryCalculatorDeveloper = new SalaryCalculatorDeveloper();
        private static ICalculator _salaryCalculatorManager = new SalaryCalculatorManager();

        static FactoryCalculator()
        {
            calculators.Add(typeof(Developer), _salaryCalculatorDeveloper);
            calculators.Add(typeof(Designer), _salaryCalculatorDesigner);
            calculators.Add(typeof(Manager), _salaryCalculatorManager);
        }

        public static ICalculator GetCalculatorRealisation(Employee employee)
        {
            if (employee != null)
            {
                if (calculators.ContainsKey(employee.GetType()))
                {
                    return calculators[employee.GetType()];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            else
            {
                throw new ArgumentNullException();
            }
        }
    }
}
