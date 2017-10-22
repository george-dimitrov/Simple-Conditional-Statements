using System;

namespace Password_Guess
{
    class Program
    {
        private const string pass = "s3cr3t!P@ssw0rd";
        static void Main(string[] args)
        {
            string str = Console.ReadLine().Trim();
            if (pass.Equals(str))
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
