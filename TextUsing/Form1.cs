using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextUsing
{
    public partial class FormCheck : Form
    {
        int unknownNumber_;
        public FormCheck()
        {
            InitializeComponent();

            Random random = new Random();
            unknownNumber_ = random.Next(1, 101);
        }

        private void ButtonCheck_Click(object sender, EventArgs e)
        {
           string input = InputTextBox.Text;
            int num = Convert.ToInt32(input);

            if (unknownNumber_ == num)
            {
                MessageBox.Show("Число угадано");
            }
            else if (unknownNumber_ > num)
            {
                MessageBox.Show("Число больше загадонного");
            }
            else 
            {
                MessageBox.Show("Число меньше загаданного");
            }
        }
    }
}
