using System;

namespace Hw7_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            string secret = "qwerty";
            Console.WriteLine("Enter password:");
            string input = Console.ReadLine();
            if (input == secret)
            {
                Console.WriteLine("Welcome!");
            }
            else
            {
                Console.WriteLine("Error!");
            }

        }
    }
}
