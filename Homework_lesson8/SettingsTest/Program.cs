using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettingsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Properties.Settings.Default.UserName == "")
            {
                Console.Write("Ваше имя: ");
                Properties.Settings.Default.UserName = Console.ReadLine();
                Console.Write("Возраст: ");
                Properties.Settings.Default.Age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Вид деятельности: ");
                Properties.Settings.Default.Job = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            else
            {
                Console.WriteLine($"{Properties.Settings.Default.Greetings}, {Properties.Settings.Default.UserName}, Ваш возраст: {Properties.Settings.Default.Age}, вы работаете в {Properties.Settings.Default.Job} ");
            }
            Console.ReadKey();
        }
    }
}
