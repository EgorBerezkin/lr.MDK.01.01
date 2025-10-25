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
            Dictionary<string, List<string>> Clothes = new Dictionary<string, List<string>> ();
            string hats = "Головные уборы";
            Words.Add(hats, new List<string>() {"Шляпа", "Бейсболка", "Шапка" });
            string waistwear = "Поясная одежда";
            Words.Add(waistwear, new List<string>() { "Джинсы", "Штаны", "Юбка" });
            string shoulder_wear = "Плечевая одежда";
            Words.Add(shoulder_wear, new List<string>() { "Свитер", "Топик", "Футболка" });

        }
    }
}
