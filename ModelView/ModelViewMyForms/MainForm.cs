using ModelViewBiblioteka;
using ModelViewBiblioteka.Model;
using ModelViewBiblioteka.Model_Views;
using ModelViewBiblioteka.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelViewMyForms
{
    public partial class MainForm: Form
    {
        private UserPresenter presenter_;
        UsersTableView usertable_;
        public MainForm()
        {
            InitializeComponent();
            UsersTableView usertable = new UsersTableView();
            Controls.Add(usertable);
            usertable.Dock = DockStyle.Top;

            UserPresenter presenter_ = new UserPresenter(new MemoryUserModel(), usertable);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void ToolStripButtonDelete_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите удалить пользователя?", "Внимание!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                List<User> selectetUsers = usertable_.GetSelectedUsers();
                presenter_.RemoveUsers(selectetUsers);
            }
        }

        private void ToolStripButtonAdd_Click_1(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            if(addUserForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("...");
            }
            addUserForm.Dispose();
        }
    }
}
