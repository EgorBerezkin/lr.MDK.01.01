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
        int secondsLeft = 60;
        bool gameFinished = false;
        System.Windows.Forms.Timer timer;

        public FormCheck()
        {
            InitializeComponent();

            Random random = new Random();
            unknownNumber_ = random.Next(1, 101);

            // Настраиваем DateTimePicker
            DatePickerTime.Format = DateTimePickerFormat.Time;
            DatePickerTime.ShowUpDown = true;
            DatePickerTime.Value = new DateTime(1, 1, 1, 0, 1, 0);
            DatePickerTime.Enabled = false;

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            secondsLeft--;

            // Не даем secondsLeft стать отрицательным
            if (secondsLeft < 0) secondsLeft = 0;

            // Обновляем DateTimePicker (минимально 0 секунд)
            DatePickerTime.Value = new DateTime(1, 1, 1, 0, 0, Math.Max(0, secondsLeft));

            if (secondsLeft <= 0 && !gameFinished)
            {
                timer.Stop();
                gameFinished = true;
                MessageBox.Show($"Время вышло! Число: {unknownNumber_}");
            }
        }

        private void ButtonCheck_Click(object sender, EventArgs e)
        {
            if (secondsLeft <= 0) return;

            string input = InputTextBox.Text;
            int num = Convert.ToInt32(input);

            if (unknownNumber_ == num)
            {
                MessageBox.Show($"Число угадано! Осталось времени: {secondsLeft} сек");
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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
