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
        PgUsersLoader loader_;

        public AddForm(PgUsersLoader loader)
        {
            InitializeComponent();
            loader_ = loader;
        }

        private void SozdatButton_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                Login = textBoxLogin.Text,
                Password = textBoxPassword.Text,
                LastName = textBoxLastname.Text,
                Name = textBoxName.Text,
                Phone = textBoxTelefon.Text,
                Email = textBoxEmail.Text,
            };
            loader_.AddUser(user);
            this.Close();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void OtmenaButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEdited_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                Password = textBoxPassword.Text,
                LastName = textBoxLastname.Text,
                Name = textBoxName.Text,
                Phone = textBoxTelefon.Text,
                Email = textBoxEmail.Text,
            };
            loader_.EditUser(user);
            this.Close();

        }
    }
}
