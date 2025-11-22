using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NFS_Console1
{
    internal class Program
    {
        // Функция
        static void PrintModel(Car avtomobil)
        {
            Console.WriteLine(avtomobil.GetModel());
        }
        static void LadaVsMersedez(List<Car> avtomobili)
        {
            int t = 1;
            while (true)
            {
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
                foreach (Car avtomobil in avtomobili)
                {
                    int move = (avtomobil.GetSpeed() / 50 * t);
                    for(int i = 1; i < move; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(avtomobil.GetModel());
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
                }
                t++;
                Thread.Sleep(2000);
                Console.Clear();
            }
            foreach (Car avtomobil in avtomobili)
            {
                Console.WriteLine(avtomobil.GetSpeed());
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            // первый автомобиль
            Car avtomobil = new Car();
            avtomobil.SetModel("Lada(^>*<^)");
            avtomobil.SetSpeed(150);
            // Console.WriteLine(avtomobil.GetModel() + " " + avtomobil.GetSpeed() + " км");
            PrintModel(avtomobil);
            // второй автомобиль
            Car avtomobil1 = new Car();
            avtomobil1.SetModel("Mersedez");
            avtomobil1.SetSpeed(300);
            // Console.WriteLine(avtomobil1.GetModel() + " " + avtomobil1.GetSpeed() + " км");
            PrintModel(avtomobil1);

            List<Car> avtomobili = new List<Car>();
            avtomobili.Add(avtomobil);
            avtomobili.Add(avtomobil1);
        }
    }
}
