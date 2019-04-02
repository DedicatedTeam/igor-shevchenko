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
            FactoryCalculator factoryCalculator = new FactoryCalculator();

            //act
            var actual = factoryCalculator.GetCalculatorRealisation(designer);

            //assert
            Assert.ReferenceEquals(actual, expected);
        }

        [TestMethod]
        public void GetCalculatorRealisationForDeveloper()
        {
            //arrange
            Developer developer = new Developer();
            ICalculator expected = new SalaryCalculatorDeveloper();
            FactoryCalculator factoryCalculator = new FactoryCalculator();

            //act
            var actual = factoryCalculator.GetCalculatorRealisation(developer);

            //assert
            Assert.ReferenceEquals(actual, expected);
        }

        [TestMethod]
        public void GetCalculatorRealisationForManager()
        {
            //arrange
            Manager manager = new Manager();
            ICalculator expected = new SalaryCalculatorManager();
            FactoryCalculator factoryCalculator = new FactoryCalculator();

            //act
            var actual = factoryCalculator.GetCalculatorRealisation(manager);

            //assert
            Assert.ReferenceEquals(actual, expected);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetCalculatorRealisation_IfEmployeeIsNull()
        {
            //arrange
            Employee employee = null;
            FactoryCalculator factoryCalculator = new FactoryCalculator();
            var expected = new ArgumentNullException();

            //act
            var actual = factoryCalculator.GetCalculatorRealisation(employee);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
