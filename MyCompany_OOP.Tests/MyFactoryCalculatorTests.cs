using System;
using Company_OOP.CompanyBLL.CalculatorServices;
using Company_OOP.CompanyDAL.EmployeeModels;
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
            ICalculator expected = new SalaryCalculatorDesigner();

            //act
            var actual = FactoryCalculator.GetCalculatorRealisation(designer);

            //assert
            Assert.ReferenceEquals(actual, expected);
        }

        [TestMethod]
        public void GetCalculatorRealisationForDeveloper()
        {
            //arrange
            Developer developer = new Developer();
            ICalculator expected = new SalaryCalculatorDeveloper();

            //act
            var actual = FactoryCalculator.GetCalculatorRealisation(developer);

            //assert
            Assert.ReferenceEquals(actual, expected);
        }

        [TestMethod]
        public void GetCalculatorRealisationForManager()
        {
            //arrange
            Manager manager = new Manager();
            ICalculator expected = new SalaryCalculatorManager();

            //act
            var actual = FactoryCalculator.GetCalculatorRealisation(manager);

            //assert
            Assert.ReferenceEquals(actual, expected);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetCalculatorRealisation_IfEmployeeIsNull()
        {
            //arrange
            Employee employee = null;
            var expected = new ArgumentNullException();

            //act
            var actual = FactoryCalculator.GetCalculatorRealisation(employee);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
