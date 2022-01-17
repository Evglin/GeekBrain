using System;
using System.IO;

namespace Hw5_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            File.AppendAllText("startup.txt", "\n" + Convert.ToString(DateTime.Now));
        }
    }
}
