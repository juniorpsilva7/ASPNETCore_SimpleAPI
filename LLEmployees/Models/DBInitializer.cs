using LLEmployees.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;


namespace LLEmployees.Models
{
    public class DBInitializer
    {
        private static EmployeeContext _context;

        public static void Seed(EmployeeContext context)
        {
            //EmployeeContext _context =
            //    applicationBuilder.ApplicationServices.GetRequiredService<EmployeeContext>();

            _context = context;

            if (_context.Employees.Count() == 0)
            {
                _context.Add( new Employee { Name = "Rodrigo Carvalho", Email = "rodrigo@luizalabs.com", Department = "IntegraCommerce" });
                _context.Add( new Employee { Name = "Renato Pedigoni", Email = "renato@luizalabs.com", Department = "Digital Platform" });
                _context.Add( new Employee { Name = "Thiago Catoto", Email = "catoto@luizalabs.com", Department = "Mobile" });
                
                _context.SaveChanges();
            }
        }
    }
}
