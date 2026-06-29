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
    public partial class PokupatelForm : Form
    {
        private DataStorage dataStorage_;
        private string connectionString_ = "Host=localhost;Database=ClothesStoreDB;Username=postgres";
        public PokupatelForm()
        {
            InitializeComponent();
            dataStorage_ = new DataStorage(connectionString_);
        }
        private void PokupatelForm_Load(object sender, EventArgs e)
        {
            dataGridViewPokupatel.Columns.Clear();
            dataGridViewPokupatel.Columns.Add("id_client", "ID");
            dataGridViewPokupatel.Columns.Add("phone", "Телефон");
            dataGridViewPokupatel.Columns.Add("total_sum", "Общая сумма");
            dataGridViewPokupatel.Columns.Add("checks", "Количество чеков");
            dataGridViewPokupatel.Columns.Add("last_visit", "Последний визит");
            dataGridViewPokupatel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPokupatel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPokupatel.MultiSelect = false;
            dataGridViewPokupatel.ReadOnly = true;
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                dataStorage_.LoadCustomers();
                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RefreshGrid()
        {
            dataGridViewPokupatel.Rows.Clear();
            foreach (var p in dataStorage_.pokupatelList_)
            {
                dataGridViewPokupatel.Rows.Add(p.id_client_, p.phone_, p.totalSum_, p.totalChecksCount_, p.lastVisitDate_.ToString("dd.MM.yyyy"));
            }
        }

        private void buttonAddPokupatel_Click(object sender, EventArgs e)
        {
            AddPokupatelForm form = new AddPokupatelForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                dataStorage_.AddCustomer(form.ResultCustomer);
                LoadData();
                MessageBox.Show("Клиент добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void buttonDeletePokupatel_Click(object sender, EventArgs e)
        {
            if (dataGridViewPokupatel.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите клиента", "Предупреждение");
                return;
            }
            int id = (int)dataGridViewPokupatel
                .SelectedRows[0]
                .Cells["id_client"]
                .Value;

            DialogResult result = MessageBox.Show("Удалить клиента?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                dataStorage_.DeleteCustomer(id);
                LoadData();
                MessageBox.Show("Клиент удалён");
            }
        }

        private void buttonEditPokupatel_Click(object sender, EventArgs e)
        {
            if (dataGridViewPokupatel.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите клиента для редактирования");
                return;
            }

            int id = (int)dataGridViewPokupatel
                .SelectedRows[0]
                .Cells["id_client"]
                .Value;

            Pokupatel customer = dataStorage_.FindCustomerById(id);
            if (customer == null)
            return;
            AddPokupatelForm form = new AddPokupatelForm(customer);

            if (form.ShowDialog() == DialogResult.OK)
            {
                dataStorage_.UpdateCustomer(customer);
                LoadData();
                MessageBox.Show("Клиент обновлён", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonSavePokupatel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Все изменения уже сохранены в базе данных.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonKartochkaKlienta_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridViewPokupatel.SelectedRows[0].Cells["id_client"].Value;
            Pokupatel customer = dataStorage_.FindCustomerById(id);
            Receipt lastReceipt = dataStorage_.GetLastReceiptByClientId(id);
            ClientCardForm form = new ClientCardForm(customer, lastReceipt);
            form.ShowDialog();
        }
    }
}
