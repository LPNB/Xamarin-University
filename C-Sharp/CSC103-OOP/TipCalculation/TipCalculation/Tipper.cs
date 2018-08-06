using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculation
{
    class Tipper
    {
        public double TotalBill;

        public double CalculateTip(double percentage)
        {
            return TotalBill * percentage;
        }

        public double CalculateTip()
        {
            return CalculateTip(0.15);
        }

        public double Divvy(int numberOfDiners)
        {
            return TotalBill / numberOfDiners;
        }
    }
}
