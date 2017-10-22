using System;

namespace Area_Of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();
            if (figureType == "square")
            {
                Console.WriteLine(Math.Round(Math.Pow(double.Parse(Console.ReadLine()), 2), 3));
            }
            else if (figureType == "rectangle")
            {
                Console.WriteLine(Math.Round(double.Parse(Console.ReadLine()) * double.Parse(Console.ReadLine()), 3));
            }
            else if (figureType == "triangle")
            {
                
                Console.WriteLine(Math.Round(double.Parse(Console.ReadLine()) * double.Parse(Console.ReadLine()) / 2, 3));
            }
            else if (figureType == "circle")
            {
                Console.WriteLine(Math.Round(Math.PI * Math.Pow(double.Parse(Console.ReadLine()), 2), 3));
            }
        }
    }
}
