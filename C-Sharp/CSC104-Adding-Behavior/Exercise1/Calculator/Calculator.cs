using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Calculator
    {
        public float Answer;

        public void Add(float number1, float number2)
        {
            Answer = number1 + number2;
        }
        public void Subtract(float number1, float number2)
        {
            Answer = number1 - number2;
        }

        public void Multiply(float number1, float number2)
        {
            Answer = number1 * number2;
        }

        public void Divide(float number1, float number2)
        {
            if (number2 == 0)
            {
                Answer = 0;
            }
            else
            {
                Answer = number1 / number2;
            }
        }
    }
}
