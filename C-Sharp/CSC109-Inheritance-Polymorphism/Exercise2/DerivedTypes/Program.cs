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
            // TODO: create list of operations 
            List<Operation> operationsList = new List<Operation>();

            // TODO: populate list with opeartion types
            operationsList.Add(new AddOperation(65, 2));
            operationsList.Add(new MultiplyOperation(18, 49));
            operationsList.Add(new AddOperation(77, 38));
            operationsList.Add(new MultiplyOperation(41, 5));

            // TODO: calculate each operation type from list
            foreach (Operation operation in operationsList)
            {
                Console.WriteLine(operation.Calculate());
            }

            Console.ReadLine();
        }
    }
}
