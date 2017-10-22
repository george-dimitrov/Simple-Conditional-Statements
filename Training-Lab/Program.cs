using System;

namespace Training_Lab
{
    class Program
    {
        private const int CorridorDistance = 100;
        private const int TableLength = 70;
        private const int TableWidth = 120;
        private const int LostPlaces = 3;

        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine()) * 100;
            double width = double.Parse(Console.ReadLine()) * 100;
            int tablesPerRow = (int) (width - CorridorDistance) / TableLength;
            int rowsCount = (int) (height / TableWidth);
            Console.WriteLine((tablesPerRow * rowsCount) - LostPlaces);
        }
    }
}
