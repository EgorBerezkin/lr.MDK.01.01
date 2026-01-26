using System;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;


namespace TextUsing
{
    public partial class FormCheck : Form
    {
        private int unknownNumber_;
        private int currentSecond_;
        private int attemptsCount_;
        private Timer gameTimer; // Переменная для таймера

        public FormCheck()
        {
            InitializeComponent();

            Random random = new Random();
            unknownNumber_ = random.Next(1, 101);
            currentSecond_ = 0;
            attemptsCount_ = 0;

            gameTimer = new Timer();    // Создаём новый таймер
            gameTimer.Interval = 1000; // 1 секунда = 1000 миллисекунд
            gameTimer.Tick += timer_Tick;   // Привязываем обработчик события
            gameTimer.Start();              // Запускаем таймер
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            currentSecond_++;
            DatePickerTime.Value = new DateTime(2025, 01, 01, 0, 1, 0).AddSeconds(-currentSecond_);

            if (currentSecond_ >= 60)
            {
                gameTimer.Stop(); // Останавливаем таймер
                MessageBox.Show("Время вышло, вы проиграли");
                Application.Exit(); // Выход из игры
            }
        }

        private void ButtonCheck_Click(object sender, EventArgs e)
        {

            string input = InputTextBox.Text;
            int num = Convert.ToInt32(input);
            attemptsCount_++;

            if (unknownNumber_ == num)
            {
                MessageBox.Show("Число угадано!");
                Application.Exit();
                gameTimer.Stop();
            }
            else if (unknownNumber_ > num)
            {
                richTextBox.AppendText(attemptsCount_ + " попытка, ваше число" + InputTextBox.Text + "\n");
                MessageBox.Show("Число больше загадонного");
            }
            else 
            {
                richTextBox.AppendText(attemptsCount_ + " попытка, ваше число" + InputTextBox.Text + "\n");
                MessageBox.Show("Число меньше загаданного");
            }
        }
    }
}
