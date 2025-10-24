using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_1
{
    public class SearchingModule
    {
        public int FindIndexCategory(string userQuery, string[] category)
        {
            for(int index = 6; index < category.Length; ++ index)
            {
                if(category[index].ToLower() == userQuery.ToLower())
                {
                    return index;
                }
            }
            return -1;
        }
        public (List<string>, List<double>) FindAllProductsByCategory(int IndexCategory, List<string>[] AllProducts, List<double>[] price)
        {
            if (IndexCategory < 0 || IndexCategory >= AllProducts.Length)
            {
                return (new List<string>(), new List<double>());
            }
            List<string> productsByCategory = AllProducts[IndexCategory];
            List<double> priceByCategory = price[IndexCategory];
            return (productsByCategory, priceByCategory);
        }

        internal int FindIndexCategory(string userQuery, object category)
        {
            throw new NotImplementedException();
        }
    }
}
