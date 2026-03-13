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
            this.cartesian = new Grafics.Views.SalesCartesianChart();
            this.PieChart = new LiveCharts.WinForms.PieChart();
            this.SuspendLayout();
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.Location = new System.Drawing.Point(-2, 0);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(120, 329);
            this.ListBox.TabIndex = 1;
            // 
            // cartesian
            // 
            this.cartesian.Location = new System.Drawing.Point(124, 0);
            this.cartesian.Name = "cartesian";
            this.cartesian.Size = new System.Drawing.Size(636, 320);
            this.cartesian.TabIndex = 2;
            this.cartesian.Text = "cartesian";
            // 
            // PieChart
            // 
            this.PieChart.Location = new System.Drawing.Point(766, 3);
            this.PieChart.Name = "PieChart";
            this.PieChart.Size = new System.Drawing.Size(200, 100);
            this.PieChart.TabIndex = 3;
            this.PieChart.Text = "PieChart";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 321);
            this.Controls.Add(this.PieChart);
            this.Controls.Add(this.cartesian);
            this.Controls.Add(this.ListBox);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox ListBox;
        private SalesCartesianChart cartesian;
        private LiveCharts.WinForms.PieChart PieChart;
    }
}

