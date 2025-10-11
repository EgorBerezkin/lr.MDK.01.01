using System.Collections.Generic;


namespace Zadacha_1
{
    public class InputModule
    {
        public (List<string>[], List<double>[]) InputProductsByCategory()
        {
            List<string>[] productsByCategory = new List<string>[3];
            List<double>[] price = new List<double>[3];
            /// Заполнение товаров по категории крупа
            productsByCategory[0].Add("");
            price[0].AddRange(35,99);
        }
    }
}
