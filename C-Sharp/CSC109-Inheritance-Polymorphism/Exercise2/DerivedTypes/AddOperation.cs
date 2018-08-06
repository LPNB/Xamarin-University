using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerivedTypes
{
    // TODO: derive from Operation class
    public class AddOperation : Operation
    {
        // TODO: derive from base constructor
        public AddOperation(int num1, int num2)
            : base(num1, num2)
        {}

        // TODO: override Calculate method
        public override string Calculate()
        {
            return string.Format("{0} + {1} = {2}", FirstNumber, SecondNumber, FirstNumber + SecondNumber);
        }
    }
}
