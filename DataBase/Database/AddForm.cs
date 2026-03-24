using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public partial class AddForm: Form
    {
        private User users_;
        public User users
        {
            get { return users_; }
        }

        public AddForm()
        {
            InitializeComponent();
        }

        private void SozdatButton_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text.Trim() != "" &&
                textBoxPassword.Text.Trim() != "" &&
                textBoxLastname.Text.Trim() != "" &&
                textBoxName.Text.Trim() != "" &&
                textBoxTelefon.Text.Trim() != "" &&
                textBoxEmail.Text.Trim() != "")
            {
                DialogResult = DialogResult.Yes;
                users_ = new User(textBoxLogin.Text, textBoxPassword.Text, textBoxLastname.Text, textBoxName.Text, textBoxTelefon.Text, textBoxEmail.Text);
            }
            else
            {
                MessageBox.Show("Введите корректные данные !!!");
                DialogResult = DialogResult.No;
            }
            Close();
        }
    }
}
