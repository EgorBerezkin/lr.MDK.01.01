using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_1
{
    class Program
    {
        static void Print(List<string> products, List<double> price)
        {
            if (products == null || products.Count == 0)
            {
                Console.WriteLine("Товары не найдены!");
                return;
            }

            Console.WriteLine("\nСписок товаров от дорогих к дешевым:");
            Console.WriteLine("=====================================");

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {products[i]} - {price[i]:F2} руб.");
            }
        }
        static void Main()
        {
            string[] category = new string[] { "крупы", "овощи", "фрукты" };
            /// Создаем экземпляры модулей
            InputModule InputModule = new InputModule();
            SearchingModule SearchingModule = new SearchingModule();
            AnalysisDataModule AnalysisModule = new AnalysisDataModule();

            try
            {
                /// Получаем данные о товарах
                var (products, price) = InputModule.InputProductsByCategory();

                /// Получаем запрос пользователя
                string userQuery = InputModule.InputUserQuery();

                /// Ищем индекс категории
                int IndexCategory = SearchingModule.FindIndexCategory(userQuery, category);

                if (IndexCategory == -1)
                {
                    Console.WriteLine("Категория не найдена! Доступные категории: крупы, овощи, фрукты");
                    return;
                }

                /// Получаем товары выбранной категории
                var (productsByCategory, priceByCategory) = SearchingModule.FindAllProductsByCategory(IndexCategory, products, price);

                /// Сортируем товары по убыванию цены
                AnalysisModule.SortProducts(productsByCategory, priceByCategory);

                /// Выводим результат
                Console.WriteLine($"\nКатегория: {category[IndexCategory]}");
                double tempPrice = AnalysisModule.CalculateAverage(priceByCategory);
                Console.WriteLine($"Средняя цена по категории: {tempPrice:F2} руб.");

                Print(productsByCategory, priceByCategory);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
