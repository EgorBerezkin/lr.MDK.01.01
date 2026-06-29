using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClothesStore.Models;

namespace ClothesStore.HelperModels
{
    public class MenegerSales
    {
        public int currentCheckId_;
        public List<Clothing> items_;
        public List<int> quantities_;
        public Polzovatel currentCust_;
        public double totalAmount_;
        public DateTime saleDate_;

        public int CurrentCheckId
        {
            get { return currentCheckId_; }
        }
        public List<Clothing> Items
        {
            get { return items_; }
        }
        public Polzovatel CurrentCust
        {
            get { return currentCust_; }
        }
        public double TotalAmount
        {
            get { return totalAmount_; }
        }
        public DateTime SaleDate
        {
            get { return saleDate_; }
        }

        public MenegerSales(int currentCheckId, List<Clothing> items, List<int> quantities, Polzovatel currentCust, double totalAmount, DateTime saleDate)
        {
            currentCheckId_ = currentCheckId;
            items_ = items;
            quantities_ = quantities;
            currentCust_ = currentCust;
            totalAmount_ = totalAmount;
            saleDate_ = saleDate;
        }

        // методы класса
        //1.	создать новый чек – createNewCheck();
        public void CreateNewCheck()
        {
            items_.Clear();
            totalAmount_ = 0;
            saleDate_ = DateTime.Now;
            currentCust_ = null;
        }
        //2.	добавить товар в чек – addItem();
        public void AddItem(Clothing clothing)
        {
            if (clothing != null)
            {
                items_.Add(clothing);
                CalculateTotal();
            }
        }
        //3.	рассчитать итоговую сумму – calculateTotal();
        public void CalculateTotal()
        {
            totalAmount_ = 0;
            foreach (Clothing item in items_)
            {
                totalAmount_ += item.price_;
            }
        }
        //4.	сохранить чек – saveCheck().
        public Receipt SaveCheck(int id_client, string payment_method, int id_user)
        {
            Receipt newReceipt = new Receipt(
                currentCheckId_,
                saleDate_,
                id_client,
                new List<Clothing>(items_),
                new List<int>(quantities_),
                totalAmount_,
                payment_method,
                id_user); 
            currentCheckId_++;
            return newReceipt;
        }
    }
}
