using ModelViewBiblioteka.Model_Views;
using ModelViewBiblioteka.View;
using ModelViewBiblioteka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelViewMyForms
{
        public class UsersTableView : DataGridView, IUserView
        {
            // Явная реализация интерфейса (то, что предложила VS)
            void IUserView.ShowUser(List<User> allUsers_)
            {
                DataSource = allUsers_;
            }

            // Ваш дополнительный метод с другим именем
            public void ShowUsers(List<User> allUsers_)
            {
                ShowUsers(allUsers_); // Вызов метода интерфейса
            }
        }
}
