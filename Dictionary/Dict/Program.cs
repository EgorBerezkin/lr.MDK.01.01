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

            Console.Write(string.Join(",", Clothes.Keys);
        }
    }
}
