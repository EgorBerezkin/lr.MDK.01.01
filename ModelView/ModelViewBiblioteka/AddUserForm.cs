using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelViewBiblioteka.Model_Views;

namespace ModelViewBiblioteka
{
    public partial class AddUserForm : Form
    {
        private User users_;
        public User users
        {
            get { return users_; }
        }

        public AddUserForm()
        {
            InitializeComponent();
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            if (LoginTextBox.Text.Trim() != "" &&
                PasswordTextBox.Text.Trim() != "" &&
                NameTextBox.Text.Trim() != "")
            {
                DialogResult = DialogResult.Yes;
                users_ = new User(LoginTextBox.Text, PasswordTextBox.Text, NameTextBox.Text);
            }
            else
            {
                MessageBox.Show("Введите корректные данные !!! :)");
                DialogResult = DialogResult.No;
            }
            Close();
        }
    }
}
