using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TEST.Domain
{
    public class Employee
    {
        [Required]
        public int EmployeeId { get; set; }
        [Required]
        public Person Person { get; set; }
        [Required]
        public string EmployeeNumber { get; set; }
        [Required]
        public DateTime EmployedDate { get; set; }
        public DateTime TerminatedDate { get; set; }
    }
}
