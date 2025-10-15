using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_1
{
    public class AnalysisDataModule
    {
        public void SortProducts(List<string> products, List<double> price)
        {
            for (int i = 0; i < price.Count; i++)
            {
                for(int j = 0; j < price.Count; j++)
                {
                    bool condition = price[i + 1] > price[j];
                    if (condition)
                    {
                        double temp_price = price[j];
                        price[j] = price[j + 1];
                        price[j + 1] = temp_price;

                        string temp_products = products[j];
                        products[j] = products[j + 1];
                        products[j + 1] = temp_products;
                    }
                }
            }
        }
        public double CalculateAverage(List<double> price)
        {
            double sum = 0.0;
            foreach(int p in  price)
            {
                sum += p;
            }
            return sum / price.Count;
        }
    }
}
