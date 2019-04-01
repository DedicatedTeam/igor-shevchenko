using System.Collections.Generic;
using Company_OOP.CompanyBLL;
using Company_OOP.CompanyDAL.EmployeeModels;
using Company_OOP.CompanyDAL.ReportModels.SalaryReport;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyCompany_OOP.Tests
{
    [TestClass]
    public class MyDepartmentTests
    {
        [TestMethod]
        public void AddManagerToListManagers_GetResult_True()
        {
            //arrange
            Manager manager = new Manager();
            List<Manager> _managers = new List<Manager>();
            var expected = true;

            //act
            Department department = new Department();
            var actual = department.AddManagerToManagers(manager);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddManagerEqualNullToListManagers_GetResult_False()
        {
            //arrange
            Manager manager = null;
            List<Manager> _managers = new List<Manager>();
            var expected = false;

            //act
            Department department = new Department();
            var actual = department.AddManagerToManagers(manager);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GiveFullSalaryForAllEmployees()
        {
            //arrange
            Manager managerMain = new Manager()
            {
                FirstName = "Jonny",
                SecondName = "Dullitl",
                Experiance = 9,
                SalaryValue = 7000,
                Manager = null
            };
            Manager manager = new Manager()
            {
                FirstName = "Lars",
                SecondName = "Ulrikh",
                Experiance = 4,
                SalaryValue = 6500,
                Manager = managerMain
            };
            Designer designer1 = new Designer()
            {
                FirstName = "Fred",
                SecondName = "Durst",
                Experiance = 1,
                SalaryValue = 4000,
                EffectivnessCoefficient = 0.9M,
                Manager = manager
            };
            Designer designer2 = new Designer()
            {
                FirstName = "Mark",
                SecondName = "Dark",
                Experiance = 3,
                SalaryValue = 4000,
                EffectivnessCoefficient = 1,
                Manager = manager
            };
            Developer developer1 = new Developer()
            {
                FirstName = "Max",
                SecondName = "Newsted",
                Experiance = 1,
                SalaryValue = 35000,
                Manager = manager
            };
            Developer developer2 = new Developer()
            {
                FirstName = "Roland",
                SecondName = "Scott",
                Experiance = 4,
                SalaryValue = 35000,
                Manager = manager
            };
            Developer developer3 = new Developer()
            {
                FirstName = "Linda",
                SecondName = "Sharan",
                Experiance = 3,
                SalaryValue = 35000,
                Manager = manager
            };
            Developer developer4 = new Developer()
            {
                FirstName = "Maria",
                SecondName = "Ramos",
                Experiance = 6,
                SalaryValue = 35000,
                Manager = manager
            };

            manager.AddToTeam(designer1);
            manager.AddToTeam(designer2);
            manager.AddToTeam(developer1);
            manager.AddToTeam(developer2);
            manager.AddToTeam(developer3);
            manager.AddToTeam(developer4);

            Department department = new Department();
            department.AddManagerToManagers(managerMain);
            department.AddManagerToManagers(manager);
            List<Manager> managers = department.GetManagers();

            List<ISalaryReport> salaryReports = new List<ISalaryReport>();
            salaryReports.Add(new SalaryReport(managerMain.FirstName, managerMain.SecondName, 8900.0M));
            salaryReports.Add(new SalaryReport(manager.FirstName, manager.SecondName, 7590.0M));
            salaryReports.Add(new SalaryReport(designer1.FirstName, designer1.SecondName, 3600.0M));
            salaryReports.Add(new SalaryReport(designer2.FirstName, designer2.SecondName, 4200.0M));
            salaryReports.Add(new SalaryReport(developer1.FirstName, developer1.SecondName, 35000.0M));
            salaryReports.Add(new SalaryReport(developer2.FirstName, developer2.SecondName, 35200.0M));
            salaryReports.Add(new SalaryReport(developer3.FirstName, developer3.SecondName, 35200.0M));
            salaryReports.Add(new SalaryReport(developer4.FirstName, developer4.SecondName, 42500.0M));

            List<ISalaryReport> expected = salaryReports;

            //act
            List<ISalaryReport> actual = department.GiveSalary(managers);

            //assert
            Assert.ReferenceEquals(expected, actual);
        }
    }
}
