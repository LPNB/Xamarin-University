using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerivedTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Perform an "Add" operation
            AddOperation add = new AddOperation(5, 16);
            Console.WriteLine(add.Calculate());

            // TODO: perform a "Multiply" operation (create MultiplyOperation class)
            MultiplyOperation multiply = new MultiplyOperation(5, 16);
            Console.WriteLine(multiply.Calculate());

            Console.ReadLine();
        }
    }
}
