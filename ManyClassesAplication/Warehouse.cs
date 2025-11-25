using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyClassesAplication
{
    public class Warehouse
    {
        private int Identifier_;                    // Идентификатор
        private string Locate_;                     // Положение
        private Dictionary<Product, int> Product_;  // Товар

        public void SetIdentifier(int Identifier)
        {
            Identifier_ = Identifier;
        }
        public int GetIdentifier()
        {
            return Identifier_;
        }

        public void SetLocate(string Locate)
        {
            Locate_ = Locate;
        }
        public string GetLocate()
        {
            return Locate_;
        }

        public void SetProductCount(Product p, int c)
        {
            Product_.Add(p, c);
        }
    }
}
