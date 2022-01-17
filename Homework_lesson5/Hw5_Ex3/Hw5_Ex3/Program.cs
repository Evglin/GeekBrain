using System;
using System.IO;
using Newtonsoft;

namespace Hw5_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = 0;
            string userString = "";
            while (true)
            { 
            Console.Write("Количество символов: ");
            userString = System.Console.ReadLine();
                try
                {
                    arraySize = Convert.ToInt32(userString);
                    break;
                }
                catch
                {
                    Console.WriteLine("Ошибка при вводе!");
                }
            }

            byte[] bytessArray = new byte[arraySize];
            for (int i = 0; i< bytessArray.Length; i++)
                { 
                    Console.Write( i + 1 + ". Введите число от 0 до 255: ");
                    userString = System.Console.ReadLine();
                try
                {
                    bytessArray[i] = Convert.ToByte(userString);
                }
                catch
                {
                    Console.WriteLine("Ошибка при вводе!");
                    i = --i; ;
                }                  
                }
            File.WriteAllBytes("Bytes.bin", bytessArray);              
        }
    }
}
