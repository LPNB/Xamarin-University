using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerivedTypes
{
    class MultiplyOperation : Operation
    {
        public MultiplyOperation(int num1, int num2)
            : base(num1, num2)
        {}

        // TODO: override Calculate method
        public override string Calculate()
        {
            return string.Format("{0} x {1} = {2}", FirstNumber, SecondNumber, FirstNumber * SecondNumber);
        }
    }
}
