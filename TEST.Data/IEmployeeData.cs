using System;
using System.Collections.Generic;
using System.Text;
using TEST.Domain;

namespace TEST.Data
{
    interface IEmployeeData
    {
        IEnumerable<Employee> GetEmployees();
    }
}
