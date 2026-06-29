namespace ClothesStore.Forms
{
    partial class ReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelAvgCheckText = new System.Windows.Forms.Label();
            this.labelRevenueText = new System.Windows.Forms.Label();
            this.labelTotalChecksText = new System.Windows.Forms.Label();
            this.labelKolvo = new System.Windows.Forms.Label();
            this.labelObchajaSumma = new System.Windows.Forms.Label();
            this.dataGridViewCategories = new System.Windows.Forms.DataGridView();
            this.labelUser = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelGenerateDate = new System.Windows.Forms.Label();
            this.labelPeriod = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerOt = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDo = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonGenerateReport = new System.Windows.Forms.Button();
            this.buttonExportPdf = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.labelDiscount);
            this.panel.Controls.Add(this.label7);
            this.panel.Controls.Add(this.label9);
            this.panel.Controls.Add(this.labelAvgCheckText);
            this.panel.Controls.Add(this.labelRevenueText);
            this.panel.Controls.Add(this.labelTotalChecksText);
            this.panel.Controls.Add(this.labelKolvo);
            this.panel.Controls.Add(this.labelObchajaSumma);
            this.panel.Controls.Add(this.dataGridViewCategories);
            this.panel.Controls.Add(this.labelUser);
            this.panel.Controls.Add(this.label8);
            this.panel.Controls.Add(this.labelGenerateDate);
            this.panel.Controls.Add(this.labelPeriod);
            this.panel.Controls.Add(this.labelText);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label1);
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(559, 468);
            this.panel.TabIndex = 2;
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDiscount.Location = new System.Drawing.Point(13, 420);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(237, 17);
            this.labelDiscount.TabIndex = 26;
            this.labelDiscount.Text = "Отчёт сформирован автоматически.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(13, 403);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(513, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "---------------------------------------------------------------------------------" +
    "--------------------";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(304, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "СТРУКТУРА ВЫРУЧКИ ПО КАТЕГОРИЯМ";
            // 
            // labelAvgCheckText
            // 
            this.labelAvgCheckText.AutoSize = true;
            this.labelAvgCheckText.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAvgCheckText.Location = new System.Drawing.Point(12, 222);
            this.labelAvgCheckText.Name = "labelAvgCheckText";
            this.labelAvgCheckText.Size = new System.Drawing.Size(90, 17);
            this.labelAvgCheckText.TabIndex = 22;
            this.labelAvgCheckText.Text = "Средний чек:";
            // 
            // labelRevenueText
            // 
            this.labelRevenueText.AutoSize = true;
            this.labelRevenueText.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRevenueText.Location = new System.Drawing.Point(13, 204);
            this.labelRevenueText.Name = "labelRevenueText";
            this.labelRevenueText.Size = new System.Drawing.Size(112, 17);
            this.labelRevenueText.TabIndex = 21;
            this.labelRevenueText.Text = "Общая выручка:";
            // 
            // labelTotalChecksText
            // 
            this.labelTotalChecksText.AutoSize = true;
            this.labelTotalChecksText.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalChecksText.Location = new System.Drawing.Point(13, 186);
            this.labelTotalChecksText.Name = "labelTotalChecksText";
            this.labelTotalChecksText.Size = new System.Drawing.Size(187, 17);
            this.labelTotalChecksText.TabIndex = 20;
            this.labelTotalChecksText.Text = "Количество чеков за период:";
            // 
            // labelKolvo
            // 
            this.labelKolvo.AutoSize = true;
            this.labelKolvo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKolvo.Location = new System.Drawing.Point(12, 168);
            this.labelKolvo.Name = "labelKolvo";
            this.labelKolvo.Size = new System.Drawing.Size(167, 17);
            this.labelKolvo.TabIndex = 19;
            this.labelKolvo.Text = "ОБЩИЕ ПОКАЗАТЕЛИ";
            // 
            // labelObchajaSumma
            // 
            this.labelObchajaSumma.AutoSize = true;
            this.labelObchajaSumma.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelObchajaSumma.Location = new System.Drawing.Point(12, 440);
            this.labelObchajaSumma.Name = "labelObchajaSumma";
            this.labelObchajaSumma.Size = new System.Drawing.Size(258, 17);
            this.labelObchajaSumma.TabIndex = 15;
            this.labelObchajaSumma.Text = "Благодарим за использование системы!";
            // 
            // dataGridViewCategories
            // 
            this.dataGridViewCategories.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategories.Location = new System.Drawing.Point(12, 276);
            this.dataGridViewCategories.Name = "dataGridViewCategories";
            this.dataGridViewCategories.RowHeadersWidth = 51;
            this.dataGridViewCategories.RowTemplate.Height = 24;
            this.dataGridViewCategories.Size = new System.Drawing.Size(531, 124);
            this.dataGridViewCategories.TabIndex = 14;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUser.Location = new System.Drawing.Point(12, 139);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(96, 17);
            this.labelUser.TabIndex = 11;
            this.labelUser.Text = "Сформировал:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(9, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(513, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "---------------------------------------------------------------------------------" +
    "--------------------";
            // 
            // labelGenerateDate
            // 
            this.labelGenerateDate.AutoSize = true;
            this.labelGenerateDate.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGenerateDate.Location = new System.Drawing.Point(12, 119);
            this.labelGenerateDate.Name = "labelGenerateDate";
            this.labelGenerateDate.Size = new System.Drawing.Size(135, 17);
            this.labelGenerateDate.TabIndex = 6;
            this.labelGenerateDate.Text = "Дата формирования:";
            // 
            // labelPeriod
            // 
            this.labelPeriod.AutoSize = true;
            this.labelPeriod.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPeriod.Location = new System.Drawing.Point(12, 100);
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new System.Drawing.Size(58, 17);
            this.labelPeriod.TabIndex = 5;
            this.labelPeriod.Text = "Период:";
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelText.Location = new System.Drawing.Point(11, 80);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(261, 17);
            this.labelText.TabIndex = 4;
            this.labelText.Text = "ФИНАНСОВЫЙ ОТЧЁТ О ВЫРУЧКЕ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(508, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "---------------------------------------------------------------------------------" +
    "-------------------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(10, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "ИНН: 2930716280";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Адрес: ул. Дзержинская, 19, ТЦ \"Радость\"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(153, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Магазин одежды \"VERSAILLES\"";
            // 
            // dateTimePickerOt
            // 
            this.dateTimePickerOt.Location = new System.Drawing.Point(47, 37);
            this.dateTimePickerOt.Name = "dateTimePickerOt";
            this.dateTimePickerOt.Size = new System.Drawing.Size(161, 22);
            this.dateTimePickerOt.TabIndex = 27;
            // 
            // dateTimePickerDo
            // 
            this.dateTimePickerDo.Location = new System.Drawing.Point(47, 65);
            this.dateTimePickerDo.Name = "dateTimePickerDo";
            this.dateTimePickerDo.Size = new System.Drawing.Size(161, 22);
            this.dateTimePickerDo.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.dateTimePickerOt);
            this.panel1.Controls.Add(this.dateTimePickerDo);
            this.panel1.Location = new System.Drawing.Point(580, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 97);
            this.panel1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(4, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 23);
            this.label6.TabIndex = 31;
            this.label6.Text = "До:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(2, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 23);
            this.label5.TabIndex = 30;
            this.label5.Text = "От:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(51, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 30);
            this.label10.TabIndex = 29;
            this.label10.Text = "Период";
            // 
            // buttonGenerateReport
            // 
            this.buttonGenerateReport.BackColor = System.Drawing.Color.Tan;
            this.buttonGenerateReport.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGenerateReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonGenerateReport.Location = new System.Drawing.Point(579, 118);
            this.buttonGenerateReport.Name = "buttonGenerateReport";
            this.buttonGenerateReport.Size = new System.Drawing.Size(218, 66);
            this.buttonGenerateReport.TabIndex = 4;
            this.buttonGenerateReport.Text = "Сформировать отчёт";
            this.buttonGenerateReport.UseVisualStyleBackColor = false;
            this.buttonGenerateReport.Click += new System.EventHandler(this.buttonGenerateReport_Click);
            // 
            // buttonExportPdf
            // 
            this.buttonExportPdf.BackColor = System.Drawing.Color.Tan;
            this.buttonExportPdf.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExportPdf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonExportPdf.Location = new System.Drawing.Point(580, 194);
            this.buttonExportPdf.Name = "buttonExportPdf";
            this.buttonExportPdf.Size = new System.Drawing.Size(217, 66);
            this.buttonExportPdf.TabIndex = 5;
            this.buttonExportPdf.Text = "Экспорт в PDF";
            this.buttonExportPdf.UseVisualStyleBackColor = false;
            this.buttonExportPdf.Click += new System.EventHandler(this.buttonExportPdf_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(826, 493);
            this.Controls.Add(this.buttonExportPdf);
            this.Controls.Add(this.buttonGenerateReport);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel);
            this.Name = "ReportForm";
            this.Text = "Отчет";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelAvgCheckText;
        private System.Windows.Forms.Label labelRevenueText;
        private System.Windows.Forms.Label labelTotalChecksText;
        private System.Windows.Forms.Label labelKolvo;
        private System.Windows.Forms.Label labelObchajaSumma;
        private System.Windows.Forms.DataGridView dataGridViewCategories;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelGenerateDate;
        private System.Windows.Forms.Label labelPeriod;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerOt;
        private System.Windows.Forms.DateTimePicker dateTimePickerDo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonGenerateReport;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonExportPdf;
    }
}