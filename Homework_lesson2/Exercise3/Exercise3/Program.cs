using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите число: ");
            int Number = Convert.ToInt32(Console.ReadLine());
            int NumberEnd = Number % 2;
            if (NumberEnd == 0)
                {
                Console.WriteLine("четное");
                }
            else
                {
                Console.WriteLine("нечетное");
                }

        }
    }
}
