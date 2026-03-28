using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace TestFileStorage
{
    class PgUsersStorage : IUsersInterface
    {
        private const string connectSetting = "Host=192.168.1.48;Username=st50-2;Password=502;Database=Users_Students";

        public List<User> Load()
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
                    };
                }
                return null;
            }
            catch (NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return null;
            }
        }

        public bool UserRegistration(User us)
        {
            try
            {
                bool result = false;
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "INSERT INTO students(login,password) VALUES(@login,@password)";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@login", us.Login);
                cmd.Parameters.AddWithValue("@password", us.Password);
                int execute = cmd.ExecuteNonQuery();
                if (execute > 0)
                {
                    result = true;
                }
                return result;
            }
            catch (NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return false;
            }

        }

        public bool UserVerification(string login)
        {
            bool result = false;
            var con = new NpgsqlConnection(connectSetting);
            con.Open();
            var sql = "";
            var cmd = new NpgsqlCommand(sql, con);
            return result;
        }

    }
}
