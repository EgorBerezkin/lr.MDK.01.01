using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClothesStore.Forms;
using ClothesStore.HelperModels;
using ClothesStore.Models;

namespace ClothesStore
{
    public partial class MainForm : Form
    {
        private Polzovatel polzovatel_;
        private AuthManager authManager;
        private Form activeForm_;
        public MainForm(Polzovatel polzovatel)
        {
            InitializeComponent();
            polzovatel_ = polzovatel;
            authManager = new AuthManager();
            SetupInterfaceByRole();
            UpdatePolzovatelInfo();
        }
        // Метод для настройки видимости кнопок для каждой роли пользователя
        private void SetupInterfaceByRole()
        {
            // Проверяем роль пользователя
            if (polzovatel_.Roles == Polzovatel.Role.seller)
            {
                buttonTovars.Visible = false;
                buttonReports.Visible = false;
            }
            else // Роль = "Администратор"
            {
                buttonTovars.Visible = true;
                buttonReports.Visible = true;
            }
        }
        // Метод для обновления информации в верхней панели
        private void UpdatePolzovatelInfo()
        {
            lblUserInfo.Text = $"Пользователь:{polzovatel_.Fio}({polzovatel_.Roles})";
        }

        // Октрытие форм в panelContent
        private void OpenChildForm(Form childForm)
        {
            // Закрываем предыдущую форму
            if (activeForm_ != null)
            {
                activeForm_.Close();
            }

            // Настраиваем новую форму
            activeForm_ = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Добавляем в панель
            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void buttonPokupatel_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PokupatelForm());
        }
        private void buttonTovars_Click(object sender, EventArgs e)
        {
            if (polzovatel_.Roles != Polzovatel.Role.admin)
            {
                return;
            }
            OpenChildForm(new TovarForm());
        }

        private void buttonReports_Click(object sender, EventArgs e)
        {
            if (polzovatel_.Roles != Polzovatel.Role.admin)
            {
                return;
            }
            OpenChildForm(new ReportForm(polzovatel_));
        }

        private void buttonOut_Click(object sender, EventArgs e)
        {
            if (authManager != null)
            {
                authManager.Logout();
            }
            this.Close();
            // Показываем форму входа
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void buttonSale_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new SalesForm(polzovatel_));
        }
    }
}
