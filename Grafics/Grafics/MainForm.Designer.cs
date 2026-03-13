using Grafics.Views;

namespace Grafics
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListBox = new System.Windows.Forms.ListBox();
            this.PieChart = new LiveCharts.WinForms.PieChart();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.SuspendLayout();
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 16;
            this.ListBox.Location = new System.Drawing.Point(-3, 0);
            this.ListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(159, 404);
            this.ListBox.TabIndex = 1;
            this.ListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged_1);
            // 
            // PieChart
            // 
            this.PieChart.Location = new System.Drawing.Point(1021, 4);
            this.PieChart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PieChart.Name = "PieChart";
            this.PieChart.Size = new System.Drawing.Size(267, 123);
            this.PieChart.TabIndex = 3;
            this.PieChart.Text = "PieChart";
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(163, 0);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(905, 383);
            this.cartesianChart1.TabIndex = 4;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 395);
            this.Controls.Add(this.cartesianChart1);
            this.Controls.Add(this.PieChart);
            this.Controls.Add(this.ListBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox ListBox;
        private SalesCartesianChart cartesian;
        private LiveCharts.WinForms.PieChart PieChart;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
    }
}

