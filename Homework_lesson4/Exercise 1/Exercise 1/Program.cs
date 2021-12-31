using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("количество ФИО: ");
            int repeats =  Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= repeats; i++)
            {
                Console.WriteLine(Convert.ToString(i));
                Console.Write("Фамилия: ");
                string lastName = Console.ReadLine();
                Console.Write("Имя: ");
                string firstName = Console.ReadLine();
                Console.Write("Отчество: ");
                string patronymic = Console.ReadLine();

                
                Console.WriteLine($"ФИО: {GetFullName(firstName, lastName, patronymic)}");
            }  

        }

        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            string fullName = lastName.Trim() + " " + firstName.Trim() + " " + patronymic.Trim();
            return (fullName);
        }
    }
}
