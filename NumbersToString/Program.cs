﻿using System;
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
                { 2, "two" },
                { 3, "three" },
                { 4, "four" },
                { 5, "five" },
                { 6, "six" },
                { 7, "seven" },
                { 8, "eight" },
                { 9, "nine" },
                { 10, "ten" },
                { 11, "eleven" },
                { 12, "twelve" },
                { 13, "thirteen" },
                { 14, "fourteen" },
                { 15, "fifteen" },
                { 16, "sixteen" },
                { 17, "seventeen" },
                { 18, "eighteen" },
                { 19, "nineteen" },
                { 20, "twenty" },
                { 30, "thirty" },
                { 40, "forty" },
                { 50, "fifty" },
                { 60, "sixty" },
                { 70, "seventy" },
                { 80, "eighty" },
                { 90, "ninety" },
                { 100, "one hundred" },
            };

            if (number < 0 || number > 100)
            {
                Console.WriteLine("invalid number");
            }
            else if (number < 20 || number % 10 == 0)
            {
                Console.WriteLine(nums[number]);
            }
            else
            {
                Console.WriteLine($"{nums[number -(number % 10)]} {nums[number % 10]}");
            }
        }
    }
}
