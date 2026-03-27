using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class User : INotifyPropertyChanged
    {
        //[DisplayName("Логин")]
        //public string Login { get; set; }

        //[DisplayName("Пароль")]
        //public string Password { get; set; }

        //[DisplayName("Фамилия")]
        //public string Last_Name { get; set; }

        //[DisplayName("Имя")]
        //public string Name { get; set; }

        //[DisplayName("Телефон")]
        //public string Phone { get; set; }

        //[DisplayName("Почта")]
        //public string Email { get; set; }

        private string login;
        private string password;
        private string lastname;
        private string name;
        private string phone;
        private string email;

        public string Login
        {
            get { return login; }
            set
            {
                if (login != value)
                {
                    login = value;
                    OnPropertyChanged("Логин");
                }
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                if (password != value)
                {
                    password = value;
                    OnPropertyChanged("Пароль");
                }
            }
        }

        public string LastName
        {
            get { return lastname; }
            set
            {
                if (lastname != value)
                {
                    lastname = value;
                    OnPropertyChanged("Фамилия");
                }
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged("Имя");
                }
            }
        }

        public string Phone
        {
            get { return phone; }
            set
            {
                if (phone != value)
                {
                    phone = value;
                    OnPropertyChanged("Телефон");
                }
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (email != value)
                {
                    email = value;
                    OnPropertyChanged("Электронная почта");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
