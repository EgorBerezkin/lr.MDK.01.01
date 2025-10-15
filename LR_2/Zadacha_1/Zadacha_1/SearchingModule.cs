using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_1
{
    public class SearchingModule
    {
        public int FindIndexCategory(string userQuery, string[] categories)
        {
            for(int index = 0; index < categories.Length; ++ index)
            {
                string priceCategory = categories[index];
                if(priceCategory == userQuery)
                {
                    return index;
                }
            }
            return -1;
        }
        public (List<string>, List<double>) FindAllProductsByCategory(int IndexCategory, List<string>[] AllProducts, List<double>[] price)
        {
            List<string> productsByCategory = new List<string>();
            List<double> priceByCategory = new List<double>();
            productsByCategory = AllProducts[IndexCategory];
            priceByCategory = price[IndexCategory];
            return (productsByCategory, priceByCategory);
        }

    }
}
