using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClothesStore.HelperModels;
using ClothesStore.Models;

namespace ClothesStore.Forms
{
    public partial class SalesForm : Form
    {
        private DataStorage dataStorage_;
        private Receipt currentReceipt_;
        private Pokupatel currentPokupatel_;
        private Polzovatel currentPolzovatel_;
        public SalesForm()
        {
            InitializeComponent();
            dataStorage_ = new DataStorage("Host=localhost;Database=ClothesStoreDB;Username=postgres");
            dataStorage_.LoadClothing();
            dataStorage_.LoadCustomers();
        }
        public SalesForm(Polzovatel polzovatel) : this()
        {
            currentPolzovatel_ = polzovatel;
        }

        private void buttonSaveSale_Click(object sender, EventArgs e)
        {
            if (currentPokupatel_ == null)
            {
                MessageBox.Show("Сначала выберите покупателя");
                return;
            }
            if (currentReceipt_.items_.Count == 0)
            {
                MessageBox.Show("В чеке нет товаров");
                return;
            }
            currentReceipt_.id_client_ = currentPokupatel_.id_client_;
            currentReceipt_.sale_date_ = DateTime.Now;
            currentReceipt_.payment_method_ = comboBoxPayment.SelectedItem.ToString();
            currentReceipt_.id_user_ = currentPolzovatel_.IdUser;
            try
            {
                double discount = currentPokupatel_.CalculateDiscount();
                double finalTotal = currentReceipt_.total_amount_ * (1 - discount / 100.0);
                currentReceipt_.total_amount_ = finalTotal;
                dataStorage_.SaveReceipt(currentReceipt_);
                currentPokupatel_.addSum(finalTotal);
                dataStorage_.UpdateCustomer(currentPokupatel_);

                MessageBox.Show("Чек сохранен");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            buttonClear_Click(null, null);
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            comboBoxPayment.Items.Add("Наличные");
            comboBoxPayment.Items.Add("Карта");
            comboBoxPayment.Items.Add("Онлайн");
            comboBoxPayment.SelectedIndex = 0;

            labelCheckNumber.Text = "Чек № " + dataStorage_.GetNextReceiptId();
            labelDateTime.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
            labelPolzovatel.Text = "Кассир: " + currentPolzovatel_.Fio;
            currentReceipt_ = new Receipt(dataStorage_.GetNextReceiptId(), DateTime.Now, 0, new List<Clothing>(), new List<int>(), 0, comboBoxPayment.SelectedItem.ToString(), currentPolzovatel_.IdUser);
            foreach (var item in dataStorage_.ClothingList)
            {
                comboBoxTovars.Items.Add(item.name_);
            }
            RefreshGrid();
        }
        private void buttonFindCustomer_Click(object sender, EventArgs e)
        {
            string phone = maskedTextBoxPhone.Text;
            currentPokupatel_ = dataStorage_.FindCustomerByPhone(phone);
            if (currentPokupatel_ != null)
            {
                labelPokupatel.Text = "Покупатель: " + currentPokupatel_.phone_;
            }
            else
            {
                DialogResult result = MessageBox.Show("Покупатель не найден. Создать нового?", "Новый покупатель", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    AddPokupatelForm form = new AddPokupatelForm();
                    form.maskedTextBoxPhone.Text = phone;
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        dataStorage_.AddCustomer(form.ResultCustomer);
                        currentPokupatel_ = form.ResultCustomer;
                        labelPokupatel.Text = $"Покупатель: {currentPokupatel_.phone_}";
                    }
                }
            }
        }
        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            if (comboBoxTovars.SelectedItem == null)
            return;
            string name = comboBoxTovars.SelectedItem.ToString();
            Clothing clothing = dataStorage_.FindClothingByName(name);
            if (clothing == null)
            {
                MessageBox.Show("Товар не найден.");
                return;
            }
            currentReceipt_.AddItem(clothing);
            RefreshGrid();
        }
        private void RefreshGrid()
        {
            dataGridViewReceipt.Rows.Clear();
            for (int i = 0; i < currentReceipt_.items_.Count; i++)
            {
                dataGridViewReceipt.Rows.Add(
                    currentReceipt_.items_[i].name_,
                    currentReceipt_.items_[i].price_,
                    currentReceipt_.quantities_[i],
                    currentReceipt_.items_[i].price_ * currentReceipt_.quantities_[i]
                );
            }
            double total = currentReceipt_.total_amount_;

            if (currentPokupatel_ != null)
            {
                double discount = currentPokupatel_.CalculateDiscount();
                total = total * (1 - discount / 100.0);
            }
            labelTotal.Text = "Итого со скидкой: " + total + " руб.";
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            currentReceipt_ = new Receipt(dataStorage_.GetNextReceiptId(), DateTime.Now, 0, new List<Clothing>(), new List<int>(), 0, comboBoxPayment.SelectedItem.ToString(), currentPolzovatel_.IdUser);
            dataGridViewReceipt.Rows.Clear();
            labelPokupatel.Text = "";
            labelTotal.Text = "0";
            comboBoxTovars.Text = "";
        }
        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewReceipt.SelectedRows.Count == 0)
            return;
            int rowIndex = dataGridViewReceipt.SelectedRows[0].Index;
            currentReceipt_.items_.RemoveAt(rowIndex);
            currentReceipt_.quantities_.RemoveAt(rowIndex);
            currentReceipt_.CalculateTotal();
            RefreshGrid();
        }
    }
}
