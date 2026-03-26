using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Database
{
    public class PgUsersLoader
    {
        BindingList<User> allUser = new BindingList<User>();
        private const string connectSetting = "Host=192.168.1.48;Username=st50-2;Password=502;Database=Users_Students";
        public BindingList<User> Load()
        {
            try
            {
                var con = new NpgsqlConnection(connectSetting);

                con.Open();
                var sql = "SELECT login,password,lastname,name,phone,email FROM students";
                var cmd = new NpgsqlCommand(sql, con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    User user = new User
                    {
                        Login = reader.GetString(0),
                        Password = reader.GetString(1),
                        Last_Name = reader.GetString(2),
                        Name = reader.GetString(3),
                        Phone = reader.GetString(4),
                        Email = reader.GetString(5)
                    };
                    allUser.Add(user);
                }
                return allUser;
            }
            catch (NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return null;
            }
        }
        public bool DeleteSelectedUser(string Login)
        {
            try
            {
                bool allUsers = false;
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "DELETE FROM students WHERE login = @login";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@login", Login);
                int execute = cmd.ExecuteNonQuery();
                if (execute > 0)
                {
                    allUsers = true;
                }
                for (int i = 0; i < allUser.Count; i++)
                {
                    if (allUser[i].Login == Login)
                    {
                        allUser.RemoveAt(i);
                        i--;
                    }
                }
                return allUsers;
            }
            catch(NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return false;
            }
        }
        public bool ClearUsers()
        {
            bool User = false;
            var con = new NpgsqlConnection(connectSetting);
            var sql = "DELETE FROM students";
            con.Open();
            var cmd = new NpgsqlCommand(sql, con);
            int execute = cmd.ExecuteNonQuery();
            if(execute > 0)
            {
                User = true;
            }
            allUser.Clear();
            return User;
        }
        public bool AddUser(User user)
        {
            try
            {
                bool allUsers = false;
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "INSERT INTO students(login,password,lastname,name,phone,email) VALUES(@login,@password,@lastname,@name,@phone,@email)";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@login", user.Login);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@lastname", user.Last_Name);
                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("@phone", user.Phone);
                cmd.Parameters.AddWithValue("@email", user.Email);
                int execute = cmd.ExecuteNonQuery();
                if (execute > 0)
                {
                    allUsers = true;
                    allUser.Add(user);
                }
                return allUsers;
            }
            catch (NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return false;
            }
        }
    }
}
