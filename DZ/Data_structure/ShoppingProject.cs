using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structure
{
    public class ShoppingProject
    {
        public string Name { get; set; }    // get метод для получения значения свойства
                                            // set метод для установки значения свойства
        public int ItemCount { get; set; }
        public int ShoppingTime { get; set; }
        public decimal Budget { get; set; }
        public ShoppingProject(string name, int itemCount, int shoppingTime, decimal budget)
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
