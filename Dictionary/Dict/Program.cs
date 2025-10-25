using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dict
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Создал пустой словарь
            Dictionary<string, List<string>> Clothes = new Dictionary<string, List<string>> ();
            /// Создал в словаре ключи и заполнил их
            string hats = "Головные уборы";
            Words.Add(hats, new List<string>() {"Шляпа", "Бейсболка", "Шапка" });
            string waistwear = "Поясная одежда";
            Words.Add(waistwear, new List<string>() { "Джинсы", "Штаны", "Юбка" });
            string shoulder_wear = "Плечевая одежда";
            Words.Add(shoulder_wear, new List<string>() { "Свитер", "Топик", "Футболка" });
            /// Вывод списка ключей словаря
            Console.WriteLine("Ключи в словаре: ")
            Console.Write(string.Join(", ", Clothes.Keys);
            /// Вывод данных из ключа hats
            List<string> Hats = Clothes.[hats];
            Console.WriteLine("Головыне уборы в словаре: ");
            Console.Write(string.Join(", ", Hats);





        }
    }
}
