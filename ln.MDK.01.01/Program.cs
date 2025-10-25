using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ln.MDK._01._01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// Создал пустой словарь
            Dictionary<string, List<string>> Clothes = new Dictionary<string, List<string>>();
            /// Создал в словаре ключи и заполнил их
            string hats = "Головные уборы";
            Clothes.Add(hats, new List<string>() { "Шляпа", "Бейсболка", "Шапка" });
            string waistwear = "Поясная одежда";
            Clothes.Add(waistwear, new List<string>() { "Джинсы", "Штаны", "Юбка" });
            string shoulder_wear = "Плечевая одежда";
            Clothes.Add(shoulder_wear, new List<string>() { "Свитер", "Топик", "Футболка" });
            /// Вывод списка ключей словаря
            Console.Write("Ключи в словаре: ");
            Console.WriteLine(string.Join(", ", Clothes.Keys));
            /// Вывод данных из ключа hats
            List<string> Hats = Clothes[hats];
            Console.Write("Головные уборы в словаре: ");
            Console.WriteLine(string.Join(", ", Hats));
        }
    }
}
