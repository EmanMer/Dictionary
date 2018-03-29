using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Mercado
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new Dictionary<int, Employee>();

            employees.Add(101, 
                new Employee {
                    Id = 101,
                    FirstName = "Jesse",
                    LastName = "Liberty"
                });
            employees.Add(102, new Employee { Id = 102, FirstName = "George", LastName = "Washignton" });
            employees.Add(103, new Employee { Id = 103, FirstName = "Mark", LastName = "Smith" });

            Console.WriteLine(employees[101]);
            Console.WriteLine(employees[102]);
            Console.WriteLine(employees[103]);

            Console.Read();
        }
    }
}
