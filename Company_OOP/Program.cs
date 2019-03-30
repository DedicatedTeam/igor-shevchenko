using Company_OOP.Reports;
using System;
using System.Collections.Generic;

namespace Company_OOP.Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create 2 managers
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

            // Create 2 designers
            Designer designer1 = new Designer()
            {
                FirstName = "Fred",
                SecondName = "Durst",
                Experiance = 1,
                SalaryValue = 4000,
                EffectivnessCoefficient = 0.9,
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

            // Create 4 developers
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

  //-----------------------------------------------------------------------------------------------------------//

            //Add employees to managers team
            manager.AddToTeam(designer1);
            manager.AddToTeam(designer2);
            manager.AddToTeam(developer1);
            manager.AddToTeam(developer2);
            manager.AddToTeam(developer3);
            manager.AddToTeam(developer4);

  //--------------------------------------------------------------------------------------------------------------//

            Department department = new Department();

            department.AddManagerToManagers(managerMain);
            department.AddManagerToManagers(manager);

            //foreach (var item in department.GetManagers())
            //{
            //    if (item.Manager == null)
            //    {
            //        Console.WriteLine(item.FirstName + " " + item.SecondName + ", manager - null ");
            //    }
            //    else
            //    {
            //        Console.WriteLine(item.ToString());
            //    }
            //}
            //Console.WriteLine();

  //--------------------------------------------------------------------------------------------------------------//

            // Give salary for managers with team and for each employee in these teams - by one time
            List<ISalaryReport> salaryReports = department.GiveSalary(department.GetManagers());

            foreach(var item in salaryReports)
            {
                Console.WriteLine(item.FirstName + " " + item.SecondName + ": got salary - " + item.FullSalary);
            }
        }
    }
}
