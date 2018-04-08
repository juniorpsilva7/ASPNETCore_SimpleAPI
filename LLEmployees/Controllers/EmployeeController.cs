using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using LLEmployees.Models;
using System.Linq;

namespace LLEmployees.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly EmployeeContext _context;

        public EmployeeController(EmployeeContext context)
        {
            _context = context;

            if (_context.Employees.Count() == 0)
            {
                _context.Employees.Add(new Employee { Name = "Employee1" , Email = "asd@asd.com" , Department = "Dep Teste"});
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public IEnumerable<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }

        [HttpGet("{id}", Name = "GetEmployee")]
        public IActionResult GetById(long id)
        {
            var item = _context.Employees.FirstOrDefault(t => t.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

    }
}