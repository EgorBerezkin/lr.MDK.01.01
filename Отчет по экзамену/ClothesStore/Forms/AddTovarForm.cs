using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ClothesStore.Models;

namespace ClothesStore.Forms
{
    public partial class AddTovarForm : Form
    {
        public Clothing ResultTovars { get; private set; }
        private Clothing editingTovars_;
        private bool isEditMode_;

        public AddTovarForm()
        {
            InitializeComponent();  
            isEditMode_ = false;
        }
        public AddTovarForm(Clothing tovars)
        {
            InitializeComponent();
            isEditMode_ = true;
            editingTovars_ = tovars;

            textBoxName.Text = tovars.name_;
            comboBoxCategory.Text = tovars.category_;
            textBoxCounteragent.Text = tovars.counteragent_;
            numericUpDownChena.Value = (int)tovars.price_;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Проверка всех полей
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Введите наименование товара", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(comboBoxCategory.Text))
            {
                MessageBox.Show("Введите категорию товара", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxCategory.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxCounteragent.Text))
            {
                MessageBox.Show("Введите поставщика", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCounteragent.Focus();
                return;
            }

            if (numericUpDownChena.Value <= 0)
            {
                MessageBox.Show("Цена должна быть больше 0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numericUpDownChena.Focus();
                return;
            }

            double price = (double)numericUpDownChena.Value;
            if (isEditMode_ && editingTovars_ != null)
            {
                // Редактирование существующего товара
                editingTovars_.name_ = textBoxName.Text.Trim();
                editingTovars_.category_ = comboBoxCategory.Text.Trim();
                editingTovars_.counteragent_ = textBoxCounteragent.Text.Trim();
                editingTovars_.price_ = price;
                ResultTovars = editingTovars_;
            }
            else
            {
                // Создание нового товара (ID будет присвоен при сохранении в БД)
                ResultTovars = new Clothing(0, textBoxName.Text.Trim(), comboBoxCategory.Text.Trim(), textBoxCounteragent.Text.Trim(), price);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void AddTovarForm_Load(object sender, EventArgs e)
        {
            comboBoxCategory.Items.Add("Верхняя одежда");
            comboBoxCategory.Items.Add("Платья и костюмы");
            comboBoxCategory.Items.Add("Обувь");
            comboBoxCategory.Items.Add("Аксессуары");
            comboBoxCategory.Items.Add("Нижнее белье");
            comboBoxCategory.Items.Add("Пижамы");
            comboBoxCategory.Items.Add("Одежда для нижней части тела");

            comboBoxCategory.SelectedIndex = 0;
        }
    }
}
