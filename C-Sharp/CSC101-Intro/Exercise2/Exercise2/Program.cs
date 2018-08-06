using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int myAge = 29;
            int yourAge = 35;

            const int retirement = 65;

            string message = "Will we be ready to retire soon?";

            // calculate years to retirement
            int yearsToRetirementForYou = retirement - yourAge;
            int yearsToRetirementForMe = retirement - myAge;

            // display messages
            Console.WriteLine(message);
            Console.WriteLine("Years for you: " + yearsToRetirementForYou); // concatenating strings
            Console.WriteLine("Years for me: {0}", yearsToRetirementForMe); // formatting    strings

            Console.ReadLine();
        }
    }
}
