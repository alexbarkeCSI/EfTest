using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EfTest.Models
{
  public class Employee
  {
    [Required]
    public Guid Id { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    public string Organization { get; set; }
    [Required]
    public DateTime Dob { get; set; }

    public Employee()
    {

    }
  }
}
