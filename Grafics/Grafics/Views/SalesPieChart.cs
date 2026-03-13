using GrafLib;
using GrafLib.Presenters;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafics.Views
{
    public class SalesPieChart : LiveCharts.WinForms.PieChart
    {
        private SalesPresenter presenter_;

        public void SetPresenter(SalesPresenter presenter)
        {
            presenter_ = presenter;
        }
        public void UpdateView()
        {
            List<Inventar> allInventar = presenter_.GetAllInventar(); ;
            SeriesCollection seriesData = new SeriesCollection();
            // создание коллекции серий
            foreach (Inventar i in allInventar)
            {
                seriesData.Add(new PieSeries
                {
                    Title = i.Name,
                    Values = new ChartValues<double> { presenter_.GetProfitPercentByInventar(i) },
                    DataLabels = true,
                    Fill = System.Windows.Media.Brushes.DarkGreen,


                });
            }
            Series = seriesData;

        }
    }
}
