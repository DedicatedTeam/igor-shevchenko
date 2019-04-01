using System;
using Company_OOP.CompanyBLL.CalculatorServices;
using Company_OOP.CompanyDAL.EmployeeModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyCompany_OOP.Tests
{
    [TestClass]
    public class MySalaryCalculatorDesignerTests
    {
        [TestMethod]
        public void CalculateSalaryForDesignerWith_ExpirienceLess_2Years_AndEffectivnessKoef_08()
        {
            //arrange
            Designer designer = new Designer()
            {
                FirstName = "Jonny",
                SecondName = "Dullitl",
                Experiance = 1,
                SalaryValue = 7000,
                EffectivnessCoefficient = 0.8M,
                Manager = null
            };
            var expected = 5600;

            //act
            SalaryCalculatorDesigner salaryCalculator_Designer = new SalaryCalculatorDesigner();
            var actual = salaryCalculator_Designer.CalculateSalary(designer);

            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void CalculateSalaryForDesignerWith_ExpirienceMoreThan_2Years_AndLessThan5Years_AndEffectivnessKoef_1()
        {
            //arrange
            Designer designer = new Designer()
            {
                FirstName = "Jonny",
                SecondName = "Dullitl",
                Experiance = 3,
                SalaryValue = 7000,
                EffectivnessCoefficient = 1M,
                Manager = null
            };
            var expected = 7200;

            //act
            SalaryCalculatorDesigner salaryCalculator_Designer = new SalaryCalculatorDesigner();
            var actual = salaryCalculator_Designer.CalculateSalary(designer);

            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void CalculateSalaryForDesignerWith_ExpirienceMoreThan_5Years_AndEffectivnessKoef_07()
        {
            //arrange
            Designer designer = new Designer()
            {
                FirstName = "Jonny",
                SecondName = "Dullitl",
                Experiance = 7,
                SalaryValue = 7000,
                EffectivnessCoefficient = 0.7M,
                Manager = null
            };
            var expected = 6230;

            //act
            SalaryCalculatorDesigner salaryCalculator_Designer = new SalaryCalculatorDesigner();
            var actual = salaryCalculator_Designer.CalculateSalary(designer);

            //assert
            Assert.AreEqual(actual, expected);
        }
        
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void CalculateSalaryForDesigner_IfParametrIsNotDesigner()
        {
            //arrange
            Developer developer = new Developer();
            var expected = new NullReferenceException();

            //act
            SalaryCalculatorDesigner salaryCalculator_Designer = new SalaryCalculatorDesigner();
            var actual = salaryCalculator_Designer.CalculateSalary(developer);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CalculateSalary_IfDesigner_EquelNull()
        {
            //arrange
            Designer designer = null;
            var expected = new ArgumentNullException();

            //act
            SalaryCalculatorDesigner salaryCalculator_Designer = new SalaryCalculatorDesigner();
            var actual = salaryCalculator_Designer.CalculateSalary(designer);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
