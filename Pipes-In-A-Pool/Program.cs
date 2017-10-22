using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipes_In_A_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            int poolCapacity = int.Parse(Console.ReadLine());
            int firstDebit = int.Parse(Console.ReadLine());
            int secondDebit = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double firstPipе =  h * firstDebit;
            double secondPipе = h * secondDebit;

            double allLitters = firstPipе + secondPipе;

            if (allLitters <= poolCapacity)
            {
                Console.WriteLine($"The pool is {(int)(allLitters * 100 / poolCapacity)}% full. Pipe 1: {(int)(firstPipе * 100 / allLitters)}%. Pipe 2: {(int)(secondPipе * 100 / allLitters)}%.");
            }
            else
            {
                Console.WriteLine($"For {h} hours the pool overflows with {(firstPipе + secondPipе - poolCapacity):f1} liters.");
            }
        }
    }
}
