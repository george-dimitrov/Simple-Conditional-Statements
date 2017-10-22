using System;
using System.Collections.Generic;

namespace NumbersToString
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Dictionary<int, string> nums = new Dictionary<int, string>()
            {
                { 0, "zero" },
                { 1, "one" },
                { 2, "one" },
                { 3, "three" },
                { 4, "one" },
                { 5, "one" },
                { 6, "six" },
                { 7, "seven" },
                { 8, "eight" },
                { 9, "nine" },
                { 10, "ten" },
                { 11, "eleven" },
                { 12, "twelf" },
                { 13, "thirteen" },
                { 14, "fourteen" },
                { 15, "fifteen" },
                { 16, "sixteen" },
                { 17, "seventeen" },
                { 18, "eighteen" },
                { 19, "nineteen" },
                { 20, "twenty" },
                { 30, "thirty" },
                { 40, "fourty" },
                { 50, "fifty" },
                { 60, "sixty" },
                { 70, "seventy" },
                { 80, "eighty" },
                { 90, "ninety" },
                { 100, "hundred" }
            };
            if (number <= 20 || number % 10 == 0)
            {
                Console.WriteLine(nums[number]);
            }
            //else
            //{
            //    Console.WriteLine($"{nums[number / 10]} {nums[number % 10]}");
            //}
        }
    }
}
