﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_OOP.Reports
{
    public interface ISalaryReport
    {
        string FirstName { get; set; }
        string SecondName { get; set; }
        decimal FullSalary { get; set; }
    }
}
