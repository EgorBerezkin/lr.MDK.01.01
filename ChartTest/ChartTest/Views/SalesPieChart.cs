using LiveCharts;
using LiveCharts.Wpf;
using SalesLibrary;
using SalesLibrary.Analysis;
using SalesLibrary.Models;
using SalesLibrary.Presenters;
using SalesLibrary.Views;
using System;
using System.Collections.Generic;

namespace ChartTest.Views
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
            List<Item> allItems = presenter_.GetAllItems();;
            SeriesCollection seriesData = new SeriesCollection();
            foreach (Item i in allItems)
            {
                seriesData.Add(new PieSeries
                {
                    Title = i.Name,
                    Values = new ChartValues<double> { presenter_.GetProfitPercentByItem(i) },
                    DataLabels = true,
                    //Fill = System.Windows.Media.Brushes.BlueViolet
                });
            }
            Series = seriesData;
            //LegendLocation = LegendLocation.Left;
        }
    }
}
