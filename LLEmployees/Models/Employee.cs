using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLEmployees.Models
{
    public class Employee
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
    }
}
