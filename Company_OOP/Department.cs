﻿using Company_OOP.CompanyBLL.CalculatorServices;
using Company_OOP.CompanyDAL.EmployeeModels;
using Company_OOP.CompanyDAL.ReportModels.SalaryReport;
using System;
using System.Collections.Generic;

namespace Company_OOP.CompanyBLL
{
    public class Department
    {
        private List<Manager> _managers = new List<Manager>();
        private List<ISalaryReport> _salaryReports = new List<ISalaryReport>();
        private FactoryCalculator _factoryCalculator = new FactoryCalculator();
        private ICalculator _calculator;

        // Add manager to list of managers (with teams)
        public bool AddManagerToManagers(Manager manager)
        {
            if (manager != null)
            {
                _managers.Add(manager);
                return true;
            }
            return false;
        }

        // Return list of managers (and all employees from their teams)
        public List<Manager> GetManagers()
        {
            return _managers;
        }

        // This method can give salary for all employees from team by one time
        public List<ISalaryReport> GiveSalary(List<Manager> managers)
        {
            foreach(var item in managers)
            {
                try
                {
                    _calculator = _factoryCalculator.GetCalculatorRealisation(item);
                    _salaryReports.Add(new SalaryReport(item.FirstName, item.SecondName, _calculator.CalculateSalary(item)));

                    foreach (var empl in item.GetTeam())
                    {
                        _calculator = _factoryCalculator.GetCalculatorRealisation(empl);
                        _salaryReports.Add(new SalaryReport(item.FirstName, item.SecondName, _calculator.CalculateSalary(empl)));
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    // Write this error in log file
                }
                catch (NullReferenceException)
                {
                    // Write this error in log file
                }
                catch (ArgumentNullException)
                {
                    // Write this error in log file
                }
                catch (Exception)
                {
                    // Write this error in log file
                }
            }

            return _salaryReports;
        }
    }
}
