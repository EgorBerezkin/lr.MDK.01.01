using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClothesStore.Models
{
    public class Pokupatel
    {
        public int id_client_;
        public string phone_;
        public double totalSum_;
        public int totalChecksCount_;
        public DateTime lastVisitDate_;

        public int IdClient
        {
            get { return id_client_; }
        }
        public string Phone
        {
            get { return phone_; }
        }
        public double TotalSum
        {
            get { return totalSum_; }
        }
        public int TotalCheksCount
        {
            get { return totalChecksCount_; }
        }
        public DateTime LastVisitDate
        {
            get { return lastVisitDate_; }
        }

        public Pokupatel(int id_client, string phone, double totalSum, int totalChecksCount, DateTime lastVisitDate)
        {
            id_client_ = id_client;
            phone_ = phone;
            totalSum_ = totalSum;
            totalChecksCount_ = totalChecksCount;
            lastVisitDate_ = lastVisitDate;
        }

        // методы класса
        // 1.	возвращает уникальный идентификатор покупателя – getId();
        public int GetIdPokupatel()
        {
            return IdClient;
        }
        // 2.	возвращает номер телефона покупателя – getPhone();
        public string GetPhone()
        {
            return Phone;
        }
        // 3.	возвращает общую сумму всех покупок – getTotalSum();
        public double GetTotalSum()
        {
            return TotalSum;
        }
        // 4.	добавляет информацию о новой покупке: увеличивает общую сумму, количество чеков, обновляет дату последнего визита – addSum().
        public void addSum(double amount)
        {
            if (amount <= 0) return;
            // Увеличиваем общую сумму покупок
            totalSum_ = totalSum_ + amount;
            // Увеличиваем количество чеков на 1
            totalChecksCount_ = totalChecksCount_ + 1;
            // Обновляем дату последнего визита на текущую
            lastVisitDate_ = DateTime.Now;
        }
        // Расчёт скидки
        public double CalculateDiscount()
        {
            double discount = 0;

            // По общей сумме покупок
            if (totalSum_ >= 30000)
            {
                discount += 5;
            }
            else if (totalSum_ >= 10000)
            {
                discount += 3;
            }
            // По количеству чеков
            if (totalChecksCount_ >= 20)
            {
                discount += 3;
            }
            else if (totalChecksCount_ >= 10)
            {
                discount += 2;
            }
            // По дате последнего визита
            int days = (DateTime.Now - lastVisitDate_).Days;
            if (days <= 7)
            {
                discount += 3;
            }
            else if (days <= 30)
            {
                discount += 2;
            }
            // Максимум 15%
            if (discount > 15)
            {
                discount = 15;
            }
            return discount;
        }
    }
}
