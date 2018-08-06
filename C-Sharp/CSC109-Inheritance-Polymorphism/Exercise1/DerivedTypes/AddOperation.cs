using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerivedTypes
{
    public class AddOperation
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public AddOperation(int num1, int num2)
        {
            FirstNumber = num1;
            SecondNumber = num2;
        }

        public string Calculate()
        {
            return string.Format("{0} + {1} = {2}", FirstNumber, SecondNumber, FirstNumber + SecondNumber);
        }
    }
}
