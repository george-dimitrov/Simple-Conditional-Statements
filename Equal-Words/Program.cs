using System;

namespace Equal_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine().ToLower();
            string second = Console.ReadLine().ToLower();

            if (first.Equals(second))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
