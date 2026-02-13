using ModelViewBiblioteka.Model;
using ModelViewBiblioteka.Model_Views;
using ModelViewBiblioteka.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewBiblioteka.Presenter
{
    public class UserPresenter
    {
        private IUsersModel model_;
        private IUserView views_;

        public UserPresenter(IUsersModel model, IUserView views)
        {
            model_ = model;
            views_ = views;

            List<User> users_ = model.Load();
            views_.ShowUser(users_);
        }
    }
}
