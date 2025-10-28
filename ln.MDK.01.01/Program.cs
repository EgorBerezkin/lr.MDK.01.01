using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ln.MDK._01._01
{
    internal class Program
    {
        /*
        static public Clothes MakeClothesByText(string text)
        {
            if (text == "Головные уборы")
            {
                return hats;
            }
            if (text == "Поясная одежда")
            {
                return waistwear;
            }
            if (text == "Плечевая одежда")
            {
                return shoulder_wear;
            }
        }
        */
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
            /// Вывод данных из ключа waistwear
            List<string> Waistwear = Clothes[waistwear];
            Console.Write("Поясная одежда в словаре: ");
            Console.WriteLine(string.Join(", ", Waistwear));
            /// Вывод данных из ключа hats shoulder_wear
            List<string> Should_wear = Clothes[shoulder_wear];
            Console.Write("Плечевая одежда в словаре: ");
            Console.WriteLine(string.Join(", ", Should_wear));


            Console.Write("Какой вид одежды вам нужен?");
            string text = Console.ReadLine();
            foreach(string clothes in Clothes.Keys)
            {
                if (text == hats)
                {
                    Console.WriteLine(string.Join(", ", Hats));
                }
                else
                {
                    if (text == waistwear)
                    {
                        Console.WriteLine(string.Join(", ", Waistwear));
                    }
                    else
                    {
                        if (text == shoulder_wear)
                        {
                            Console.WriteLine(string.Join(", ", Should_wear));
                        }
                    }
                }
            }
            /*
            if (text == hats)
            {
                Console.WriteLine(string.Join(", ", Hats));
            }
            else
            {
                if (text == waistwear)
                {
                    Console.WriteLine(string.Join(", ", Waistwear));
                }
                else
                {
                    if (text == shoulder_wear)
                    {
                        Console.WriteLine(string.Join(", ", Should_wear));
                    }
                }
            }
            */
        }
    }
}
