using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structure
{
    public struct ShoppingProject
    {
        public string Name;
        public int ItemCount;
        public int ShoppingTime;
        public double Budget;
        public ShoppingProject(string name, int itemCount, int shoppingTime, double budget)
        {
            Name = name;
            ItemCount = itemCount;
            ShoppingTime = shoppingTime;
            Budget = budget;
        }
        public override string ToString() // Объявление метода
        {
            // Возвращает строку с форматированными данными объекта
            return $"{Name} | Предметов: {ItemCount},  Время: {ShoppingTime} мин,  Бюджет: {Budget} руб";
        }
    }
}
