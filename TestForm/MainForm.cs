using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm
{
    public partial class MainForm : Form
    {
        private FileUsersStorage AllLoginAndPassword = new FileUsersStorage();
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            List<User> check = AllLoginAndPassword.Load();
            string login = LoginСomboBox.Text;
            string password = PasswordTextBox.Text;
            User user = new User(login, password);
            if(Contains(check, user))
            {
                MessageBox.Show("Уроооо, ты смог зайти!!!");
            }
            else
            {
                MessageBox.Show("Оуууу ноу, не взламывай");
            }

        }
        private bool Contains(List<User> check, User user)
        {
            foreach (User u in check)
            {
                if (user.Login == u.Login && user.Password == u.Password)
                {
                    return true;
                }
            }
            return false;
        }

        private void LoginСomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedUser = LoginСomboBox.SelectedItem.ToString();
            List<User> userSelected = 
        }
    }
}