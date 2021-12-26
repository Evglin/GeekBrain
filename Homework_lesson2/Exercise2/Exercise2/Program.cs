using System;

namespace Exercise2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Введите порядковый номер месяца: ");
            int MonthNumber = Convert.ToInt32(Console.ReadLine());

            string MonthName;
            switch (MonthNumber)
            {
                case 1:
                    MonthName = "январь";
                    break;
                case 2:
                    MonthName = "февраль";
                    break;
                case 3:
                    MonthName = "март";
                    break;
                case 4:
                    MonthName = "апрель";
                    break;
                case 5:
                    MonthName = "май";
                    break;
                case 6:
                    MonthName = "июнь";
                    break;
                case 7:
                    MonthName = "июль";
                    break;
                case 8:
                    MonthName = "август";
                    break;
                case 9:
                    MonthName = "сентябрь";
                    break;
                case 10:
                    MonthName = "октябрь";
                    break;
                case 11:
                    MonthName = "ноябрь";
                    break;
                case 12:
                    MonthName = "декабрь";
                    break;
                default:
                    MonthName = "Введен неправильный номер месяца!";
                    break;
            }
            Console.WriteLine($"месяц (case): {MonthName}");

        }
    }
}
