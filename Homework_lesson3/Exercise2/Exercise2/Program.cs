using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] PhoneBook = new string[5, 2];

            for (int i = 0; i < PhoneBook.GetLength(0); i++)
            {
                Console.Write($"{i+1}. Имя:");
                PhoneBook[i, 0] = Console.ReadLine();
                for (int j = 1; j < PhoneBook.GetLength(1); j++)
                {
                    Console.Write("контакт:");
                    PhoneBook[i, j] = Console.ReadLine();
                }
            }

            Console.Clear();
            for (int i = 0; i < PhoneBook.GetLength(0); i++)
            {
                Console.WriteLine($"{i+1}. {PhoneBook[i, 0]}");
                for (int j = 1; j < PhoneBook.GetLength(1); j++)
                {
                    Console.Write($"{PhoneBook[i, j]} "); ;
                }
                Console.WriteLine();
            }
        }
    }
}
