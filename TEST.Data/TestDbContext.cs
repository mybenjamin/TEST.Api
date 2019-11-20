using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TEST.Domain;

namespace TEST.Data
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options)
            :base(options) { }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
