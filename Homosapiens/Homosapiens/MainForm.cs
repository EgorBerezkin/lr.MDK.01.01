using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homosapiens
{
    public partial class MainForm : Form
    {
        private List<Homosapiens> peoples_ = new List<Homosapiens>();
        public MainForm()
        {
            InitializeComponent();
            peoples_.Add(new Homosapiens(33, "Джо Кири"));
            peoples_.Add(new Homosapiens(23, "Майя Хоук"));
            peoples_.Add(new Students(2345));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (Homosapiens people in peoples_)
            {
                HomosapiensRichTextBox.AppendText(people.ToString() + "\n");
            }
            StudentRichTextBox.Text = string.Join("\n" + AllsStudentsInfo());
        } 

        public List<string> AllsStudentsInfo()
        {
            List<string> result = new List<string>();
            foreach (Homosapiens people in peoples_)
            {
                Students st = people as Students;
                if (st != null)
                {
                    result.Add(st.ToString());
                }
            }
            return result;
        }
    }
}
