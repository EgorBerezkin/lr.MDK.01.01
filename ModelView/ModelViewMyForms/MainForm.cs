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
            usertable_ = new UsersTableView();
            Controls.Add(usertable_);
            usertable_.Dock = DockStyle.Top;
            presenter_ = new UserPresenter(new MemoryUserModel(), usertable_);
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

            // Показываем форму как диалог
            if (addUserForm.ShowDialog() == DialogResult.Yes) // Используем DialogResult.Yes, как в вашей форме
            {
                // Получаем созданного пользователя через свойство users
                User newUser = addUserForm.users;

                if (newUser != null)
                {
                    // Добавляем пользователя через presenter
                    presenter_.Add(newUser);

                    MessageBox.Show($"Пользователь {newUser.Name} успешно добавлен!",
                        "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            addUserForm.Dispose();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
