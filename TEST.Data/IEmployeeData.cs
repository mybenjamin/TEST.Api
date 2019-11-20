using System;
using System.Collections.Generic;
using System.Text;
using TEST.Domain;

namespace TEST.Data
{
    public interface IEmployeeData
    {
        IEnumerable<Employee> GetEmployees();
    }
}
