using LLEmployees.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLEmployees.Repository
{
    public interface IEmployeeRepository
    {
        void Create(Employee item);
        IEnumerable<Employee> GetAll(int page_size, int page);
        Employee GetById(long id);
        void Delete(long id);
        void Update(Employee item, long id);
    }
}
