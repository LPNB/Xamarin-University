using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        public static void Main(string[] args)
        {
            string num;

            // prompt user to enter 2 numbers
            Console.Write("Please enter the first number: ");
            num = Console.ReadLine();
            decimal x = decimal.Parse(num);

            Console.Write("Please enter the second number: ");
            num = Console.ReadLine();
            decimal y = decimal.Parse(num);

            // perform addition
            decimal sum = x + y;
            Console.WriteLine("{0} + {1} = {2}", x, y, sum);

            // perform subtraction
            decimal difference = x - y;
            Console.WriteLine("{0} - {1} = {2}", x, y, difference);

            // perform multiplication
            decimal product = x * y;
            Console.WriteLine("{0} * {1} = {2}", x, y, product);

            // perform division
            if (y == 0)
            {
                Console.WriteLine("Error: denominator is zero");
            }
            else
            {
                decimal quotient = x / y;
                Console.WriteLine("{0} / {1} = {2}", x, y, quotient);
            }

            Console.ReadLine();
        }
    }
}
