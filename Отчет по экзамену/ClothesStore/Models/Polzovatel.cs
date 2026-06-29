using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesStore.Models
{
    public class Polzovatel
    {
        public int id_user_;
        public string login_;
        public string password_;
        public enum Role {admin, seller}
        public Role role_;
        public string fio_;

        public int IdUser
        {
            get { return id_user_; }
        }
        public string Login
        {
            get { return login_; }
        }
        public string Password
        {
            get { return password_; }
        }
        public Role Roles
        {
            get { return role_; }
        }
        public string Fio
        {
            get { return fio_; }
        }

        public Polzovatel(int id_user, string login, string password, Role role, string fio)
        {
            id_user_ = id_user;
            login_ = login;
            password_ = password;
            role_ = role;
            fio_ = fio;
        }

        // методы класса
        //1.	аутентификация(проверка пароля);
        public bool Authenticate(string password)
        {
            return password_ == password;
        }
        //2.	проверка прав доступа – hasRole();
        public bool HasRole(Role role)
        {
            return role_ == role;
        }
        //3.	смена пароля – changePassword().
        public void ChangePassword(string newPassword)
        {
            password_ = newPassword;
        }
        public override string ToString()
        {
            return $"{Fio}({Roles})";
        }
    }
}
