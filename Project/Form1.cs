using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            FotoPictureBox.Size = new Size(161, 175);
            FotoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            List<Students> students = new List<Students>();
            students.Add(new Students("Ненси Уиллер", 18, 5.0, 51, "C:\\Users\\Acer\\source\\repos\\lr.MDK.01.01\\Project\\Nen.jpg"));
            students.Add(new Students("Стив Харингтон", 19, 3.7, 37, "C:\\Users\\Acer\\source\\repos\\lr.MDK.01.01\\Project\\ctiv.jpg"));
            students.Add(new Students("Эрика Синклер", 14, 4.8, 13, "C:\\Users\\Acer\\source\\repos\\lr.MDK.01.01\\Project\\'hbrf.jpg"));
            students.Add(new Students("Максин Мейфилд", 16, 4.9, 27, "C:\\Users\\Acer\\source\\repos\\lr.MDK.01.01\\Project\\Max.jpg"));

            ListBox.DataSource = students;
            ListBox.DisplayMember = "Name";
            

        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Students st_name = ListBox.SelectedItem as Students;
            labelName.Text = "Студент: " + st_name.Name;
            labelAge.Text = "Возраст: " + st_name.Age.ToString();
            labelArgs.Text = "Средний балл: " + st_name.Args.ToString();
            labelNumber.Text = "Номер билета: " + st_name.Number.ToString();
            if (st_name.Fotokartochka != null)
            {
                FotoPictureBox.Image = Image.FromFile(st_name.Fotokartochka);
            }
        }
    }
}
