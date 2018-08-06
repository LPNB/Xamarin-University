using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    class Program
    {
        public const string Computer1 = "Macbook Pro";
        public const string Computer2 = "Macbook Air";
        public const string Computer3 = "Mac Mini";

        static void Main(string[] args)
        {
            // TODO: add some computer choices using the PlaceOrder method
            PlaceOrder(Computer1, true, false);
            PlaceOrder(Computer2, false, false);
            PlaceOrder(Computer3, true, true);
            PlaceOrder(Computer2, true);
            PlaceOrder(Computer1);

            Console.ReadLine();
        }

        // TODO: convert appleCare and setUp to optional parameters
        static void PlaceOrder(string computer, bool appleCare=true, bool setUp=false)
        {
            double subTotal = 0;

            switch (computer)
            {
                case Computer1:
                    subTotal = 2000;
                    break;
                case Computer2:
                    subTotal = 1800;
                    break;
                case Computer3:
                    subTotal = 1500;
                    break;
                default:
                    subTotal = 1000;
                    break;
            }

            if (appleCare == true)
                subTotal += 100;
            if (setUp == true)
                subTotal += 50;

            Console.WriteLine("{0}: {1:C}", computer, subTotal);
        }
    }
}
