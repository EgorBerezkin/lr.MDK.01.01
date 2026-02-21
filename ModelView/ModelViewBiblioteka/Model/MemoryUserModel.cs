using ModelViewBiblioteka.Model_Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewBiblioteka.Model
{
    public class MemoryUserModel : IUsersModel
    {
        private List<User> allUsers_ = new List<User>();
        public MemoryUserModel()
        {
            allUsers_.Add(new User("2345", "2221", "Sabrina Carpenter"));
            allUsers_.Add(new User("2536", "1986", "Taylor Swift"));
            allUsers_.Add(new User("3568", "2736", "Charli XCX"));
            allUsers_.Add(new User("2837", "9887", "Adele Castillon"));
        }
        public List<User> LoadUser()
        {
            return allUsers_;
        }
        public bool Register(User user)
        {
            int count = allUsers_.Count;
            allUsers_.Add(user);
            if (allUsers_.Count > count)
            {
                return true;
            }
            return false;
        }

        public bool Registration(User user)
        {
            throw new NotImplementedException();
        }

        public void RemoveUsers(List<User> users)
        {
            foreach (User user in users)
            {
                int targeIndex = allUsers_.FindIndex(local => local.Login == user.Login);
                if (targeIndex >= 0)
                {
                    allUsers_.RemoveAt(targeIndex);
                }
            }
        }
        public bool AddUsers(User u)
        {
            allUsers_.Add(u);
            return true;
        }
    }
}
