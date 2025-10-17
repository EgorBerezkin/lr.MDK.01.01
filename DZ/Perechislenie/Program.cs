using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Perechislenie
{
    internal class Program
    {
        enum DayOfWeek
        {
            Понедельник = 1,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресенье
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер дня недели (1-7): ");
            int DayWeek;
            if (int.TryParse(Console.ReadLine(), out DayWeek))
            {
                if (DayWeek >= 1 && DayWeek <= 7)
                {
                    DayOfWeek day = (DayOfWeek)DayWeek;
                    Console.WriteLine($"Это {day}");
                }
                else
                {
                    Console.WriteLine("Некорректный номер. Введите число от 1 до 7.");
                }
            }
            else
            {
                Console.WriteLine("Некорректный номер. Введите число от 1 до 7.");
            }
            Console.ReadLine();
        }
    }
}
