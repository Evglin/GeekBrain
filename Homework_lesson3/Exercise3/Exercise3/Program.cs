using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string InputString = Console.ReadLine();
            for (int i = (InputString.Length - 1); i>=0; i--)
            {
                Console.Write(InputString[i]);
            }
        }
    }
}
