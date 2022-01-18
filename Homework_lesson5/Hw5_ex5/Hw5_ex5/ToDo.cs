using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw5_ex5
{
    class ToDo
    {
        private string _title;
        private bool _isDone;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public bool IsDone
        {
            get { return _isDone; }
            set { _isDone = value; }
        }

        public string AddTask()
        {
            System.Console.Write("Введите текст задачи:");
            return System.Console.ReadLine();
        }

        public void PrintTask(int i)
        {
            string printedDone = "";
            switch (_isDone)
            {
                case true:
                    printedDone = "[X] ";
                    break;
                case false:
                    printedDone = "[O] ";
                    break;
            }
            System.Console.WriteLine($"{i}. \t {printedDone + _title}");
        }
    }
}
