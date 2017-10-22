using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Price
{
    class Program
    {
        private const double TaxiStartPrice = 0.70;
        private const double TaxiDaylyRate = 0.79;
        private const double TaxiNightRate = 0.90;
        private const double BussPrice = 0.09;
        private const double TrainPrice = 0.06;
        private const int BussMinDistance = 20;
        private const int TrainMinDistance = 100;

        static void Main(string[] args)
        {
            int km = int.Parse(Console.ReadLine());
            string time = Console.ReadLine().ToLower();

            if (km < 20)
            {
                if (time == "day")
                {
                    Console.WriteLine($"{(km * TaxiDaylyRate + TaxiStartPrice):f2}");
                }
                else if (time == "night")
                {
                    Console.WriteLine($"{(km * TaxiNightRate + TaxiStartPrice):f2}");
                }
            }
            if (km >= BussMinDistance && km < TrainMinDistance)
            {
                Console.WriteLine($"{(km * BussPrice):f2}");
            }
            if (km >= TrainMinDistance)
            {
                Console.WriteLine($"{(km * TrainPrice):f2}");
            }
        }
    }
}
