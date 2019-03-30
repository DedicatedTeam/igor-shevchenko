using System;
using Company_OOP.Calculators;
using Company_OOP.Employees;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyCompany_OOP.Tests
{
    [TestClass]
    public class MyFactoryCalculatorTests
    {
        [TestMethod]
        public void GetCalculatorRealisationForDesigner()
        {
            //arrange
            Designer designer = new Designer();
            ICalculator expected = new SalaryCalculator_Designer();

            //act
            var actual = Factory_Calculator.GetCalculatorRealisation(designer);

            //assert
            Assert.ReferenceEquals(actual, expected);
        }

        [TestMethod]
        public void GetCalculatorRealisationForDeveloper()
        {
            //arrange
            Developer developer = new Developer();
            ICalculator expected = new SalaryCalculator_Developer();

            //act
            var actual = Factory_Calculator.GetCalculatorRealisation(developer);

            //assert
            Assert.ReferenceEquals(actual, expected);
        }

        [TestMethod]
        public void GetCalculatorRealisationForManager()
        {
            //arrange
            Manager manager = new Manager();
            ICalculator expected = new SalaryCalculator_Manager();

            //act
            var actual = Factory_Calculator.GetCalculatorRealisation(manager);

            //assert
            Assert.ReferenceEquals(actual, expected);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void GetCalculatorRealisation_IfEmployeeIsNull()
        {
            //arrange
            Employee employee = null;
            var expected = new NullReferenceException();

            //act
            var actual = Factory_Calculator.GetCalculatorRealisation(employee);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
