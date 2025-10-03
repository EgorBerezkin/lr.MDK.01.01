using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            string input = Console.ReadLine();
            input = input.Trim();
            bool isNumber = true;
            char[] numberSymbols = new char[13] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ' ', ',', '.' };
            for (int index = 0; index < input.Length; index++)
            {
                char symbol = input[index];
                if (numberSymbols.Contains(symbol))
                {
                    isNumber = true;
                }
                else
                {
                    isNumber = false;
                    index = input.Length;
                }
            }

            if (!isNumber)
            {
                Console.WriteLine("Введите пожалуйста, число");
                return;
            }
            string zapatay = input.Replace(",", ".").Replace(",", ".").Replace(" ", "");
            input = NewMethod(input);
            try
            {
                double number = double.Parse(zapatay, System.Globalization.CultureInfo.InvariantCulture);
                Console.WriteLine("Число" + number);
            }
            catch
            {
                Console.WriteLine("Ошибка");
            }
        }

        private static string NewMethod(string input)
        {
            return input.Replace(" ", "");
        }
    }
}
