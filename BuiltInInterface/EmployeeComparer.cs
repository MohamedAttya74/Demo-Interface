﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface.BuiltInInterface
{
    internal class EmployeeComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            
            Employee? employeeX = (Employee?) x;
            Employee? employeeY = (Employee?) y;

            return employeeX?.CompareTo(employeeY) ?? (employeeY is null ? 0  : -1);
                }
    }
}
