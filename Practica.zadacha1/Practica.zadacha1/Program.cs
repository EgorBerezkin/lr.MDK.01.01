using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.zadacha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вариант 5
            // Задание 1
            Console.WriteLine("Введите количество чисел в массиве: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Введите элементы массива: ");
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            /*
            if (array[i]%2==0)
            {
                array[i] = 1;
                int sum1 = 0;
                int sum = 0;
                sum1 = (array[i] + 1;
                sum = n - sum1;
                Console.WriteLine("Количество четных чисел:   " + sum1);
                Console.WriteLine("Количество нечетных чисел: " + sum);
            }
            */
            for (int i = 0; i < array.Length; i++)
            {
                int sum1 = 0;
                int sum = 0;
                if (array[i] % 2 == 0)
                {
                    Console.WriteLine("Четные числа:   " + array[i]);
                    array[i] = 1;
                    sum1 = array[i];
                    Console.WriteLine("Количество четных чисел:   " + sum1);
                }
                else
                {
                    Console.WriteLine("Нечетные числа: " + array[i]);
                    array[i] = 1;
                    sum = n - sum1;
                    Console.WriteLine("Количество нечетных чисел: " + sum);
                }
            }
        }
    }
}
