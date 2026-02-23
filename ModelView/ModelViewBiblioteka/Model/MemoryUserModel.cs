using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelViewBiblioteka.Model_Views;

namespace ModelViewBiblioteka.Model
{
    public class MemoryUserModel : IUsersModel
    {
        private List<User> allUsers_ = new List<User>();

        public MemoryUserModel()
        {
            // Инициализация тестовыми данными
            allUsers_.Add(new User("sabrina", "2221", "Sabrina Carpenter"));
            allUsers_.Add(new User("taylor", "1986", "Taylor Swift"));
            allUsers_.Add(new User("charlie", "2736", "Charli XCX"));
            allUsers_.Add(new User("adele", "9887", "Adele Castillon"));
        }

        public List<User> LoadUser()
        {
            return allUsers_;
        }

        public bool Registration(User user)
        {
            // Проверяем, существует ли пользователь с таким логином
            if (allUsers_.Any(u => u.Login == user.Login))
            {
                return false;
            }

            allUsers_.Add(user);
            return true;
        }

        public void RemoveUsers(List<User> users)
        {
            foreach (User user in users)
            {
                // Ищем пользователя по логину
                User userToRemove = allUsers_.FirstOrDefault(u => u.Login == user.Login);
                if (userToRemove != null)
                {
                    allUsers_.Remove(userToRemove);
                }
            }
        }

        public bool AddUsers(User user)
        {
            // Проверяем, существует ли уже пользователь с таким логином
            if (allUsers_.Any(u => u.Login == user.Login))
            {
                MessageBox.Show("Пользователь с таким логином уже существует!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            allUsers_.Add(user);
            return true;
        }
    }
}
