using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyClasses1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product mers = new Product();
            mers.SetName("Мерседес");
            mers.SetPrice(1000000);

            Product yaz = new Product();
            yaz.SetName("Уазик");
            yaz.SetPrice(10000000);

            Storage storage = new Storage();
            storage.SetId(123);
            storage.SetLocation("Торжок, Ул. Студенческая 3");
            storage.SetProductQuantity(mers, 2);
            storage.SetProductQuantity(yaz, 5);

            storage.GetProductQuantity();
            storage.CalculateMoney();

            Console.WriteLine();

            Report report = new Report();

            ReportRow row1 = new ReportRow();
            row1.Product = "Mers";
            row1.Quantity = 500;
            row1.Price = 100;

            ReportRow row2 = new ReportRow();
            row2.Product = "Vaz";
            row2.Quantity = 100;
            row2.Price = 5192;

            Console.WriteLine("Содержимое отчета:");
            Console.WriteLine(report);
            report.CalculateSum();
        }
    }
}
