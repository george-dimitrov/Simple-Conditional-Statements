using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            byte workers = byte.Parse(Console.ReadLine());

            int kg = (int) (x * y);
            double wine = kg * 40 / 100 / 2.5;

            if (wine >= z)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{wine - z} liters left -> {Math.Ceiling((wine - z) / workers)} liters per person.");
            }
            else
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(z - wine)} liters wine needed.");
            }
        }
    }
}
