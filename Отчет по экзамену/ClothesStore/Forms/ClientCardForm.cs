using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClothesStore.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace ClothesStore.Forms
{
    public partial class ClientCardForm : Form
    {
        private Pokupatel pokupatel_;
        private Receipt lastReceipt_;
        public ClientCardForm(Pokupatel pokupatel, Receipt lastReceipt)
        {
            InitializeComponent();
            pokupatel_ = pokupatel;
            lastReceipt_ = lastReceipt;

            LoadCard();
        }
        private void LoadCard()
        {
            labelOpenDate.Text = "Дата открытия: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm");
            labelPhone.Text = "Клиент с: " + pokupatel_.Phone;
            labelKolvo.Text = "Количество покупок: " + pokupatel_.totalChecksCount_.ToString();
            labelTotalSum.Text = "Общая сумма покупок: " + pokupatel_.totalSum_.ToString("F2") + "руб.";

            double avgCheck = 0;
            if (pokupatel_.totalChecksCount_ > 0)
            {
                avgCheck = pokupatel_.totalSum_ / pokupatel_.totalChecksCount_;
            }
            labelAvgCheck.Text = "Средний чек: " + avgCheck.ToString("F2") + "руб.";

            labelDataVisita.Text = "Последний визит: " + pokupatel_.lastVisitDate_.ToString("dd.MM.yyyy");
            if (lastReceipt_ != null)
            {
                labelNumberChecka.Text = "Чек №" + lastReceipt_.id_check_.ToString();
                labelObchajaSumma.Text =  "Итого: " + lastReceipt_.total_amount_.ToString("F2") + "руб.";
                LoadItems();
            }
            else
            {
                labelNumberChecka.Text = "Нет чеков";
                labelObchajaSumma.Text = "0";
                dataGridViewReceiptItems.Rows.Clear();
            }
            double discount = pokupatel_.CalculateDiscount();
            labelDiscount.Text = "Персональная скидка: " + discount.ToString("F0") + "%";
        }
        private void LoadItems()
        {
            if (lastReceipt_ == null)
                return;

            if (lastReceipt_.items_ == null)
                return;

            if (lastReceipt_.quantities_ == null)
                return;

            dataGridViewReceiptItems.Rows.Clear();

            if (dataGridViewReceiptItems.Columns.Count == 0)
            {
                dataGridViewReceiptItems.Columns.Add("name", "Товар");
                dataGridViewReceiptItems.Columns.Add("qty", "Количество");
                dataGridViewReceiptItems.Columns.Add("price", "Цена");
                dataGridViewReceiptItems.Columns.Add("sum", "Сумма");
            }

            for (int i = 0; i < lastReceipt_.items_.Count; i++)
            {
                string name = lastReceipt_.items_[i].name_;
                int quantity = lastReceipt_.quantities_[i];
                double price = lastReceipt_.items_[i].price_;
                dataGridViewReceiptItems.Rows.Add(name, quantity, price, quantity * price);
            }

        }
        private void buttonZakrit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
