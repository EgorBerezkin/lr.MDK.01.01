using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remote_assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------АНАЛИЗ ПРОДАЖ МОБИЛЬНЫХ ТЕЛЕФОНОВ------");
            var salesData = new List<Sale_of_phones>
            {
                new Sale_of_phones {
                Date = new DateTime(2025, 11, 12),
                PhoneModel = "IPhone 16",
                Quantity = 7,
                Price = 89900
            },
            new Sale_of_phones {
                Date = new DateTime(2025, 11, 12),
                PhoneModel = "Samsung Galaxy A51",
                Quantity = 4,
                Price = 69900
            },
            new Sale_of_phones {
                Date = new DateTime(2025, 11, 13),
                PhoneModel = "IPhone Pro 15",
                Quantity = 5,
                Price = 119000
            },
            new Sale_of_phones {
                Date = new DateTime(2025, 11, 13),
                PhoneModel = "Samsung Galaxy A51",
                Quantity = 1,
                Price = 55900
            },
            new Sale_of_phones {
                Date = new DateTime(2025, 11, 14),
                PhoneModel = "Samsung Galaxy S27",
                Quantity = 3,
                Price = 81900
            },
            new Sale_of_phones {
                Date = new DateTime(2025, 11, 14),
                PhoneModel = "IPhone 16",
                Quantity = 2,
                Price = 99000
            },
            new Sale_of_phones {
                Date = new DateTime(2025, 11, 15),
                PhoneModel = "Samsung Galaxy S27",
                Quantity = 2,
                Price = 89900
            },
            new Sale_of_phones {
                Date = new DateTime(2025, 11, 15),
                PhoneModel = "IPhone Pro 15",
                Quantity = 5,
                Price = 99000
            }
            };
            DateTime startDate = new DateTime(2025, 11, 12);
            DateTime endDate = new DateTime(2025, 11, 15);
            // а) Общая сумма проданного за период
            double totalRevenue = salesData
            .Where(sale => sale.Date >= startDate && sale.Date <= endDate)
            .Sum(sale => sale.Revenue);
            Console.WriteLine($"а) Общая сумма проданных телефонов за период {startDate:dd.MM.yyyy} - {endDate:dd.MM.yyyy}: {totalRevenue} рублей");
            // б) Самый продаваемый телефон и телефон с наименьшими продажами
            var phoneStats = salesData
            .GroupBy(s => s.PhoneModel)
            .Select(g => new { Model = g.Key, TotalSold = g.Sum(s => s.Quantity) })
            .OrderByDescending(x => x.TotalSold)
            .ToList();
            string BestPhone = phoneStats.First().Model;
            string WorstPhone = phoneStats.Last().Model;
            Console.WriteLine($"б) Результаты анализа продаж:");
            Console.WriteLine($"   • Самый продаваемый телефон: {BestPhone}");
            Console.WriteLine($"   • Самый непродаваемый телефон: {WorstPhone}");
            // в) Два телефона, приносящие наибольшую прибыль
            var topPhones = salesData
            .GroupBy(s => s.PhoneModel)
            .Select(g => new { Model = g.Key, Profit = g.Sum(s => s.Revenue) })
            .OrderByDescending(x => x.Profit)
            .Take(2)
            .Select(x => x.Model)
            .ToList();
            Console.WriteLine($"в) Телефоны с наибольшей прибылью:");
            for (int i = 0; i < topPhones.Count; i++)
            {
                Console.WriteLine($"    {i + 1}. {topPhones[i]}");
            }
            // Отображение временного ряда, сортировка по дате
            Console.WriteLine("4. Временной ряд продаж:");
            Console.WriteLine("Дата            Модель                  Количество      Выручка");
            Console.WriteLine("---------------------------------------------------------------------");
            var timeSeries = salesData.OrderBy(sale => sale.Date);
            foreach (var sale in timeSeries)
            {
                Console.WriteLine($"{sale.Date:dd.MM.yyyy}      {sale.PhoneModel,-20}    {sale.Quantity}               {sale.Revenue} рублей");
            }
        }
    }
}

