using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace TestFileStorage
{
    public class FileUsersStorage : IUsersInterface
    {
        //"D:\\П-30\\Repos_kuvaldaev\\TestFileStorage\\TestFileStorage.txt";
        //FileStream.Seek(2, SeekOrigin.Begin);
        public List<User> Load()
        {
            List<User> result = new List<User>();
            using (StreamReader reader = new StreamReader("D:\\П-30\\Repos_kuvaldaev\\TestFileStorage\\TestFileStorage.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] userInfo = line.Split('-');
                    User user = new User(userInfo[0], userInfo[1]);
                    result.Add(user);
                }
            }
            return result;
        }
    }
}
