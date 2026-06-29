namespace ClothesStore.Forms
{
    partial class ClientCardForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.labelObchajaSumma = new System.Windows.Forms.Label();
            this.dataGridViewReceiptItems = new System.Windows.Forms.DataGridView();
            this.Tovar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolichestvo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Summa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelOpenDate = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelKolvo = new System.Windows.Forms.Label();
            this.labelTotalSum = new System.Windows.Forms.Label();
            this.labelAvgCheck = new System.Windows.Forms.Label();
            this.labelDataVisita = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelNumberChecka = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonZakrit = new System.Windows.Forms.Button();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceiptItems)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.labelDiscount);
            this.panel.Controls.Add(this.label7);
            this.panel.Controls.Add(this.labelNumberChecka);
            this.panel.Controls.Add(this.label9);
            this.panel.Controls.Add(this.labelDataVisita);
            this.panel.Controls.Add(this.labelAvgCheck);
            this.panel.Controls.Add(this.labelTotalSum);
            this.panel.Controls.Add(this.labelKolvo);
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.labelObchajaSumma);
            this.panel.Controls.Add(this.dataGridViewReceiptItems);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label8);
            this.panel.Controls.Add(this.labelPhone);
            this.panel.Controls.Add(this.labelOpenDate);
            this.panel.Controls.Add(this.labelText);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label1);
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(559, 518);
            this.panel.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(10, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(513, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "---------------------------------------------------------------------------------" +
    "--------------------";
            // 
            // labelObchajaSumma
            // 
            this.labelObchajaSumma.AutoSize = true;
            this.labelObchajaSumma.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelObchajaSumma.Location = new System.Drawing.Point(12, 491);
            this.labelObchajaSumma.Name = "labelObchajaSumma";
            this.labelObchajaSumma.Size = new System.Drawing.Size(90, 17);
            this.labelObchajaSumma.TabIndex = 15;
            this.labelObchajaSumma.Text = "Итого: 0 руб.";
            // 
            // dataGridViewReceiptItems
            // 
            this.dataGridViewReceiptItems.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewReceiptItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReceiptItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tovar,
            this.Chena,
            this.Kolichestvo,
            this.Summa});
            this.dataGridViewReceiptItems.Location = new System.Drawing.Point(12, 326);
            this.dataGridViewReceiptItems.Name = "dataGridViewReceiptItems";
            this.dataGridViewReceiptItems.RowHeadersWidth = 51;
            this.dataGridViewReceiptItems.RowTemplate.Height = 24;
            this.dataGridViewReceiptItems.Size = new System.Drawing.Size(531, 124);
            this.dataGridViewReceiptItems.TabIndex = 14;
            // 
            // Tovar
            // 
            this.Tovar.HeaderText = "Товар";
            this.Tovar.MinimumWidth = 6;
            this.Tovar.Name = "Tovar";
            this.Tovar.Width = 125;
            // 
            // Chena
            // 
            this.Chena.HeaderText = "Цена";
            this.Chena.MinimumWidth = 6;
            this.Chena.Name = "Chena";
            this.Chena.Width = 75;
            // 
            // Kolichestvo
            // 
            this.Kolichestvo.HeaderText = "Количество";
            this.Kolichestvo.MinimumWidth = 6;
            this.Kolichestvo.Name = "Kolichestvo";
            this.Kolichestvo.Width = 90;
            // 
            // Summa
            // 
            this.Summa.HeaderText = "Сумма";
            this.Summa.MinimumWidth = 6;
            this.Summa.Name = "Summa";
            this.Summa.Width = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(10, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Информация о клиенте";
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
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhone.Location = new System.Drawing.Point(10, 134);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(67, 17);
            this.labelPhone.TabIndex = 6;
            this.labelPhone.Text = "Клиент с:";
            // 
            // labelOpenDate
            // 
            this.labelOpenDate.AutoSize = true;
            this.labelOpenDate.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOpenDate.Location = new System.Drawing.Point(11, 114);
            this.labelOpenDate.Name = "labelOpenDate";
            this.labelOpenDate.Size = new System.Drawing.Size(105, 17);
            this.labelOpenDate.TabIndex = 5;
            this.labelOpenDate.Text = "Дата открытия:";
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelText.Location = new System.Drawing.Point(10, 94);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(163, 17);
            this.labelText.TabIndex = 4;
            this.labelText.Text = "КАРТОЧКА КЛИЕНТА";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 77);
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
            // labelKolvo
            // 
            this.labelKolvo.AutoSize = true;
            this.labelKolvo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKolvo.Location = new System.Drawing.Point(11, 189);
            this.labelKolvo.Name = "labelKolvo";
            this.labelKolvo.Size = new System.Drawing.Size(148, 17);
            this.labelKolvo.TabIndex = 19;
            this.labelKolvo.Text = "Количество покупок: 0";
            // 
            // labelTotalSum
            // 
            this.labelTotalSum.AutoSize = true;
            this.labelTotalSum.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalSum.Location = new System.Drawing.Point(11, 210);
            this.labelTotalSum.Name = "labelTotalSum";
            this.labelTotalSum.Size = new System.Drawing.Size(153, 17);
            this.labelTotalSum.TabIndex = 20;
            this.labelTotalSum.Text = "Общая сумма покупок:";
            // 
            // labelAvgCheck
            // 
            this.labelAvgCheck.AutoSize = true;
            this.labelAvgCheck.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAvgCheck.Location = new System.Drawing.Point(12, 230);
            this.labelAvgCheck.Name = "labelAvgCheck";
            this.labelAvgCheck.Size = new System.Drawing.Size(90, 17);
            this.labelAvgCheck.TabIndex = 21;
            this.labelAvgCheck.Text = "Средний чек:";
            // 
            // labelDataVisita
            // 
            this.labelDataVisita.AutoSize = true;
            this.labelDataVisita.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDataVisita.Location = new System.Drawing.Point(11, 251);
            this.labelDataVisita.Name = "labelDataVisita";
            this.labelDataVisita.Size = new System.Drawing.Size(117, 17);
            this.labelDataVisita.TabIndex = 22;
            this.labelDataVisita.Text = "Последний визит:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(9, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Последняя покупка";
            // 
            // labelNumberChecka
            // 
            this.labelNumberChecka.AutoSize = true;
            this.labelNumberChecka.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumberChecka.Location = new System.Drawing.Point(9, 306);
            this.labelNumberChecka.Name = "labelNumberChecka";
            this.labelNumberChecka.Size = new System.Drawing.Size(50, 17);
            this.labelNumberChecka.TabIndex = 24;
            this.labelNumberChecka.Text = "Чек №";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(11, 453);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(513, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "---------------------------------------------------------------------------------" +
    "--------------------";
            // 
            // buttonZakrit
            // 
            this.buttonZakrit.BackColor = System.Drawing.Color.Tan;
            this.buttonZakrit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZakrit.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonZakrit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonZakrit.Location = new System.Drawing.Point(426, 542);
            this.buttonZakrit.Name = "buttonZakrit";
            this.buttonZakrit.Size = new System.Drawing.Size(136, 37);
            this.buttonZakrit.TabIndex = 20;
            this.buttonZakrit.Text = "Закрыть";
            this.buttonZakrit.UseVisualStyleBackColor = false;
            this.buttonZakrit.Click += new System.EventHandler(this.buttonZakrit_Click);
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDiscount.Location = new System.Drawing.Point(12, 470);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(146, 17);
            this.labelDiscount.TabIndex = 26;
            this.labelDiscount.Text = "Персональная скидка:";
            // 
            // ClientCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(580, 589);
            this.Controls.Add(this.buttonZakrit);
            this.Controls.Add(this.panel);
            this.Name = "ClientCardForm";
            this.Text = "Карточка клиента";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceiptItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelObchajaSumma;
        private System.Windows.Forms.DataGridView dataGridViewReceiptItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tovar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolichestvo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Summa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelOpenDate;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelDataVisita;
        private System.Windows.Forms.Label labelAvgCheck;
        private System.Windows.Forms.Label labelTotalSum;
        private System.Windows.Forms.Label labelKolvo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelNumberChecka;
        private System.Windows.Forms.Button buttonZakrit;
        private System.Windows.Forms.Label labelDiscount;
    }
}