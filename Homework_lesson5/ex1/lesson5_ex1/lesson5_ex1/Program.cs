using System;
using System.IO;

namespace lesson5_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Введите текст:");
            string userText = System.Console.ReadLine();

            File.WriteAllText("sampleText.txt", userText);
        }
    }
}
