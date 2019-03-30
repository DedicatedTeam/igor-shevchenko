using System;
using System.Collections.Generic;
using Company_OOP.Employees;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyCompany_OOP.Tests
{
    [TestClass]
    public class MyManagerTests
    {
        [TestMethod]
        public void AddToTeam_Developer_GetResult_True()
        {
            //arrange
            Developer developer = new Developer();
            var expected = true;

            //act
            List<Employee> _team = new List<Employee>();
            Manager manager = new Manager();
            var actual = manager.AddToTeam(developer);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddToTeam_Designer_GetResult_True()
        {
            //arrange
            Designer designer = new Designer();
            var expected = true;

            //act
            List<Employee> _team = new List<Employee>();
            Manager manager = new Manager();
            var actual = manager.AddToTeam(designer);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddToTeam_Manager_GetResult_False()
        {
            //arrange
            Manager testManager = new Manager();
            var expected = false;

            //act
            List<Employee> _team = new List<Employee>();
            Manager manager = new Manager();
            var actual = manager.AddToTeam(testManager);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
