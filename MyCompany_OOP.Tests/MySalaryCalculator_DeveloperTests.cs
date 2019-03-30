using System;
using Company_OOP.Calculators;
using Company_OOP.Employees;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyCompany_OOP.Tests
{
    [TestClass]
    public class MySalaryCalculator_DeveloperTests
    {
        [TestMethod]
        public void CalculateSalaryForDeveloperWith_ExpirienceLess_2Years()
        {
            //arrange
            Developer developer = new Developer()
            {
                FirstName = "Jonny",
                SecondName = "Dullitl",
                Experiance = 1,
                SalaryValue = 7000,
                Manager = null
            };
            var expected = 7000;

            //act
            SalaryCalculator_Developer salaryCalculator_Developer = new SalaryCalculator_Developer();
            var actual = salaryCalculator_Developer.CalculateSalary(developer);

            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void CalculateSalaryForDeveloperWith_ExpirienceMore_2YearsAnd_Less5()
        {
            //arrange
            Developer developer = new Developer()
            {
                FirstName = "Jonny",
                SecondName = "Dullitl",
                Experiance = 3,
                SalaryValue = 7000,
                Manager = null
            };
            var expected = 7200;

            //act
            SalaryCalculator_Developer salaryCalculator_Developer = new SalaryCalculator_Developer();
            var actual = salaryCalculator_Developer.CalculateSalary(developer);

            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void CalculateSalaryForDeveloperWith_ExpirienceMore_5Years()
        {
            //arrange
            Developer developer = new Developer()
            {
                FirstName = "Jonny",
                SecondName = "Dullitl",
                Experiance = 7,
                SalaryValue = 7000,
                Manager = null
            };
            var expected = 8900;

            //act
            SalaryCalculator_Developer salaryCalculator_Developer = new SalaryCalculator_Developer();
            var actual = salaryCalculator_Developer.CalculateSalary(developer);

            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void CalculateSalaryForDeveloper_IfParameterIsNotDeveloper()
        {
            //arrange
            Designer designer = new Designer();
            var expected = new NullReferenceException();

            //act
            SalaryCalculator_Developer salaryCalculator_Developer = new SalaryCalculator_Developer();
            var actual = salaryCalculator_Developer.CalculateSalary(designer);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void CalculateSalary_IfDeveloper_EquelNull()
        {
            //arrange
            Developer developer = null;
            var expected = new NullReferenceException();

            //act
            SalaryCalculator_Developer salaryCalculator_Developer = new SalaryCalculator_Developer();
            var actual = salaryCalculator_Developer.CalculateSalary(developer);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
