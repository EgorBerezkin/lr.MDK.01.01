using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Data_structure
{
    internal class Program
    {
        static void Main()
        {
            List<ShoppingProject> GenerateShoppingProjects(int count)
            {
                var projects = new List<ShoppingProject>(); // Пустой список
                var random = new Random(); // Генератор рандома
                var stylenames = new List<string>{
                                                  "Повседневный образ   ",
                                                  "Деловой костюм       ",
                                                  "Вечерний наряд       ",
                                                  "Спортивный стиль     ",
                                                  "Уличный стиль        ",
                                                  "Пляжный образ        ",
                                                  "Зимний комплект      ",
                                                  "Летний гардероб      ",
                                                  "Минималистичный стиль"}; // Список стилей
                for (int i = 0; i < count; i++) // Начало цикла, который будет выводить случайные числа
                                                // для 4 показателей
                {
                    string name = stylenames[random.Next(stylenames.Count)];
                    int itemCount = random.Next(1, 16);
                    int shoppingtime = random.Next(30, 180);
                    double budget = random.Next(1000, 20001);
                    projects.Add(new ShoppingProject(name, itemCount, shoppingtime, budget)); // Добавление проекта
                                                                                              // в пустой список
                }
                return projects;  // строка для возврата метода
            }
            List<ShoppingProject> FindTopProjects(List<ShoppingProject> projects, Func<ShoppingProject, IComparable> selector, int topCount)
            {
                return projects
                    .OrderByDescending(selector) // Сортировка по убыванию значения, возвращаемого selector
                    .Take(topCount)              // Взятие указанного количества элементов
                    .ToList();                   // Преобразование в List
            }
            void PrintResults(List<ShoppingProject> projects)
            {
                for (int i = 0; i < projects.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {projects[i]}"); // Цикл вывода результата
                }
            }
            /// Покупка вещей для образа
            /// Характеристики: количество предметов, время на поход в магазин, бюджет
            List<ShoppingProject> shoppingProjects = GenerateShoppingProjects(10); // Создание списка из
                                                                                   // 10 случайных чисел
            Console.WriteLine("          Покупки вещей для образов");
            Console.WriteLine($"             Всего проектов: {shoppingProjects.Count}");
            Console.WriteLine("------------------------------------------"); 
            Console.WriteLine("ТОП-10 по бюджету: ");
            var topByBudget = FindTopProjects(shoppingProjects, p => p.Budget, 10); // Поиск топ-10 по бюджету
            PrintResults(topByBudget); // Вывод результатов
        }
    }
}
