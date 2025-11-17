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

            Console.WriteLine("Здравствуйте, введите категорию блюд, которая вас интересует" +
                          "(супы, салаты, десерты, гарниры): ");
            string Categories = Console.ReadLine();

        }
    }
}
