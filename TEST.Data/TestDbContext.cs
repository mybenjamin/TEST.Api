using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TEST.Domain;

namespace TEST.Data
{
    class TestDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
