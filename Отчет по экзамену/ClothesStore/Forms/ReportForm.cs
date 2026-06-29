using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClothesStore.HelperModels;
using ClothesStore.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;

namespace ClothesStore.Forms
{
    public partial class ReportForm : Form
    {
        private DataStorage dataStorage_;
        private Polzovatel currentPolzovatel_;

        public ReportForm()
        {
            InitializeComponent();
            dataStorage_ = new DataStorage("Host=localhost;Database=ClothesStoreDB;Username=postgres");
        }
        public ReportForm(Polzovatel polzovatel) : this()
        {
            currentPolzovatel_ = polzovatel;
        }
        private void buttonGenerateReport_Click(object sender, EventArgs e)
        {
            dataStorage_.LoadReceipts();
            foreach (var receipt in dataStorage_.ReceiptsList)
            {
                dataStorage_.LoadReceiptItems(receipt);
            }

            DateTime startDate = dateTimePickerOt.Value.Date;
            DateTime endDate = dateTimePickerDo.Value.Date.AddDays(1).AddSeconds(-1);

            var receipts = dataStorage_.ReceiptsList
                .Where(r => r.sale_date_ >= startDate && r.sale_date_ <= endDate)
                .ToList();

            if (receipts.Count == 0)
            {
                MessageBox.Show("Не было продаж.");
                return;
            }
            labelPeriod.Text = $"Период: {startDate:dd.MM.yyyy} - {endDate:dd.MM.yyyy}";
            labelGenerateDate.Text = "Дата формирования: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm");
            if (currentPolzovatel_ != null)
            {
                labelUser.Text = "Сформировал: " + currentPolzovatel_.Fio;
            }
            else
            {
                labelUser.Text = "Сформировал: не указан";
            }

            double revenue = receipts.Sum(r => r.total_amount_);
            double averageCheck = revenue / receipts.Count;

            labelTotalChecksText.Text = "Количество чеков за период: " + receipts.Count.ToString();
            labelRevenueText.Text = "Общая выручка: " + revenue.ToString("N2") + " руб.";
            labelAvgCheckText.Text = "Средний чек: " + averageCheck.ToString("N2") + " руб.";

            dataGridViewCategories.Rows.Clear();
            dataGridViewCategories.Columns.Clear();

            dataGridViewCategories.Columns.Add("category", "Категория");
            dataGridViewCategories.Columns.Add("sum", "Сумма продаж");
            dataGridViewCategories.Columns.Add("percent", "Доля (%)");
            FillCategoryReport(receipts);

            CheckReceiptNumbers(receipts);
        }
        private void CheckReceiptNumbers(List<Receipt> receipts)
        {
            List<int> ids = receipts
                .Select(r => r.id_check_)
                .OrderBy(x => x)
                .ToList();

            List<int> missing = new List<int>();

            for (int i = 0; i < ids.Count - 1; i++)
            {
                for (int j = ids[i] + 1; j < ids[i + 1]; j++)
                {
                    missing.Add(j);
                }
            }

            if (missing.Count > 0)
            {
                MessageBox.Show("Обнаружены пропуски в нумерации чеков:\n" + string.Join(", ", missing));
            }
        }
        private void FillCategoryReport(List<Receipt> receipts)
        {
            dataGridViewCategories.Rows.Clear();

            string[] categories = {"Верхняя одежда", "Платья и костюмы", "Обувь", "Аксессуары", "Нижнее белье", "Пижамы", "Одежда для нижней части тела"};
            Dictionary<string, double> sales = categories.ToDictionary(x => x, x => 0.0);

            foreach (var receipt in receipts)
            {
                for (int i = 0; i < receipt.items_.Count; i++)
                {
                    string category = receipt.items_[i].category_;
                    double sum = receipt.items_[i].price_ * receipt.quantities_[i];

                    if (sales.ContainsKey(category))
                    {
                        sales[category] += sum;
                    }
                }
            }
            double totalSales = sales.Values.Sum();

            foreach (string category in categories)
            {
                double sum = sales[category];
                double percent = totalSales == 0 ? 0 : sum * 100 / totalSales;
                dataGridViewCategories.Rows.Add(category, sum.ToString("N2"), percent.ToString("F2") + "%");
            }
        }

        private void buttonExportPdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();

            saveDialog.Filter = "PDF (*.pdf)|*.pdf";
            saveDialog.FileName = "Report.pdf";

            if (saveDialog.ShowDialog() != DialogResult.OK)
                return;
            ExportToPdf(saveDialog.FileName);
        }
        private void ExportToPdf(string fileName)
        {
            string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "times.ttf");
            BaseFont baseFont = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            iTextSharp.text.Font titleFont = new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font headerFont = new iTextSharp.text.Font(baseFont, 11, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font textFont = new iTextSharp.text.Font(baseFont, 10);
            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, new FileStream(fileName, FileMode.Create));

            // Открываем документ
            document.Open();
            Paragraph title = new Paragraph("Магазин одежды «VERSAILLES»", titleFont);

            title.Alignment = Element.ALIGN_CENTER;
            document.Add(title);
            document.Add(new Paragraph(" "));
            document.Add(new Paragraph("Адрес: ул. Дзержинская, 19, ТЦ «Радость»", textFont));
            document.Add(new Paragraph("ИНН: 2930716280", textFont));
            document.Add(new Paragraph(" "));
            document.Add(new Paragraph("ФИНАНСОВЫЙ ОТЧЁТ О ВЫРУЧКЕ", headerFont));
            document.Add(new Paragraph(labelPeriod.Text, textFont));
            document.Add(new Paragraph(labelGenerateDate.Text, textFont));
            document.Add(new Paragraph(labelUser.Text, textFont));
            document.Add(new Paragraph(" "));
            document.Add(new LineSeparator());
            document.Add(new Paragraph(" "));
            document.Add(new Paragraph("ОБЩИЕ ПОКАЗАТЕЛИ", headerFont));
            document.Add(new Paragraph(labelTotalChecksText.Text, textFont));
            document.Add(new Paragraph(labelRevenueText.Text, textFont));
            document.Add(new Paragraph(labelAvgCheckText.Text, textFont));
            document.Add(new Paragraph(" "));
            document.Add(new LineSeparator());
            document.Add(new Paragraph(" "));
            document.Add(new Paragraph("СТРУКТУРА ВЫРУЧКИ ПО КАТЕГОРИЯМ", headerFont));
            document.Add(new Paragraph(" "));

            PdfPTable table = new PdfPTable(3);

            table.WidthPercentage = 100;
            table.AddCell(new Phrase("Категория", textFont));
            table.AddCell(new Phrase("Сумма, руб.", textFont));
            table.AddCell(new Phrase("Доля", textFont));

            foreach (DataGridViewRow row in dataGridViewCategories.Rows)
            {
                table.AddCell(new Phrase(row.Cells[0].Value?.ToString() ?? "", textFont));
                table.AddCell(new Phrase(row.Cells[1].Value?.ToString() ?? "", textFont));
                table.AddCell(new Phrase(row.Cells[2].Value?.ToString() ?? "", textFont));
            }

            document.Add(table);
            document.Add(new Paragraph(" "));
            document.Add(new LineSeparator());
            document.Add(new Paragraph(" "));
            document.Add(new Paragraph("Отчёт сформирован автоматически.", textFont));
            document.Add(new Paragraph("Благодарим за использование системы!", textFont));
            document.Close();

            MessageBox.Show("PDF успешно сохранён.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
