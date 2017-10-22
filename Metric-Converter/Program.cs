using System;
using System.Collections.Generic;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double val = double.Parse(Console.ReadLine());
            string from = Console.ReadLine();
            string to = Console.ReadLine();

            Dictionary<string, double> toMetters = new Dictionary<string, double>()
            {
                { "m", 1 },
                { "mm", 1000 },
                {  "cm", 100 },
                { "mi", 0.000621371192 },
                { "in", 39.3700787 },
                { "km", 0.001 },
                { "ft", 3.2808399 },
                { "yd", 1.0936133 }
            };

            double metricsToMeters = val / toMetters[from];

            double result = metricsToMeters * toMetters[to];

            Console.WriteLine($"{result:f8}");
        }
    }
}
