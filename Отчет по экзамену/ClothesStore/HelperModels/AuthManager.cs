using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClothesStore.Models;
using Npgsql;

namespace ClothesStore.HelperModels
{
    public class AuthManager
    {
        public List<Polzovatel> polzovatelList_;
        public Polzovatel currentPolzovatel_;
        public int failedAttempts_;

        private DateTime blockTime_;
        private string connectionString = "Host=localhost;Database=ClothesStoreDB;Username=postgres";

        public AuthManager()
        {
            polzovatelList_ = new List<Polzovatel>();
            currentPolzovatel_ = null;
            failedAttempts_ = 0;
            blockTime_ = DateTime.MinValue;
            LoadUsersFromDB();
        }

        private void LoadUsersFromDB()
        {
            try
            {
                polzovatelList_.Clear();
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT id, login, pass, role, fullname FROM Users"; 
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string roleStr = reader.GetString(3).Trim().ToLower();
                            Polzovatel.Role role;
                            // Сравниваем с учётом регистра
                            if (roleStr == "admin")
                            {
                                role = Polzovatel.Role.admin;
                            }
                            else if (roleStr == "seller")
                            {
                                role = Polzovatel.Role.seller;
                            }
                            else
                            {
                                // Если роль не распознана, по умолчанию seller
                                role = Polzovatel.Role.seller;
                            }

                            Polzovatel user = new Polzovatel(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), role, reader.GetString(4));
                            polzovatelList_.Add(user);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Ошибка загрузки пользователей: {ex.Message}");
            }
        }

        private void WriteLoginLog(string login, string role, string fio)
        {
            try
            {
                string sql = "INSERT INTO LoginLogs (user_login, user_role, user_fullname) VALUES (@user_login, @user_role, @user_fullname)";
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@user_login", login);
                        cmd.Parameters.AddWithValue("@user_role", role);
                        cmd.Parameters.AddWithValue("@user_fullname", fio);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Ошибка записи лога: {ex.Message}");
            }
        }
        // методы класса:
        //1.	Проверяет логин и хэш пароля, возвращает результат и роль – authenticate(login, password);
        public bool Authenticate(string login, string password)
        {
            // Проверка блокировки
            if (DateTime.Now < blockTime_)
            {
                return false;
            }
            // Ищем пользователя по логину
            Polzovatel user = polzovatelList_.FirstOrDefault(u => u.login_ == login);

            if (user == null)
            {
                failedAttempts_++;
                return false;
            }

            // Проверяем пароль
            if (user.Authenticate(password))
            {
                currentPolzovatel_ = user;
                failedAttempts_ = 0;
                WriteLoginLog(user.Login, user.Roles.ToString(), user.Fio);

                return true;
            }
            else
            {
                failedAttempts_++;
                if (failedAttempts_ >= 3)
                {
                    blockTime_ = DateTime.Now.AddMinutes(5);
                }
                return false;
            }
        }
        //2.	Возвращает текущего пользователя – getCurrentUser();
        public Polzovatel GetCurrentUser()
        {
            return currentPolzovatel_;
        }
        //4.	Завершает сессию – logout().
        public void Logout()
        {
            currentPolzovatel_ = null;
            failedAttempts_ = 0;
            blockTime_ = DateTime.MinValue;
        }
        // Проверка блокировки
        public bool IsBlocked()
        {
            return DateTime.Now < blockTime_;
        }
        public int GetRemainingAttempts()
        {
            return 3 - failedAttempts_;
        }
        // Методы для администратора
        public List<Polzovatel> GetAllUsers()
        {
            LoadUsersFromDB();
            return polzovatelList_;
        }
        public bool CreateUser(string login, string password, Polzovatel.Role role, string fio)
        {
            try
            {
                string sql = "INSERT INTO Users (login, pass, role, fullname) VALUES (@login, @pass, @role, @fio)";
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@login", login);
                        cmd.Parameters.AddWithValue("@pass", password);
                        cmd.Parameters.AddWithValue("@role", role.ToString());
                        cmd.Parameters.AddWithValue("@fio", fio);
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadUsersFromDB();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateUser(int userId, string fio, Polzovatel.Role role, string newPassword = null)
        {
            try
            {
                if (!string.IsNullOrEmpty(newPassword))
                {
                    string sql = "UPDATE Users SET fullname = @fio, role = @role, pass = @pass WHERE id = @id";
                    using (var conn = new NpgsqlConnection(connectionString))
                    {
                        conn.Open();
                        using (var cmd = new NpgsqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@fio", fio);
                            cmd.Parameters.AddWithValue("@role", role.ToString());
                            cmd.Parameters.AddWithValue("@pass", newPassword);
                            cmd.Parameters.AddWithValue("@id", userId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                else
                {
                    string sql = "UPDATE Users SET fullname = @fio, role = @role WHERE id = @id";
                    using (var conn = new NpgsqlConnection(connectionString))
                    {
                        conn.Open();
                        using (var cmd = new NpgsqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@fio", fio);
                            cmd.Parameters.AddWithValue("@role", role.ToString());
                            cmd.Parameters.AddWithValue("@id", userId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                LoadUsersFromDB();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteUser(int userId)
        {
            if (currentPolzovatel_ != null && currentPolzovatel_.IdUser == userId)
            return false;
            try
            {
                string sql = "DELETE FROM Users WHERE id = @id";
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", userId);
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadUsersFromDB();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
