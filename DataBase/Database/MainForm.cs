using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Database
{
    public partial class MainForm: Form
    {
        public PgUsersLoader loader = new PgUsersLoader();
        public MainForm()
        {
            InitializeComponent();
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            BindingList<User> user = loader.Load();
            dataGridView.DataSource = user;
            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView.SelectedRows[0];
            User user = row.DataBoundItem as User;
            loader.DeleteSelectedUser(user.Login);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Вы уверены, что вам нужно удалить всех пользователей?", "Внимание!!!", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
            {
                loader.ClearUsers();
            }
        }

        private void DobavlenieButton_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(loader);
            addForm.Show();
        }
    }
}
