using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using SalesLibrary;
using SalesLibrary.Analysis;
using SalesLibrary.Presenters;
using SalesLibrary.Views;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;

namespace ChartTest
{
    public partial class MainForm : Form
    {
        private SalesPresenter presenter_;
        void FillCartesianChart()
        {
            ItemsList.DataSource = presenter_.GetAllItems();
            ItemsList.DisplayMember = "Name";
            if (ItemsList.Items.Count > 0)
            {
                presenter_.ShowSalesByItem(((Item)ItemsList.Items[0]).Name);
            }
        }
        public MainForm()
        {
            InitializeComponent();

            presenter_ = new SalesPresenter(new List<ISalesView> { cartesian });
            // Передача списка представлений в презентер

            FillCartesianChart();
            FillAngular();
            FillSolid();
            FillPie();
            pie.SetPresenter(presenter_);
            pie.UpdateView();
        }
        void FillAngular()
        {
            angular.FromValue = 0;
            angular.ToValue = 100;
            angular.TickStep = 2;
            angular.TicksForeground = Brushes.Black;
            angular.NeedleFill = Brushes.DarkGreen;

            angular.LabelsEffect = null;
        }
        void FillSolid()
        {
            solid.From = 0;
            solid.To = 100;
            solid.LabelFormatter = value => value + "%";
            solid.FromColor = Colors.DarkGreen;
            solid.ToColor = Colors.DarkGreen;
        }

        void FillPie()
        {
            
        }
        private void ItemsList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Item selectedItem = ((Item)(ItemsList.SelectedItem));
            // выбираем товар и получаем информацию о нем
            if(selectedItem == null)
            {
                return;
            }

            presenter_.ShowSalesByItem(selectedItem.Name);
            double percent = Math.Round(
            presenter_.GetProfitPercentByItem(selectedItem), 2);
            angular.Value = percent;
            solid.Value = percent;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
