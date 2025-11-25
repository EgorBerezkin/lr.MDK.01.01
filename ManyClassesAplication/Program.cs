using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyClassesAplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product Mers = new Product();
            Mers.SetName("Mersedez");
            Mers.SetPrice(10000000);

            Product VAS = new Product();
            VAS.SetName("VAS");
            VAS.SetPrice(1500000);

            Warehouse Avto = new Warehouse();
            Avto.SetIdentifier(123);
            Avto.SetLocate("Торжок, ул. Студенческая, д. 3");
            Avto.SetProductCount(Mers, 2);
            Avto.SetProductCount(VAS, 5);
        }
    }
}
