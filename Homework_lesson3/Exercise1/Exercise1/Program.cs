using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Размер массива: ");
            int ArraySize = Convert.ToInt32(Console.ReadLine());
            int[,] Array = new int[ArraySize, ArraySize];

            //Заполнение массива случайными числами (до 9)
            for (int i= 0; i < ArraySize; i++)
            {
                for (int j = 0; j < ArraySize; j++)
                {
                    Random rnd = new Random();
                    Array[i, j] = rnd.Next(1,9);
                }
            }

            //вывод всего массива
            for (int i = 0; i < ArraySize; i++)
            {
                for (int j = 0; j < ArraySize; j++)
                {
                    Console.Write($"{Array[i, j]} ");
                }
                Console.WriteLine();
            }

            //вывод диагонали
            for (int i = 0; i < ArraySize; i++)
            {
                for (int j = 0; j < ArraySize; j++)
                {
                    if (i == j)
                    {
                        Console.Write($"{Array[i, j]} ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
