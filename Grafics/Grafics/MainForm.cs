using GrafLib.Presenters;
using GrafLib.Views;
using GrafLib.Analysis;
using GrafLib;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Media;

namespace Grafics
{
    public partial class MainForm : Form
    {
        private SalesPresenter presenter_;
        void FillCartesianChart()
        {

            ListBox.DataSource = presenter_.GetAllInventar();
            ListBox.DisplayMember = "Name";
            if (ListBox.Items.Count > 0)
            {
                ListBox.SelectedIndex = 0;
                var selectedInventar = (Inventar)ListBox.SelectedItem;
                presenter_.ShowSalesByInventar(selectedInventar.Name);
            }
        }
        public MainForm()
        {
            InitializeComponent();

            presenter_ = new SalesPresenter(new List<ISalesView> { cartesian });
            // Передача списка представлений в презентер

            FillCartesianChart();
            
            FillPie();
            
        }
        
        

        void FillPie()
        {

        }
        
        private void ListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Inventar selectedInventar = ((Inventar)(ListBox.SelectedItem));
            // выбираем товар и получаем информацию о нем
            if (selectedInventar == null)
            {
                return;
            }

            presenter_.ShowSalesByInventar(selectedInventar.Name);
            double percent = Math.Round(
            presenter_.GetProfitPercentByInventar(selectedInventar), 2);
        }
    }
}
