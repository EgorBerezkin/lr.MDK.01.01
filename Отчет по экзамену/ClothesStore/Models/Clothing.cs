using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClothesStore.Models
{
    public class Clothing
    {
        public int id_clothing_;
        public string name_;
        public string category_;
        public string counteragent_;
        public double price_;

        public int IdClothing
        {
            get { return id_clothing_; }
        }
        public string Name
        {
            get { return name_; }
        }
        public string Category
        {
            get { return category_; }
        }
        public string Counteragent
        {
            get { return counteragent_; }
        }
        public double Price
        {
            get { return price_; }
        }

        public Clothing(int id_clothing, string name, string category, string counteragent, double price)
        {
            id_clothing_ = id_clothing;
            name_ = name;
            category_ = category;
            counteragent_ = counteragent;
            price_ = price;
        }

        // методы класса
        // 1.	возвращает уникальный идентификатор товара – getid();
        public int GetIdClothing()
        {
            return IdClothing;
        }
        // 2.	возвращает наименование товара – getName();
        public string GetName()
        {
            return Name;
        }
        // 3.	возвращает цену за единицу товара – getPrice();
        public double GetPrice()
        {
            return Price;
        }
        // 4.	проверка корректности полей – validate().
        public bool Validate()
        {
            return !string.IsNullOrWhiteSpace(Name) && !string.IsNullOrWhiteSpace(Category) && !string.IsNullOrWhiteSpace(Counteragent) && Price > 0;
        }
        // Проверка уникальности комбинации Наименование + Поставщик
        public string GetUniqueKey()
        {
            return $"{name_?.ToLower()}|{counteragent_?.ToLower()}";
        }
        
    }
}