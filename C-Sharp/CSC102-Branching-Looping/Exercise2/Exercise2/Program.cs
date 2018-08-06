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
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) 
                {
                    Console.WriteLine("{0}: FizzBin!", i);
                }
                else if (i % 3 == 0) 
                {
                    Console.WriteLine("{0}: Fizz", i);
                }
                else if (i % 5 == 0) 
                {
                    Console.WriteLine("{0}: Bin", i);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
