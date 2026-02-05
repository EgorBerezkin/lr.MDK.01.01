using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForm
{
    public class FileUsersStorage : IUsersInterface
    {
        public List<User> Load()
        {
            List<User> allers = new List<User>();
            string patch = "LoginAndPassword.txt";
            StreamReader reader = new StreamReader(patch);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] lines = line.Split('-');
                allers.Add(new User(lines[0], lines[1]));
            }
            return allers;
        }

    }
}
