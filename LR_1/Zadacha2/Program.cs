using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[3000];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(10, 10000);
            }
            Console.WriteLine("Исходные данные: ");
            Console.WriteLine("[" + string.Join(", ", array) + "]");
            List<int> Summa = new List<int>();
            for (int i = 0;i < array.Length - 2;i+=2)
            {
                int sum = array[i] + array[i+2];
                Summa.Add(sum);
            }
            Console.WriteLine("Результат: ");
            Console.WriteLine("[" + string.Join(", ", Summa) + "]");
        }
    }
}
