using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFS_Console1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car avtomobil = new Car();
            avtomobil.SetModel("Lada");
            Console.WriteLine(avtomobil.GetModel());
        }
    }
}
