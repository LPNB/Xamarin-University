using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel
{
    class Program
    {
        static void Main(string[] args)
        {
            RoadTrip chores = new RoadTrip();
            RoadTrip vacation = new RoadTrip();

            // chores
            chores.Miles = 50.0;
            chores.HoursElapsed = 4.00;
            chores.GallonsUsed = 1.20;

            // vacation
            vacation.Miles = 202.50;
            vacation.HoursElapsed = 5.00;
            vacation.GallonsUsed = 58.90;

            // display road trip info
            Console.WriteLine(chores.Miles);
            Console.WriteLine(chores.HoursElapsed);
            Console.WriteLine(chores.GallonsUsed);

            Console.WriteLine();

            Console.WriteLine(vacation.Miles);
            Console.WriteLine(vacation.HoursElapsed);
            Console.WriteLine(vacation.GallonsUsed);

            Console.ReadLine();
        }
    }
}
