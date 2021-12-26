using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите температуру 1: ");
            int Temp1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите температуру 2: ");
            int Temp2 = Convert.ToInt32(Console.ReadLine());

            double AverageTemp = Convert.ToDouble(Temp1 + Temp2) / 2;
            Console.Write($"Средняя температура: {Convert.ToString(AverageTemp)}");
            Console.ReadKey();
        }
    }
}
