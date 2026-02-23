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

            // Загружаем пользователей при создании
            RefreshUsers();
        }

        private void RefreshUsers()
        {
            List<User> users = model_.LoadUser();
            views_.ShowUser(users);
        }

        public void RemoveUsers(List<User> users)
        {
            if (users != null && users.Count > 0)
            {
                model_.RemoveUsers(users);
                RefreshUsers(); // Обновляем отображение после удаления
            }
        }

        public void Add(User user)
        {
            if (user != null)
            {
                bool added = model_.AddUsers(user);
                if (added)
                {
                    RefreshUsers(); // Обновляем отображение после добавления
                }
            }
        }
    }
}
