using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyClassesAplication
{
    public class Product
    {
        private string NameProduct_;
        private double Price_;

        public void SetName(string NameProduct)
        {
            NameProduct_ = NameProduct;
        }
        public string GetName()
        {
            return NameProduct_;
        }

        public void SetPrice(double Price)
        {
            Price_ = Price;
        }
        public double GetPrice()
        {
            return Price_;
        }
    }
}
