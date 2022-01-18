using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hw5_ex4
{    
    class Program
    {
   
        static void Main(string[] args)
        {
            System.Console.Write(">");
            string userDirectory = System.Console.ReadLine();
            
            List<string> dirs = new List<string>(Directory.EnumerateFileSystemEntries(userDirectory));
     
            string text = "";
            //без рекурсии
            foreach (string Dir in dirs)
            {
           //     System.Console.WriteLine(Dir);
                text = text + "\n" + Dir;
                File.WriteAllText("norecurse.txt", text);
            }

            //с рекурсией
            File.Delete("recurse.txt");
            getdirs(userDirectory);

            
        }

        static void getdirs(string path)
        {
            List<string> tempdirs = new List<string>(new List<string>(Directory.EnumerateFileSystemEntries(path)));
      
            foreach (string Dir in tempdirs)
            {
              //  System.Console.WriteLine(Dir);
                string text = "\n" + Dir;
                File.AppendAllText("recurse.txt", text);
                try
                {
                    getdirs(Dir);
                }
                catch { };
            }
 
        }
    }
}
