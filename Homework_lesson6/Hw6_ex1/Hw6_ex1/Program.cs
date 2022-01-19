using System;
using System.Diagnostics;
namespace Hw6_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] proceses = Process.GetProcesses();

            System.Console.CursorLeft = 1;
            System.Console.Write($"name");
            System.Console.CursorLeft = 40;
            System.Console.WriteLine($"ID");
            System.Console.CursorLeft = 1;
            System.Console.WriteLine($"**************************************************");
            for (int i = 0; i < proceses.Length; i++)
            {

                System.Console.CursorLeft = 1;
                System.Console.Write($"{proceses[i].ProcessName}");
                System.Console.CursorLeft = 40;
                System.Console.WriteLine($"{proceses[i].Id}");

            }

            System.Console.Write("укажите name или ID  процесса >");
            string userChoice = System.Console.ReadLine();
            Process foundproc = FoundProcess(proceses, userChoice);
            try
            {
                foundproc.Kill();
            }
            catch
            {
                System.Console.WriteLine("неверное имя процесса");
            }
        }
        static Process FoundProcess(Process[] proceses, string userChoice)
        {
            Process foundproc = new Process();

            try
            {
                int id = Convert.ToInt32(userChoice);
                for (int i = 0; i < proceses.Length; i++)
                {
                    if (proceses[i].Id == id)
                    {
                        foundproc = proceses[i];
                    }
                }
            }
            catch
            {
                for (int i = 0; i < proceses.Length; i++)
                {
                    if (proceses[i].ProcessName.Equals(userChoice, StringComparison.OrdinalIgnoreCase))
                    { 
                        foundproc = proceses[i];
                    }
                }
            }
            return foundproc;
        }
    }
}
