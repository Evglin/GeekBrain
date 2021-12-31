using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите строку чисел: ");
            string stringOfNumbers = Console.ReadLine();
            Console.WriteLine($"Сумма числел = {GetSumm(stringOfNumbers)}");
        }

        static int  GetSumm(string numbers)
        {
            string[] numbersArray = numbers.Split(' ');
            int Sum = 0;
            for (int i = 0; i < numbersArray.Length; i++)
            {
                Sum = Sum + Convert.ToInt32(numbersArray[i]);        
            }

            return Sum;
        }
    }
}
