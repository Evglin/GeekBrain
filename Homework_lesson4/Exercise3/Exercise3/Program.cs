using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool GotNumber = false;
            int MonthNumber = 0;
            do
            {
                Console.Write("Ведите номер месяца: ");
                try
                {
                    MonthNumber = Convert.ToInt32(Console.ReadLine().Trim());
                    if (MonthNumber >= 1 && MonthNumber <= 12)
                    {
                        GotNumber = true;
                    }
                    else
                    {
                        Console.WriteLine("Введите число от 1 до 12");
                        GotNumber = false;
                    }
                }
                catch
                {
                    Console.WriteLine("Введено не число");
                    GotNumber = false;
                }
            }
            while (GotNumber != true);
            Console.WriteLine($"время года: {GetSeason(MonthNumber)}");

        }
        static string GetSeason(int MonthNumber)
        {
            string[] Seasons = new string[] { "весна", "лето", "осень", "зима" };
            int seasonNumber = 0;
            switch (MonthNumber)
            {
                case 12:
                case 1:
                case 2:
                    seasonNumber = 3;
                   break;
                case 3:
                case 4:
                case 5:
                    seasonNumber = 0;
                    break;
                case 6:
                case 7:
                case 8:
                    seasonNumber = 1;
                    break;
                case 9:
                case 10:
                case 11:
                    seasonNumber = 2;
                    break;
            }               
            return Seasons[seasonNumber];
        }
    }
}
