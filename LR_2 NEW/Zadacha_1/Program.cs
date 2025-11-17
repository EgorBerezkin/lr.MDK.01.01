using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Вариант 6. Для заведения общепита требуется разработать информационную подсистему учета заказов клиентов. 
            /// Сведения о продукции разнесены по соответствующим категориям: супы, салаты, выпечка, гарниры и т.д. Имеется 
            /// информация о числе заказанных блюд ото дня ко дню. По запросу пользователя – «категория блюд» - вывести на экран
            /// список продукции в порядке от самой востребованной к наименее популярной. Подсчитайте среднее число заказов данной категории.
            List<Orders> Dishes = new List<Orders>();
            Dishes.Add(new Orders { NameDish = "Борщ", СategoriesOfDishes = "Супы", NumberOfDishes = 3, OrderDate = new DateTime(2025, 11, 15) });
            Dishes.Add(new Orders { NameDish = "Солянка", СategoriesOfDishes = "Супы", NumberOfDishes = 5, OrderDate = new DateTime(2025, 11, 15) });
            Dishes.Add(new Orders { NameDish = "Цезарь", СategoriesOfDishes = "Салаты", NumberOfDishes = 6, OrderDate = new DateTime(2025, 11, 15) });
            Dishes.Add(new Orders { NameDish = "Оливье", СategoriesOfDishes = "Салаты", NumberOfDishes = 4, OrderDate = new DateTime(2025, 11, 15) });
            Dishes.Add(new Orders { NameDish = "Чизкейк", СategoriesOfDishes = "Десерты", NumberOfDishes = 4, OrderDate = new DateTime(2025, 11, 15) });
            Dishes.Add(new Orders { NameDish = "Синабон", СategoriesOfDishes = "Десерты", NumberOfDishes = 10, OrderDate = new DateTime(2025, 11, 15) });
            Dishes.Add(new Orders { NameDish = "Макароны", СategoriesOfDishes = "Гарниры", NumberOfDishes = 3, OrderDate = new DateTime(2025, 11, 15) });
            Dishes.Add(new Orders { NameDish = "Картошка", СategoriesOfDishes = "Гарниры", NumberOfDishes = 7, OrderDate = new DateTime(2025, 11, 15) });

            Console.WriteLine("Здравствуйте, введите категорию блюд, которая вас интересует (супы, салаты, десерты, гарниры): ");
            string Categories = Console.ReadLine();
            AnalyzeCategory(Dishes, Categories); // Вызывает метод и передача два параметра (список всех заказов, введеную пользователем категорию
        }
        static void AnalyzeCategory(List<Orders> dishes, string category)
        {
            // Фильтруем блюда по выбранной категории
            // Список заказов
            List<Orders> categoryDishes = dishes
                // Метод фильтрации, оставляет элементы, удовлетворяющие условия (d - каждый элемент списка)
                .Where(d => d.СategoriesOfDishes.Equals(category, StringComparison.OrdinalIgnoreCase))
                // Преобразование результатов обратно в список
                .ToList();
            if (categoryDishes.Count == 0)
            {
                Console.WriteLine($"К сожаленнию такой категории '{category}' нет.");
                return;
            }
            // Группируем список в порядке от самой востребованной к наименее популярной
            Dictionary<string, int> dishStats = new Dictionary<string, int>();
            // Заполняем словарь
            foreach (Orders order in categoryDishes)
            {
                if (dishStats.ContainsKey(order.NameDish))
                {
                    // Если блюдо уже есть в словаре - добавляем к существующему количеству
                    dishStats[order.NameDish] += order.NumberOfDishes;
                }
                else
                {
                    // Если блюда нет в словаре - добавляем новую запись
                    dishStats[order.NameDish] = order.NumberOfDishes;
                }
            }
            // Сортируем словарь по убыванию количества заказов
            List<KeyValuePair<string, int>> sortedDishStats = dishStats
                // Метод сортировки по убыванию
                .OrderByDescending(pair => pair.Value)
                // Преобразование результатов обратно в список
                .ToList();

            // Выводим результаты
            Console.WriteLine($"------- КАТЕГОРИЯ: {category} -------");
            Console.WriteLine("Список блюд от самой востребованной к наименее популярной:");
            for (int i = 0; i < sortedDishStats.Count; i++)
            {
                KeyValuePair<string, int> dish = sortedDishStats[i];
                Console.WriteLine($"{i + 1}. {dish.Key} - {dish.Value} заказов");
            }
            // Подсчитываем среднее число заказов по категории
            double averageOrders = sortedDishStats.Average(d => d.Value);
            Console.WriteLine($"Среднее число заказов по категории: {averageOrders}");
        }
    }
}
