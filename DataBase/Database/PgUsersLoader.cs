using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class PgUsersLoader
    {
        public List<User> LoadUsers()
        {
            List<User> allUsers = new List<User>();
            var cs = "Host=192.168.1.48;Username=st50-2;Password=502;Database=Users_Students";
            var con = new NpgsqlConnection(cs);

            con.Open();
            var sql = "SELECT login,password,lastname,name,phone,email FROM students";
            var cmd = new NpgsqlCommand(sql, con);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                allUsers.Add(new User
                {
                    Login = reader.GetString(0),
                    Password = reader.GetString(1),
                    Last_Name = reader.GetString(2),
                    Name = reader.GetString(3),
                    Phone = reader.GetString(4),
                    Email = reader.GetString(5)
                });

            }
            con.Close();

            var sql_delete = "DELETE FROM students WHERE login = @login";

            try
            {
                var dataSourse = NpgsqlDataSource.Create(sql_delete);
                var cmd_delete = dataSourse.CreateCommand(sql_delete);
                cmd_delete.Parameters.AddWithValue("@login", 1);
                cmd_delete.ExecuteNonQueryAsync();
                Console.WriteLine("");
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }



            return allUsers;
        }
    }
}
