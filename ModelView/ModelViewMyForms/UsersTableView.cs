using ModelViewBiblioteka.Model_Views;
using ModelViewBiblioteka.View;
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
        public void ShowUsers(List<User> allUsers_)
        {
            DataSource = allUsers_;
        }

        void IUserView.ShowUser(List<User> allUsers_)
        {
            throw new NotImplementedException();
        }
    }
}
