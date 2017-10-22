using System;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double bonus = 0;

            if (number <= 100)
            {
                bonus = 5;
            }
            else if (number > 100 && number <= 1000)
            {
                bonus = (double) number * 20 / 100;
            }
            else if (number > 1000)
            {
                bonus = (double) number * 10 / 100;
            }
            if (number % 2 == 0)
            {
                bonus += 1;
            }
            if (number == 5 || number % 10 == 5)
            {
                bonus += 2;
            }

            Console.WriteLine(bonus);
            Console.WriteLine((double) number + bonus);
        }
    }
}
