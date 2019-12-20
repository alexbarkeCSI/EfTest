using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EfTest.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EfTest.Data
{
  public class EmployeeContext : IdentityDbContext
  {
    public EmployeeContext(DbContextOptions<EmployeeContext> options)
        : base(options)
    {
    }

    public DbSet<Employee> Employees { get; set; }
  }
}
