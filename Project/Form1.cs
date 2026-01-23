using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            List<Students> students = new List<Students>();
            students.Add(new Students("Ненси Уиллер", 18, 5.0, 51, "C:\\Березкин\\Project\\Nency.jpg"));
            students.Add(new Students("Стив Харингтон", 19, 3.7, 37, "C:\\Березкин\\Project\\ctiv.jpg"));
            students.Add(new Students("Эрика Синклер", 14, 4.8, 13, "C:\\Березкин\\Project\\'hbrf.jpg"));
            students.Add(new Students("Максин Мейфилд", 16, 4.9, 27, "C:\\Березкин\\Project\\max.jpg"));

            ListBox.DataSource = students;
            ListBox.DisplayMember = "Name";
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Students st_name = ListBox.SelectedItem as Students;
            labelName.Text = st_name.Name;
            labelAge.Text = st_name.Age;
            labelArgs.Text = st_name.Args;
            labelNumber.Text = st_name.Number;
            FotoPictureBox.Image = st_name.Fotokartochka;
        }
    }
}
