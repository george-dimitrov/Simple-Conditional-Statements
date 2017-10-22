using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivelHour = int.Parse(Console.ReadLine());
            int arrivelMinute = int.Parse(Console.ReadLine());
            int examTimeInMinutes = examHour * 60 + examMinute;
            int arrivelTimeInMinutes = arrivelHour * 60 + arrivelMinute;

            if (examTimeInMinutes == arrivelTimeInMinutes)
            {
                Console.WriteLine("On time");
            }
            if (examTimeInMinutes > arrivelTimeInMinutes && examTimeInMinutes - arrivelTimeInMinutes <= 30)
            {
                Console.WriteLine("On time");
                int resultHours = (examTimeInMinutes - arrivelTimeInMinutes) / 60;
                int resultMinutes = (examTimeInMinutes - arrivelTimeInMinutes) % 60;
                if (resultHours > 0)
                {
                    Console.WriteLine($"{resultHours}:{formatMinutes(resultMinutes)} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{resultMinutes} minutes before the start");
                }
            }
            if (examTimeInMinutes > arrivelTimeInMinutes && examTimeInMinutes - arrivelTimeInMinutes > 30)
            {
                Console.WriteLine("Early");
                int resultHours = (examTimeInMinutes - arrivelTimeInMinutes) / 60;
                int resultMinutes = (examTimeInMinutes - arrivelTimeInMinutes) % 60;
                if (resultHours > 0)
                {
                    Console.WriteLine($"{resultHours}:{formatMinutes(resultMinutes)} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{resultMinutes} minutes before the start");
                }
                
            }
            if (examTimeInMinutes < arrivelTimeInMinutes)
            {
                int resultHours = (arrivelTimeInMinutes - examTimeInMinutes) / 60;
                int resultMinutes = (arrivelTimeInMinutes - examTimeInMinutes) % 60;
                Console.WriteLine("Late");
                if (resultHours > 0)
                {
                    Console.WriteLine($"{resultHours}:{formatMinutes(resultMinutes)} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{resultMinutes} minutes after the start");
                }
            }
        }

        private static string formatMinutes(int minutes)
        {
            if (minutes < 10)
            {
                return "0" + minutes;
            }
            else
            {
                return minutes.ToString();
            }
        }
    }
}
