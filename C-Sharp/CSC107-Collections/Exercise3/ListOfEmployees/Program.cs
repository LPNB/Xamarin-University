using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfEmployees
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: define a List of employee objects
            List<Employee> employeeList = new List<Employee>();

            // TODO: populate some employees into your list
            employeeList.Add(new Employee { FirstName = "Aspen", LastName = "Of Azeroth" });
            employeeList.Add(new Employee { FirstName = "Master", LastName = "Chief" });
            employeeList.Add(new Employee { FirstName = "Victor", LastName = "Vran"});

            // TODO: display the list
            foreach(Employee emp in employeeList)
            {
                Console.WriteLine(emp);
            }

            Console.ReadLine();
        }
    }
}
