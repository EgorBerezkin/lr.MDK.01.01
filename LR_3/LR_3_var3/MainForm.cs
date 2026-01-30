using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR_3_var3
{
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();
            FotoPictureBox.Size = new Size(161, 175);
            FotoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            List<Films> kino = new List<Films>();
            kino.Add(new Films("Очень странные дела", "Действие разворачивается в 1980-х годах" +
                " в вымышленном городке Хоукинс (штат Индиана). Расположенная неподалёку " +
                "Национальная лаборатория Хоукинса якобы проводит научные исследования для " +
                "Министерства энергетики США, но на самом деле тайно занимается экспериментами в " +
                "области паранормальных и сверхъестественных явлений. Во время одного из своих экспериментов " +
                "сотрудники лаборатории случайно открывают портал в альтернативное измерение — «Изнанку»", "Братья Дафферы", "10.12.2025", 5780.00, 6, "C:\\Users\\st56\\source\\repos\\Berezkin\\LR_3\\LR_3_var3\\osd.jpg"));
            kino.Add(new Films("Энн с двумя нн", " 1896 год, Канада. Пожилые брат с сестрой Мэттью и Марилла Катберт живут" +
                " на семейной ферме «Зелёные крыши» на окраине маленького канадского городка. Однажды они решают усыновить " +
                "мальчика-сироту, чтобы он помогал им по хозяйству. Из-за ошибки приюта вместо мальчика им присылают болтливую " +
                "рыжеволосую девочку Энн Ширли. Она рано потеряла родителей, была служанкой в нескольких домах и столкнулась с " +
                "травлей в приюте. Несмотря на все испытания Энн не потеряла веру в лучшее и саму себя.", " Аманда Таппинг", "10.12.2025", 3000.00, 3, "C:\\Users\\st56\\source\\repos\\Berezkin\\LR_3\\LR_3_var3\\i.jpg"));

            FilmsComboBox.DataSource = kino;
            FilmsComboBox.DisplayMember = "Name";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void FilmsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Films st_name = FilmsComboBox.SelectedItem as Films;
            LabelNaimenowanie.Text = "Наименование: " + st_name.Name;
            LabelOpisanie.Text = "Описание: " + st_name.Opisanie;
            LabelRecjiser.Text = "Режисёр: " + st_name.Rejiser;
            LabelDate.Text = "Прокат до: " + st_name.Date;
            LabelSum.Text = "Стоимость билета: " + st_name.Summ + " руб.";
            LabelNumber.Text = "Осталось прокатов: " + st_name.Number;
            if (st_name.Foto != null)
            {
                FotoPictureBox.Image = Image.FromFile(st_name.Foto);
            }
        }
    }
}
