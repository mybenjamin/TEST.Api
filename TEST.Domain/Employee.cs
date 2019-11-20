using System;
using System.Collections.Generic;
using System.Text;

namespace TEST.Domain
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public Person Person { get; set; }
        public string EmployeeNumber { get; set; }
        public DateTime EmployedDate { get; set; }
        public DateTime TerminatedDate { get; set; }
    }
}
