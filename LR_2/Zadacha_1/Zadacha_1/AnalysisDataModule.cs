using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_1
{
    public class AnalysisDataModule
    {
        public void SortProducts(List<string> products, List<double> price)
        {
            /// Сортировка от дорогих к дешевым
            for (int i = 0; i < price.Count - 1; i++)
            {
                for(int j = 0; j < price.Count - i; j++)
                {
                    if (price[j] < price[j + 1])
                    {
                        /// Меняем местами цены
                        double tempPrice = price[j];
                        price[j] = price[j + 1];
                        price[j + 1] = tempPrice;

                        /// Меняем местами названия товаров
                        string tempProduct = products[j];
                        products[j] = products[j + 1];
                        products[j + 1] = tempProduct;
                    }
                }
            }
        }
        public double CalculateAverage(List<double> price)
        {
            if (price == null || price.Count == 0)
                return 0.0;
            double sum = 0.0;
            foreach(int p in  price)
            {
                sum += p;
            }
            return sum / price.Count;
        }
    }
}
