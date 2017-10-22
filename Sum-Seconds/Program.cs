using System;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int result = first + second + third;

            if (result % 60 == 0)
            {
                Console.WriteLine($"{result / 60}:00");
            }
            else if (result % 60 < 10)
            {
                    Console.WriteLine($"{result / 60}:0{result % 60}");
            }
            else
            {
                Console.WriteLine($"{result / 60}:{result % 60}");
            }

        }
    }
}
