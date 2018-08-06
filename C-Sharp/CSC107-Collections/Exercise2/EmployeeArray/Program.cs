using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Create employeeArray
            Employee[] employeeArray = new Employee[3];

            // TODO: Populate employeeArray with some data
            employeeArray[0] = new Employee { FirstName = "Aspen", LastName = "Of Azeroth" };
            employeeArray[1] = new Employee { FirstName = "Master", LastName = "Chief" };
            employeeArray[2] = new Employee { FirstName = "Victor", LastName = "Vran" };

            // TODO: Display employeeArray
            foreach (Employee emp in employeeArray)
            {
                Console.WriteLine(emp);
            }

            Console.ReadLine();
        }
    }
}
