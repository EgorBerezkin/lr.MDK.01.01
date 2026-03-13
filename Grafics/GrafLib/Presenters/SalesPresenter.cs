using GrafLib.Analysis;
using GrafLib.Models;
using GrafLib.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafLib.Presenters
{
    public class SalesPresenter
    {
        private SalesModel model_ = new SalesModel();
        private List<ISalesView> views_;
        public SalesPresenter(List<ISalesView> views)
        {
            views_ = views;

            model_.Load();
        }
        public void ShowSalesByInventar(string inventarName)
        {
            List<Sale> sales = model_.LoadSalesForInventar(inventarName);
            foreach (ISalesView view in views_)
            {
                view.Show(sales);
            }
        }
        public List<Inventar> GetAllInventar()
        {
            return model_.GetAllInventar();
        }
        public double GetProfitPercentByInventar(Inventar selectedInventar)
        {
            double result = ProfitAnalyser.CalculateProfitPercentByInventar(selectedInventar.Name,
                                                               model_);
            return Math.Round(result, 2);
        }
    }
}
