using System;
using System.Collections.Generic;


namespace Zadacha_1
{
    public class InputModule
    {
        public (List<string>[], List<double>[]) InputProductsByCategory()
        {
            List<string>[] productsByCategory = new List<string>[3];
            List<double>[] price = new List<double>[3];
            /// Заполнение товаров по категории крупа (нулевой индекс)
            productsByCategory[0].Add("Гречневая крупа");
            price[0].Add(120.50);
            productsByCategory[0].Add("Рисовая крупа");
            price[0].Add(85.70);
            productsByCategory[0].Add("Овсяная крупа");
            price[0].Add(60.20);
            productsByCategory[0].Add("Пшённая крупа");
            price[0].Add(75.30);
            productsByCategory[0].Add("Перловая крупа");
            price[0].Add(90.10);
            /// Заполнение товаров по категории овощи (первый индекс)
            productsByCategory[1].Add("Картофель");
            price[1].Add(35.90);
            productsByCategory[1].Add("Помидор");
            price[1].Add(159.50);
            productsByCategory[1].Add("Огурец");
            price[1].Add(89.70);
            productsByCategory[1].Add("Лук");
            price[1].Add(56.30);
            productsByCategory[1].Add("Морковь");
            price[1].Add(68.20);
            productsByCategory[1].Add("Тыква");
            price[1].Add(125.90);
            productsByCategory[1].Add("Кабачок");
            price[1].Add(102.50);
            /// Заполнение товаров по категории фрукты (второй индекс)
            productsByCategory[2].Add("Груша");
            price[2].Add(120.90);
            productsByCategory[2].Add("Яблоко");
            price[2].Add(105.50);
            productsByCategory[2].Add("Слива");
            price[2].Add(98.70);
            productsByCategory[2].Add("Персик");
            price[2].Add(150.20);
            productsByCategory[2].Add("Апельсин");
            price[2].Add(110.80);
            productsByCategory[2].Add("Лимон");
            price[2].Add(85.30);
            productsByCategory[2].Add("Ананас");
            price[2].Add(130.50);
            productsByCategory[2].Add("Банан");
            price[2].Add(75.10);
            productsByCategory[2].Add("Манго");
            price[2].Add(160.90);

            return (productsByCategory, price);
        }
        public string InputUserQuery()
        {
            Console.Write("Здравствуйте, введите категорию которая вас интересует (крупа/овощи/фрукты): ");
            return Console.ReadLine();
        }
    }
}
