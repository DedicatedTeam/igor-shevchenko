using System;
using System.Collections.Generic;

namespace Company_OOP.Employees
{
    public class Manager : Employee
    {
        private List<Employee> _team = new List<Employee>();

        // Each manager can has team of developers and designers
        public bool AddToTeam(Employee employee)
        {
            if (employee is Developer || employee is Designer)
            {
                _team.Add(employee);
                return true;
            }
            return false;
        }

        // Return team of developers and designers
        public List<Employee> GetTeam()
        {
            return _team;
        }
    }
}
