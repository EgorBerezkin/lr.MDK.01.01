using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_1
{
    class Program
    {
        static void Print(List<string> products)
        {
            Console.WriteLine(String.Join(", ", products));
        }
        static void Main()
        {
            string[] category = new string[] { "Крупы", "Овощи", "Фрукты" };
            var (products, price) = InputModule.InputProductsByCategory();

            string userQuery = InputModule.InputUserQuery();
            int IndexCategory = SearchingModule.FindIndexCategory(userQuery, category);
            var (priceCategory, priceByCategory) = SearchingModule.FindIndexCategory(IndexCategory, products, price);

            AnalysisDataModule.SortProducts(productsByCategory, priceByCategory);
            Print(productsByCategory);
        }
    }
}
