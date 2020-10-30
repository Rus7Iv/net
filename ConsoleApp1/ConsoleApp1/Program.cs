using System;
using System.Text.Json;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите количество дней которые вы прожили");
            var days = Console.ReadLine();
            int dayss= Convert.ToInt32(days);
            int year = dayss/ 365;
            int month = (dayss%365)/30;
            dayss = (dayss % 365)%30;
            Console.WriteLine($"Твой возраст {year} лет {month} месяцев и {dayss} дней");
            if (year >= 18)
            {
                int a;
                a = 0;
                while (a!=10)
                    { ++a;
                    Console.WriteLine($"{a}");
                }
                Console.WriteLine($"Вы совершеннолетний!");


            }
            else
                Console.WriteLine($"Вы несовершеннолетний");

            Console.ReadKey();





        }
    }
}
