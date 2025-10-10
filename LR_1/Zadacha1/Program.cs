using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество чисел в массиве: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int EvenCount = 0;
            int OddCount = 0;
            Console.WriteLine($"Введите " + n + " целых чисел: ");
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] % 2 == 0)
                {
                    EvenCount++;
                }
                else
                {
                    OddCount++;
                }
            }
            Console.WriteLine($"Количество четных элементов: " + EvenCount);
            Console.WriteLine($"Количество нечетных элементов: " + OddCount);
        }
    }
}
