using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TestFileStorage
{
    public class User
    {
        [DisplayName("Логин")]
        public string Login { get; set; }

        [DisplayName("Пароль")]
        public string Password { get; set; }

        //private string login_;
        //private string password_;


        //public User(string login, string password)
        //{
        //    login_ = login;
        //    password_ = password;
        //}

        //public string Login
        //{
        //    get { return login_; }
        //}

        //public string Password
        //{
        //    get { return password_; }
        //}

    }
}
