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

namespace ClothesStore.Forms
{
    public partial class AddPokupatelForm : Form
    {
        public Pokupatel ResultCustomer { get; private set; }
        private Pokupatel editingCustomer_;
        private bool isEditMode_;
        public AddPokupatelForm()
        {
            InitializeComponent();
        }
        public AddPokupatelForm(Pokupatel pokupatel)
        {
            InitializeComponent();
            isEditMode_ = true;
            editingCustomer_ = pokupatel;

            maskedTextBoxPhone.Text = pokupatel.phone_;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string phone = maskedTextBoxPhone.Text.Trim();
            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Введите номер телефона");
                return;
            }
            if (isEditMode_)
            {
                editingCustomer_.phone_ = phone;
                ResultCustomer = editingCustomer_;
            }
            else
            {
                ResultCustomer = new Pokupatel(0, phone, 0, 0, DateTime.Now);
            }
            DialogResult = DialogResult.OK;
            Close();
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
