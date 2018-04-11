using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using LLEmployees.Models;
using System.Linq;
using LLEmployees.Repository;

namespace LLEmployees.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {

        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepo)
        {
            _employeeRepository = employeeRepo;
        }

        [HttpGet]
        public IEnumerable<Employee> GetAll(int page_size, int page)
        {
            return _employeeRepository.GetAll(page_size, page);
        }

        [HttpGet("{id}", Name = "GetEmployee")]
        public IActionResult GetById(long id)
        {
            var item = _employeeRepository.GetById(id);

            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Employee item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            _employeeRepository.Create(item);
            return CreatedAtRoute("GetEmployee", new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromBody] Employee item, long id)
        {
            if (item == null || item.Id != id)
            {
                return BadRequest();
            }

            var emp = _employeeRepository.GetById(id);
            if (emp == null)
            {
                return NotFound();
            }

            emp.Name = item.Name;
            emp.Email = item.Email;
            emp.Department = item.Department;

            _employeeRepository.Update(emp, item.Id);
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var emp = _employeeRepository.GetById(id);
            if (emp == null)
            {
                return NotFound();
            }

            _employeeRepository.Delete(id);
            return StatusCode(200);
        }

    }
}