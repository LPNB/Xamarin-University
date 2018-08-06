using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        public static void Main(string[] args)
        {
            // ask user age
            Console.Write("Please enter your age: ");

            // read user age
            string yourAge = Console.ReadLine();

            // convert user age from string to int 
            int yourAgeAsInt = int.Parse(yourAge);

            // output age
            Console.WriteLine("Your age is {0}", yourAge.ToString());
       
            Console.ReadLine();
        }
    }
}
