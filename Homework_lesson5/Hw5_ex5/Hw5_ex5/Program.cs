using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Hw5_ex5
{
    class Program
    {

        static void Main(string[] args)
        {
            string fileName = "task.json";
            string directory = @"bin/xml/";
            string userText = "";
    
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            List<ToDo> Tasks = new List<ToDo>();
            string path = "";
            path = directory + fileName;
            if (File.Exists(path))
            {
                string TextFile = File.ReadAllText(path);
                Tasks = JsonConvert.DeserializeObject<List<ToDo>>(TextFile);
            }
            reNew(Tasks);

            do
            {
                
                userText = System.Console.ReadLine();
                if (userText == "n")
                {
                    ToDo Task = new ToDo();
                    Task.Title = Task.AddTask();
                    Task.IsDone = false;
                    Tasks.Add(Task);
                    reNew(Tasks);
                }
                else
                {
                    try
                    {
                        int TaskNumber = Convert.ToInt32(userText);
                        Tasks[TaskNumber - 1].IsDone = true;
                        reNew(Tasks);
                    }
                    catch
                    {
                        System.Console.WriteLine("Неправильный номер задачи. Нажмите любую клавишу для продолжения.");
                        System.Console.ReadKey();
                        reNew(Tasks);
                    }
                }
            }
            while (userText != "c");
            
            string text = JsonConvert.SerializeObject(Tasks);
            File.WriteAllText(path, text);
        }

        static  void reNew(List<ToDo> Tasks)
        {
            System.Console.Clear();
            int i = 0;
            foreach (ToDo task in Tasks)
            {
                i++;
                task.PrintTask(i);
            }
            System.Console.Write("Нажмите клавишу (c) - для выхода, (n) -  для добавления задания, номер задания для отметки о его выполнении.");
        }
    }
}
