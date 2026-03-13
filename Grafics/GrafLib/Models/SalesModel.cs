using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafLib.Models
{
    public class SalesModel
    {
        private Dictionary<Inventar, List<Sale>> salesByInventar_ =
            new Dictionary<Inventar, List<Sale>>();
        public void AddSales(Inventar inventar, List<Sale> sales)
        {
            if (salesByInventar_.ContainsKey(inventar))
            {
                salesByInventar_[inventar].AddRange(sales);
            }
            else
            {
                salesByInventar_.Add(inventar, sales);
            }
        }
        public List<Sale> LoadSalesForInventar(string inventarName)
        {
            List<Inventar> allInventar = salesByInventar_.Keys.ToList();
            Inventar targetInventar = allInventar.Find(inventar => inventar.Name == inventarName);
            if (targetInventar != null)
            {
                return salesByInventar_[targetInventar];
            }

            return new List<Sale>();
        }
        public bool Load()
        {
            AddSales(new Inventar { Name = "Ролики", Price = 1400 },
                new List<Sale>() {
                    new Sale {Time = new System.DateTime(2026, 7, 1), Count = 3 } ,
                    new Sale {Time = new System.DateTime(2026, 7, 2), Count = 5 },
                    new Sale {Time = new System.DateTime(2026, 7, 3), Count = 9 },
                    new Sale {Time = new System.DateTime(2026, 7, 4), Count = 6 },
                    new Sale {Time = new System.DateTime(2026, 7, 5), Count = 2 },
                    new Sale {Time = new System.DateTime(2026, 7, 6), Count = 15 },
                    new Sale {Time = new System.DateTime(2026, 7, 7), Count = 10 },
                });
            AddSales(new Inventar { Name = "Велосипед", Price = 2500 },
                new List<Sale>() {
                    new Sale {Time = new System.DateTime(2026, 7, 1), Count = 5 } ,
                    new Sale {Time = new System.DateTime(2026, 7, 2), Count = 3 },
                    new Sale {Time = new System.DateTime(2026, 7, 3), Count = 12 },
                    new Sale {Time = new System.DateTime(2026, 7, 4), Count = 6 },
                    new Sale {Time = new System.DateTime(2026, 7, 5), Count = 9 },
                    new Sale {Time = new System.DateTime(2026, 7, 6), Count = 11 },
                    new Sale {Time = new System.DateTime(2026, 7, 7), Count = 12 },
                });
            return true;
        }
        public List<Inventar> GetAllInventar()
        {
            return salesByInventar_.Keys.ToList();
        }

        public double GetTotalProfit()
        {
            double result = 0.0;
            foreach (KeyValuePair<Inventar, List<Sale>> keyValue in salesByInventar_)
            {
                Inventar item = keyValue.Key;
                result += keyValue.Value.Sum(sale => sale.Count * item.Price);
            }

            return result;
        }

        public Inventar GetInventar(string itemName)
        {
            foreach (KeyValuePair<Inventar, List<Sale>> keyValue in salesByInventar_)
            {
                Inventar item = keyValue.Key;
                if (item.Name == itemName)
                {
                    return item;
                }
            }

            return null;
        }
    }
}
