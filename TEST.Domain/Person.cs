using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TEST.Domain
{
    public class Person
    {
        [Required]
        public int PersonId { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
    }
}
