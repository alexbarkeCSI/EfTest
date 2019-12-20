using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EfTest.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Organization { get; set; }

        public Employee()
        {
            
        }
    }
}
