using LLEmployees.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLEmployees.Repository
{
    public interface IEmployeeRepository
    {
        //Aula
        //void Add(Usuario user);
        //IEnumerable<Usuario> GetAll();
        //Usuario Find(long id);
        //void Remove(long id);
        //void Update(Usuario user);

        //Minha
        //public IActionResult Create([FromBody] Employee item)
            void Create(Employee item); //? na duvida pq ele retorna um Employee no response
        //public IEnumerable<Employee> GetAll(int page_size, int page)
            IEnumerable<Employee> GetAll(int page_size, int page);
        //public IActionResult GetById(long id)
            Employee GetById(long id);
        //public IActionResult Delete(long id)
            void Delete(long id);
        //public IActionResult Update([FromBody] Employee item, long id)
            void Update(Employee item, long id);

    }
}
