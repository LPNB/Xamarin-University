using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculation
{
    class Program
    {
        public static void Main(string[] args)
        {
            Tipper tipper = new Tipper();

            while (true)
            {
                Console.Write("Please enter check amount: ");
                tipper.TotalBill = double.Parse(Console.ReadLine());

                Console.Write("B)ad tip O)k tip G)ood Tip D)ivvy the bill Q)uit: ");
                char operation = Console.ReadLine().ToUpper()[0];

                if (operation == 'Q')
                    break;

                double userInput = 0.0;

                switch (operation)
                {
                    case 'B':
                        userInput = tipper.CalculateTip(0.10); 
                        break;

                    case 'O':
                        userInput = tipper.CalculateTip(); // 15%
                        break;

                    case 'G':
                        userInput = tipper.CalculateTip(0.20);
                        break;

                    case 'D':
                        Console.Write("Number of people? ");
                        int numPeople = int.Parse(Console.ReadLine());
                        userInput = tipper.Divvy(numPeople);
                        break;

                    default:
                        Console.WriteLine("Please enter B, O, G, D or Q");
                        break;
                }

                Console.WriteLine("Answer: {0}", userInput);
            }

            Console.ReadLine();
        }
    }
}
