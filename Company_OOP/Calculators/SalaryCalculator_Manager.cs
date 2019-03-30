using System;
using System.Collections.Generic;
using Company_OOP.Employees;

namespace Company_OOP.Calculators
{
    public class SalaryCalculator_Manager : Calculator_Employee
    {
        public override decimal CalculateSalary(Employee employee)
        {
            if (employee != null)
            {
                Manager manager = employee as Manager;
                if(manager != null)
                {
                    decimal salary = base.CalculateSalary(manager);

                    if (manager.GetTeam().Count > 5 && manager.GetTeam().Count <= 10)
                    {
                        salary += 200;
                    }

                    if (manager.GetTeam().Count > 10)
                    {
                        salary += 300;
                    }

                    if (FindOutDevelopersMoreThanDesigners(manager.GetTeam()))
                    {
                        salary *= 1.1M;
                    }

                    return salary;
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

        // Count amount of each types of Employee. If developers more - return true, else false
        public bool FindOutDevelopersMoreThanDesigners(List<Employee> employees)
        {
            if (employees != null)
            {
                int amountDeveloper = 0;
                int amountDesigner = 0;

                foreach (var item in employees)
                {
                    if (item is Developer)
                    {
                        amountDeveloper++;
                    }

                    if (item is Designer)
                    {
                        amountDesigner++;
                    }
                }

                if (amountDeveloper > amountDesigner)
                {
                    return true;
                }

                return false;
            }
            return false;
        }
    }
}
