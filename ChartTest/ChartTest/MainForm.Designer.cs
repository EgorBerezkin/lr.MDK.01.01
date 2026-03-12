using ChartTest.Views;

namespace ChartTest
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cartesian = new ChartTest.Views.SalesCartesianChart();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.RightCentralPanel = new System.Windows.Forms.Panel();
            this.angular = new LiveCharts.WinForms.AngularGauge();
            this.RightBottomPanel = new System.Windows.Forms.Panel();
            this.solid = new LiveCharts.WinForms.SolidGauge();
            this.RightUpPanel = new System.Windows.Forms.Panel();
            this.pie = new ChartTest.Views.SalesPieChart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ItemsList = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.RightCentralPanel.SuspendLayout();
            this.RightBottomPanel.SuspendLayout();
            this.RightUpPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.RightPanel);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1059, 525);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CartesianChart";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cartesian);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(171, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(632, 517);
            this.panel3.TabIndex = 4;
            // 
            // cartesian
            // 
            this.cartesian.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartesian.Location = new System.Drawing.Point(0, 0);
            this.cartesian.Margin = new System.Windows.Forms.Padding(4);
            this.cartesian.Name = "cartesian";
            this.cartesian.Size = new System.Drawing.Size(632, 517);
            this.cartesian.TabIndex = 0;
            this.cartesian.Text = "cartesian";
            // 
            // RightPanel
            // 
            this.RightPanel.Controls.Add(this.RightCentralPanel);
            this.RightPanel.Controls.Add(this.RightBottomPanel);
            this.RightPanel.Controls.Add(this.RightUpPanel);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(803, 4);
            this.RightPanel.Margin = new System.Windows.Forms.Padding(4);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(252, 517);
            this.RightPanel.TabIndex = 3;
            // 
            // RightCentralPanel
            // 
            this.RightCentralPanel.Controls.Add(this.angular);
            this.RightCentralPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightCentralPanel.Location = new System.Drawing.Point(0, 126);
            this.RightCentralPanel.Margin = new System.Windows.Forms.Padding(4);
            this.RightCentralPanel.Name = "RightCentralPanel";
            this.RightCentralPanel.Size = new System.Drawing.Size(252, 268);
            this.RightCentralPanel.TabIndex = 2;
            // 
            // angular
            // 
            this.angular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.angular.Location = new System.Drawing.Point(0, 0);
            this.angular.Margin = new System.Windows.Forms.Padding(4);
            this.angular.Name = "angular";
            this.angular.Size = new System.Drawing.Size(252, 268);
            this.angular.TabIndex = 0;
            this.angular.Text = "angularGauge1";
            // 
            // RightBottomPanel
            // 
            this.RightBottomPanel.Controls.Add(this.solid);
            this.RightBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RightBottomPanel.Location = new System.Drawing.Point(0, 394);
            this.RightBottomPanel.Margin = new System.Windows.Forms.Padding(4);
            this.RightBottomPanel.Name = "RightBottomPanel";
            this.RightBottomPanel.Size = new System.Drawing.Size(252, 123);
            this.RightBottomPanel.TabIndex = 1;
            // 
            // solid
            // 
            this.solid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.solid.Location = new System.Drawing.Point(0, 0);
            this.solid.Margin = new System.Windows.Forms.Padding(4);
            this.solid.Name = "solid";
            this.solid.Size = new System.Drawing.Size(252, 123);
            this.solid.TabIndex = 0;
            this.solid.Text = "solidGauge1";
            // 
            // RightUpPanel
            // 
            this.RightUpPanel.Controls.Add(this.pie);
            this.RightUpPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.RightUpPanel.Location = new System.Drawing.Point(0, 0);
            this.RightUpPanel.Margin = new System.Windows.Forms.Padding(4);
            this.RightUpPanel.Name = "RightUpPanel";
            this.RightUpPanel.Size = new System.Drawing.Size(252, 126);
            this.RightUpPanel.TabIndex = 0;
            // 
            // pie
            // 
            this.pie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pie.Location = new System.Drawing.Point(0, 0);
            this.pie.Margin = new System.Windows.Forms.Padding(4);
            this.pie.Name = "pie";
            this.pie.Size = new System.Drawing.Size(252, 126);
            this.pie.TabIndex = 0;
            this.pie.Text = "pie";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ItemsList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 517);
            this.panel1.TabIndex = 2;
            // 
            // ItemsList
            // 
            this.ItemsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsList.FormattingEnabled = true;
            this.ItemsList.ItemHeight = 16;
            this.ItemsList.Location = new System.Drawing.Point(0, 0);
            this.ItemsList.Margin = new System.Windows.Forms.Padding(4);
            this.ItemsList.Name = "ItemsList";
            this.ItemsList.Size = new System.Drawing.Size(167, 517);
            this.ItemsList.TabIndex = 1;
            this.ItemsList.SelectedIndexChanged += new System.EventHandler(this.ItemsList_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1067, 554);
            this.tabControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "LiveCharts-диаграммы";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.RightPanel.ResumeLayout(false);
            this.RightCentralPanel.ResumeLayout(false);
            this.RightBottomPanel.ResumeLayout(false);
            this.RightUpPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel3;
        private SalesCartesianChart cartesian;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Panel RightCentralPanel;
        private LiveCharts.WinForms.AngularGauge angular;
        private System.Windows.Forms.Panel RightBottomPanel;
        private LiveCharts.WinForms.SolidGauge solid;
        private System.Windows.Forms.Panel RightUpPanel;
        private SalesPieChart pie;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox ItemsList;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

