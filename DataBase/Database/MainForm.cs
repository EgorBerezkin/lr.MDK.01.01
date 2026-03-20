using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Database
{
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();

            var cs = "Host=192.168.1.48;Username=st50-2;Password=502;Database=Users_Students";
            var con = new NpgsqlConnection(cs);
            con.Open();

            /// var sql = "SELECT version()";
            /// var cmd = new NpgsqlCommand(sql, con);

            string sql = "SELECT login FROM students";
            var cmd = new NpgsqlCommand(sql, con);
            var reader = cmd.ExecuteReader();

            List<string> logins = new List<string>();
            while(reader.Read())
            {
                
                string login = reader.GetString(0);
                string password = reader.GetString(0);
                logins.Add(login + ":" + password);
            }
            MessageBox.Show($"{logins}");
            /// var version = cmd.ExecuteScalar().ToString();
            /// MessageBox.Show($"PostgresSQL: {version}");
        }
    }
}
