using LLEmployees.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLEmployees.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeContext _context;

        public EmployeeRepository(EmployeeContext ctx)
        {
            _context = ctx;
        }

        public void Create(Employee item)
        {
            _context.Employees.Add(item);
            _context.SaveChanges();
        }

        public void Delete(long id)
        {
            var emp = _context.Employees.FirstOrDefault(t => t.Id == id);

            _context.Employees.Remove(emp);
            _context.SaveChanges();

        }

        public IEnumerable<Employee> GetAll(int page_size, int page)
        {
            return _context.Employees.Skip((page - 1) * page_size).Take(page_size).ToList();
        }

        public Employee GetById(long id)
        {
            var item = _context.Employees.FirstOrDefault(t => t.Id == id);
            return item;
        }

        public void Update(Employee item, long id)
        {
            var emp = _context.Employees.FirstOrDefault(t => t.Id == id);

            emp.Name = item.Name;
            emp.Email = item.Email;
            emp.Department = item.Department;

            _context.Employees.Update(emp);
            _context.SaveChanges();

        }
    }
}
