using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerivedTypes
{
    public abstract class Operation
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public Operation(int num1, int num2)
        {
            FirstNumber = num1;
            SecondNumber = num2;
        }

        // TODO: create abstract Calculate method
        public abstract string Calculate();
    }
}
