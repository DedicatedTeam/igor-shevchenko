using System;

namespace Company_OOP.Employees
{
    public abstract class Employee
    {
        public string FirstName { get; set; }

        public string SecondName { get; set; }

        private decimal _salaryValue;
        public decimal SalaryValue
        {
            // Value of salary can set only more or equal 0
            set
            {
                if (value <= 0)
                    return;

                _salaryValue = value;
            }
            get { return _salaryValue; }
        }

        private int _experiance;
        public int Experiance
        {
            set
            {
                // set value of experiance more than 0
                if (value < 0)
                    return;

                _experiance = value;
            }
            get { return _experiance; }
        }

        public Manager Manager { get; set; }
    }
}
