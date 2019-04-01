using Company_OOP.CompanyDAL.EmployeeModels;
using System;

namespace Company_OOP.CompanyBLL.CalculatorServices
{
    public class SalaryCalculatorDesigner : SalaryCalculatorEmployee
    {
        public override decimal CalculateSalary(Employee employee)
        {
            if (employee != null)
            {
                Designer designer = employee as Designer;
                if(designer != null)
                {
                    return base.CalculateSalary(designer) * designer.EffectivnessCoefficient;
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
