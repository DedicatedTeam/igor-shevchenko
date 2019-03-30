using System;
using System.Collections.Generic;
using Company_OOP.Calculators;
using Company_OOP.Employees;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyCompany_OOP.Tests
{
    [TestClass]
    public class MySalaryCalculator_ManagerTests
    {
        [TestMethod]
        public void ReturnTrueIfDevelopersMore()
        {
            //arrange
            List<Employee> employees = new List<Employee>();

            Designer designer = new Designer()
            {
                FirstName = "Mark",
                SecondName = "Dark",
                Experiance = 3,
                SalaryValue = 4000,
                EffectivnessCoefficient = 1,
                Manager = null
            };
            Developer developer1 = new Developer()
            {
                FirstName = "Max",
                SecondName = "Newsted",
                Experiance = 1,
                SalaryValue = 35000,
                Manager = null
            };
            Developer developer2 = new Developer()
            {
                FirstName = "Roland",
                SecondName = "Scott",
                Experiance = 4,
                SalaryValue = 35000,
                Manager = null
            };
            employees.Add(designer);
            employees.Add(developer1);
            employees.Add(developer2);
            var expected = true;

            //act
            SalaryCalculator_Manager salaryCalculator_Manager = new SalaryCalculator_Manager();
            var actual = salaryCalculator_Manager.FindOutDevelopersMoreThanDesigners(employees);

            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void ReturnFalseIfDevelopersLess()
        {
            //arrange
            List<Employee> employees = new List<Employee>();

            Designer designer = new Designer()
            {
                FirstName = "Mark",
                SecondName = "Dark",
                Experiance = 3,
                SalaryValue = 4000,
                EffectivnessCoefficient = 1,
                Manager = null
            };
            Designer designer2 = new Designer()
            {
                FirstName = "Max",
                SecondName = "Newsted",
                Experiance = 1,
                SalaryValue = 35000,
                Manager = null
            };
            Developer developer = new Developer()
            {
                FirstName = "Roland",
                SecondName = "Scott",
                Experiance = 4,
                SalaryValue = 35000,
                Manager = null
            };
            employees.Add(designer);
            employees.Add(designer2);
            employees.Add(developer);
            var expected = false;

            //act
            SalaryCalculator_Manager salaryCalculator_Manager = new SalaryCalculator_Manager();
            var actual = salaryCalculator_Manager.FindOutDevelopersMoreThanDesigners(employees);

            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void ReturnFalseIfDevelopersNull()
        {
            //arrange
            List<Employee> employees = null;
            var expected = false;

            //act
            SalaryCalculator_Manager salaryCalculator_Manager = new SalaryCalculator_Manager();
            var actual = salaryCalculator_Manager.FindOutDevelopersMoreThanDesigners(employees);

            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void CalculateSalaryForManagerWith_ExpirienceLess_2Years_AndHisTeamHasLessThan5Members()
        {
            //arrange
            Manager manager = new Manager()
            {
                FirstName = "Jonny",
                SecondName = "Dullitl",
                Experiance = 1,
                SalaryValue = 7000,
                Manager = null
            };
            var expected = 7000;

            //act
            SalaryCalculator_Manager salaryCalculator_Manager = new SalaryCalculator_Manager();
            var actual = salaryCalculator_Manager.CalculateSalary(manager);

            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void CalculateSalaryForManager_ExpirienceMoreThan_2Years_AndLessThan5Years_AndHisTeamHasMembersBetween5and10_AndDevelopersMoreThanDesigners()
        {
            //arrange
            Manager manager = new Manager()
            {
                FirstName = "Jonny",
                SecondName = "Dullitl",
                Experiance = 3,
                SalaryValue = 7000,
                Manager = null
            };

            Designer designer1 = new Designer(); 
            Designer designer2 = new Designer();
            Developer developer1 = new Developer();
            Developer developer2 = new Developer();
            Developer developer3 = new Developer();
            Developer developer4 = new Developer();

            manager.AddToTeam(designer1);
            manager.AddToTeam(designer2);
            manager.AddToTeam(developer1);
            manager.AddToTeam(developer2);
            manager.AddToTeam(developer3);
            manager.AddToTeam(developer4);

            var expected = 8140;

            //act
            SalaryCalculator_Manager salaryCalculator_Manager = new SalaryCalculator_Manager();
            var actual = salaryCalculator_Manager.CalculateSalary(manager);

            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void CalculateSalaryForManager_ExpirienceMoreThan_2Years_AndLessThan5Years_AndHisTeamHasMembersBetween5and10_AndDevelopersLessThanDesigners()
        {
            //arrange
            Manager manager = new Manager()
            {
                FirstName = "Jonny",
                SecondName = "Dullitl",
                Experiance = 3,
                SalaryValue = 7000,
                Manager = null
            };

            Designer designer1 = new Designer();
            Designer designer2 = new Designer();
            Designer designer3 = new Designer();
            Designer designer4 = new Designer();
            Developer developer1 = new Developer();
            Developer developer2 = new Developer();

            manager.AddToTeam(designer1);
            manager.AddToTeam(designer2);
            manager.AddToTeam(designer3);
            manager.AddToTeam(designer4);
            manager.AddToTeam(developer1);
            manager.AddToTeam(developer2);

            var expected = 7400;

            //act
            SalaryCalculator_Manager salaryCalculator_Manager = new SalaryCalculator_Manager();
            var actual = salaryCalculator_Manager.CalculateSalary(manager);

            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void CalculateSalaryForManager_ExpirienceMoreThan_5Years_AndHisTeamHasMore10Members_AndDevelopersMoreThanDesigners()
        {
            //arrange
            Manager manager = new Manager()
            {
                FirstName = "Jonny",
                SecondName = "Dullitl",
                Experiance = 7,
                SalaryValue = 7000,
                Manager = null
            };

            Designer designer1 = new Designer();
            Designer designer2 = new Designer();
            Designer designer3 = new Designer();
            Designer designer4 = new Designer();
            Developer developer1 = new Developer();
            Developer developer2 = new Developer();
            Developer developer3 = new Developer();
            Developer developer4 = new Developer();
            Developer developer5 = new Developer();
            Developer developer6 = new Developer();
            Developer developer7 = new Developer();

            manager.AddToTeam(designer1);
            manager.AddToTeam(designer2);
            manager.AddToTeam(designer3);
            manager.AddToTeam(designer4);
            manager.AddToTeam(developer1);
            manager.AddToTeam(developer2);
            manager.AddToTeam(developer3);
            manager.AddToTeam(developer4);
            manager.AddToTeam(developer5);
            manager.AddToTeam(developer6);
            manager.AddToTeam(developer7);

            var expected = 10120;

            //act
            SalaryCalculator_Manager salaryCalculator_Manager = new SalaryCalculator_Manager();
            var actual = salaryCalculator_Manager.CalculateSalary(manager);

            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void CalculateSalaryForManager_IfParametrIsNotManager()
        {
            //arrange
            Designer designer = new Designer();
            var expected = new NullReferenceException();

            //act
            SalaryCalculator_Manager salaryCalculator_Manager = new SalaryCalculator_Manager();
            var actual = salaryCalculator_Manager.CalculateSalary(designer);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void CalculateSalary_IfManager_EquelNull()
        {
            //arrange
            Manager manager = null;
            var expected = new NullReferenceException();

            //act
            SalaryCalculator_Manager salaryCalculator_Manager = new SalaryCalculator_Manager();
            var actual = salaryCalculator_Manager.CalculateSalary(manager);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
