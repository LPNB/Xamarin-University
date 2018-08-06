using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Create the array named "intArray"
            int[] intArray = new int[5];

            // TODO: Fill in the array with data
            intArray[0] = 0;
            intArray[1] = 471;
            intArray[2] = 9;
            intArray[3] = 833;
            intArray[4] = 25;

            // TODO: Display the array
            foreach (int i in intArray)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
