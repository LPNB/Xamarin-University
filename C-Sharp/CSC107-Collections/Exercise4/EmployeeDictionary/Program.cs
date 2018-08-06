using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: create a Dictionary from int to Employee
            Dictionary<int, Employee> employeeDictionary = new Dictionary<int, Employee>();

            /* TODO: Add an employee with an id of 101 to the dictionary
                     Add an employee with an id of 102 to the dictionary
                     Add an employee with an id of 103 to the dictionary */
            employeeDictionary.Add(101, new Employee { Id = 101, FirstName = "Aspen", LastName = "Of Azeroth" });
            employeeDictionary.Add(102, new Employee { Id = 102, FirstName = "Master", LastName = "Chief" });
            employeeDictionary.Add(103, new Employee { Id = 103, FirstName = "Victor", LastName = "Vran" });

            // TODO: Display the three employees
            foreach (Employee emp in employeeDictionary.Values)
            {
                Console.WriteLine($"{emp}");
            }

            Console.ReadLine();
        }
    }
}
