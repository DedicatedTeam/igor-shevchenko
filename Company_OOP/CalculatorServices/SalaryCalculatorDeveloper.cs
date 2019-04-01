using Company_OOP.CompanyDAL.EmployeeModels;
using System;

namespace Company_OOP.CompanyBLL.CalculatorServices
{
    public class SalaryCalculatorDeveloper : SalaryCalculatorEmployee
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
                throw new ArgumentNullException();
            }
        }
    }
}
