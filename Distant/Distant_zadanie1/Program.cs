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
            var salesData = CreateSampleData();
            DateTime startDate = new DateTime(2025, 11, 12);
            DateTime endDate = new DateTime(2025, 11, 15);
            // а) Общая сумма проданного за период
            double totalRevenue = GetTotalRevenue(salesData, startDate, endDate);
            Console.WriteLine($"а) Общая выручка за период: {totalRevenue} рублей");
            // б) Самый продаваемый телефон и телефон с наименьшими продажами
            analyzer.TheBestAndWorstPhone(out string BestPhone, out string WorstPhone);
            Console.WriteLine($"б) Результаты анализа продаж:");
            Console.WriteLine($"   • Самый продаваемый телефон: {BestPhone}");
            Console.WriteLine($"   • Самый непродаваемый телефон: {WorstPhone}");
            // в) Два телефона, приносящие наибольшую прибыль
            var topProfitablePhones = analyzer.GetTopTwoProfitablePhones();
            Console.WriteLine($"в) Телефоны с наибольшей прибылью:");
            for (int i = 0; i < topProfitablePhones.Count; i++)
            {
                Console.WriteLine($"    {i + 1}. {topProfitablePhones[i]}");
            }
            // Отображение временного ряда
            Console.WriteLine("4. Временной ряд продаж:");
            analyzer.DisplayTimeSeries();
        }

        // Метод для создания тестовых данных
        private static List<Sale_of_phones> CreateSampleData()
        {
            return new List<Sale_of_phones>
        {
            new Sale_of_phones {
                Date = new DateTime(2025, 11, 12),
                PhoneModel = "IPhone 16",
                Quantity = 7,
                Price = 89900,
                Cost = 70000
            },
            new Sale_of_phones {
                Date = new DateTime(2025, 11, 12),
                PhoneModel = "Samsung Galaxy A51",
                Quantity = 4,
                Price = 69900,
                Cost = 59000
            },
            new Sale_of_phones {
                Date = new DateTime(2025, 11, 13),
                PhoneModel = "IPhone Pro 15",
                Quantity = 5,
                Price = 119000,
                Cost = 80000
            },
            new Sale_of_phones {
                Date = new DateTime(2025, 11, 13),
                PhoneModel = "Samsung Galaxy A51",
                Quantity = 1,
                Price = 55900,
                Cost = 50000
            },
            new Sale_of_phones {
                Date = new DateTime(2025, 11, 14),
                PhoneModel = "Samsung Galaxy S27",
                Quantity = 3,
                Price = 81900,
                Cost = 65000
            },
            new Sale_of_phones {
                Date = new DateTime(2025, 11, 14),
                PhoneModel = "IPhone 16",
                Quantity = 2,
                Price = 99000,
                Cost = 75000
            },
            new Sale_of_phones {
                Date = new DateTime(2025, 11, 15),
                PhoneModel = "Samsung Galaxy S27",
                Quantity = 2,
                Price = 89900,
                Cost = 60000
            },
            new Sale_of_phones {
                Date = new DateTime(2025, 11, 15),
                PhoneModel = "IPhone Pro 15",
                Quantity = 5,
                Price = 99000,
                Cost = 75900
            }
            };
        }
    }
}

