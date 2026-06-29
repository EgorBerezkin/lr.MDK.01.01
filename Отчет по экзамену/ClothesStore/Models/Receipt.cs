using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClothesStore.Models
{
    public class Receipt
    {
        public int id_check_;
        public DateTime sale_date_;
        public int id_client_;
        public List<Clothing> items_;
        public List<int> quantities_;
        public double total_amount_;
        public string payment_method_;
        public int id_user_;

        public int Id_Check
        {
            get { return id_check_; }
        }
        public DateTime Sale_Date
        {
            get { return sale_date_; }
        }
        public int IdClient
        {
            get { return id_client_; }
        }
        public List<Clothing> Items
        {
            get { return items_; }
        }
        public List<int> Quantities
        {
            get { return quantities_; }
        }
        public double TotalAmount
        {
            get { return total_amount_; }
        }
        public string PaymentMethod
        {
            get { return payment_method_; }
        }
        public int IdUser
        {
            get { return id_user_; }
        }

        public Receipt(int id_check, DateTime sale_date, int id_client, List<Clothing> items, List<int> quantities,double total_amount, string payment_method, int id_user)
        {
            id_check_ = id_check;
            sale_date_ = sale_date;
            id_client_ = id_client;
            quantities_ = quantities;
            items_ = items;
            total_amount_ = total_amount;
            payment_method_ = payment_method;
            id_user_ = id_user;
        }

        // методы класса
        //1.	добавление товара в чек – addItem();
        public void AddItem(Clothing clothing)
        {
            int index = items_.FindIndex(c => c.IdClothing == clothing.IdClothing);

            if (index >= 0)
            {
                quantities_[index]++;
            }
            else
            {
                items_.Add(clothing);
                quantities_.Add(1);
            }
            CalculateTotal();
        }
        //2.	удаление товара из чека – removeItem();
        public void RemoveItem(int clothingId)
        {
            Clothing itemToRemove = items_.FirstOrDefault(c => c.id_clothing_ == clothingId);
            if (itemToRemove != null)
            {
                items_.Remove(itemToRemove);
                CalculateTotal();
            }
        }
        //3.	расчёт итоговой суммы – calculateTotal();
        public void CalculateTotal()
        {
            total_amount_ = 0;
            for (int i = 0; i < Math.Min(items_.Count, quantities_.Count); i++)
            {
                total_amount_ += items_[i].price_ * quantities_[i];
            }
        }
        //4.	сохранение чека в реестр – save();
        public Receipt Clone()
        {
            Receipt savedReceipt = new Receipt(id_check_, sale_date_, id_client_, new List<Clothing>(items_), new List<int>(quantities_),total_amount_, payment_method_, id_user_);
            return savedReceipt;
        }
    }
}
