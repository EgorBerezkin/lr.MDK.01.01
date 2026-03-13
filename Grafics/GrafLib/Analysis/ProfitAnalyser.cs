using GrafLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace GrafLib.Analysis
{
    public class ProfitAnalyser
    {
        public static double CalculateProfitPercentByInventar(string inventarName, SalesModel model)
        {
            /// 1. Получить выручку товара (услуги, ....) itemName
            List<Sale> inventarSales = model.LoadSalesForInventar(inventarName);
            Inventar targetInventar = model.GetInventar(inventarName);
            if (targetInventar == null)
            {
                return 0.0;
            }
            double inventarTotal = inventarSales.Sum(sale => sale.Count * targetInventar.Price);

            /// 2. Получить общую выручку
            double total = model.GetTotalProfit();
            if (total == 0.0)
            {
                return 0.0;
            }

            return inventarTotal / total * 100.0;
        }
    }
}
