using ModelViewBiblioteka.Model_Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewBiblioteka.Model
{
    interface IUsersModel
    {
        List<User> Load();
        bool Register(User user);
    }
}
