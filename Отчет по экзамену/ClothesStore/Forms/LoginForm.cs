using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClothesStore.HelperModels;
using ClothesStore.Models;

namespace ClothesStore.Forms
{
    public partial class LoginForm : Form
    {
        private AuthManager authManager;
        public LoginForm()
        {
            InitializeComponent();
            authManager = new AuthManager();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // Получаем введённые данные
            string login = textBoxLogin.Text.Trim();
            string password = textBoxPassword.Text;
            // Проверка на пустые поля
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин и пароль для входа в систему.");
                textBoxPassword.Clear();
                textBoxPassword.Focus();
                return;
            }
            // Проверка блокировки
            if (authManager.IsBlocked())
            {
                MessageBox.Show("Доступ заблокирован на 5 минут.");
                return;
            }
            // Аутентификация
            if (authManager.Authenticate(login, password))
            {
                // Успешный вход - передаём Polzovatel в MainForm
                Polzovatel currentUser = authManager.GetCurrentUser();
                MainForm mainForm = new MainForm(currentUser);  // используем конструктор с Polzovatel
                mainForm.Show();
                this.Hide();
            }
            else
            {
                // Неудачная попытка
                int remaining = 3 - authManager.failedAttempts_;
                if (remaining > 0)
                {
                    MessageBox.Show($"Неверный пароль. У вас осталось {remaining} попыток.");
                }
                else
                {
                    MessageBox.Show("Неверный пароль. Доступ блокирован на 5 минут.");
                }
                textBoxPassword.Clear();
                textBoxPassword.Focus();
            }
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти из программы?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
