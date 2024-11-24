using EmployeeWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace EmployeeWebAPI
{
    public class TP7Context :DbContext
    {

        public TP7Context(DbContextOptions options) : base(options)
        { 
}

    public DbSet<Employee> Employees { get; set; }
    public DbSet<Departement> Departments { get; set; }

}
    }

