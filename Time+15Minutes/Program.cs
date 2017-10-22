using System;

namespace Time_15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            if (hours > 0)
            {
                minutes += hours * 60;
            }
            minutes += 15;
            hours = minutes / 60;
            if (hours > 23)
            {
                hours -= 24;
            }
            minutes = minutes % 60;
            if (minutes > 9)
            {
                Console.WriteLine($"{hours}:{minutes}");
            }
            else
            {
                Console.WriteLine($"{hours}:0{minutes}");
            }
        }
    }
}
