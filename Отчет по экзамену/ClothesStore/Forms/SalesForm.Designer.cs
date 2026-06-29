namespace ClothesStore.Forms
{
    partial class SalesForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxPayment = new System.Windows.Forms.ComboBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.dataGridViewReceipt = new System.Windows.Forms.DataGridView();
            this.Tovar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolichestvo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Summa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelPokupatel = new System.Windows.Forms.Label();
            this.labelPolzovatel = new System.Windows.Forms.Label();
            this.labelCheckNumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.buttonFindCustomer = new System.Windows.Forms.Button();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.comboBoxTovars = new System.Windows.Forms.ComboBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSaveSale = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceipt)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.label7);
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.comboBoxPayment);
            this.panel.Controls.Add(this.labelTotal);
            this.panel.Controls.Add(this.dataGridViewReceipt);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.labelDateTime);
            this.panel.Controls.Add(this.label8);
            this.panel.Controls.Add(this.labelPokupatel);
            this.panel.Controls.Add(this.labelPolzovatel);
            this.panel.Controls.Add(this.labelCheckNumber);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label1);
            this.panel.Location = new System.Drawing.Point(13, 13);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(559, 402);
            this.panel.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(10, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Благодарим за покупку !";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(9, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(513, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "---------------------------------------------------------------------------------" +
    "--------------------";
            // 
            // comboBoxPayment
            // 
            this.comboBoxPayment.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxPayment.FormattingEnabled = true;
            this.comboBoxPayment.Location = new System.Drawing.Point(11, 339);
            this.comboBoxPayment.Name = "comboBoxPayment";
            this.comboBoxPayment.Size = new System.Drawing.Size(121, 25);
            this.comboBoxPayment.TabIndex = 16;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotal.Location = new System.Drawing.Point(10, 315);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(90, 17);
            this.labelTotal.TabIndex = 15;
            this.labelTotal.Text = "Итого: 0 руб.";
            // 
            // dataGridViewReceipt
            // 
            this.dataGridViewReceipt.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReceipt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tovar,
            this.Chena,
            this.Kolichestvo,
            this.Summa});
            this.dataGridViewReceipt.Location = new System.Drawing.Point(13, 171);
            this.dataGridViewReceipt.Name = "dataGridViewReceipt";
            this.dataGridViewReceipt.RowHeadersWidth = 51;
            this.dataGridViewReceipt.RowTemplate.Height = 24;
            this.dataGridViewReceipt.Size = new System.Drawing.Size(531, 124);
            this.dataGridViewReceipt.TabIndex = 14;
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
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Название товара";
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateTime.Location = new System.Drawing.Point(408, 94);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(92, 17);
            this.labelDateTime.TabIndex = 10;
            this.labelDateTime.Text = "Дата и время";
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
            // labelPokupatel
            // 
            this.labelPokupatel.AutoSize = true;
            this.labelPokupatel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPokupatel.Location = new System.Drawing.Point(10, 134);
            this.labelPokupatel.Name = "labelPokupatel";
            this.labelPokupatel.Size = new System.Drawing.Size(85, 17);
            this.labelPokupatel.TabIndex = 6;
            this.labelPokupatel.Text = "Покупатель:";
            // 
            // labelPolzovatel
            // 
            this.labelPolzovatel.AutoSize = true;
            this.labelPolzovatel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPolzovatel.Location = new System.Drawing.Point(11, 114);
            this.labelPolzovatel.Name = "labelPolzovatel";
            this.labelPolzovatel.Size = new System.Drawing.Size(56, 17);
            this.labelPolzovatel.TabIndex = 5;
            this.labelPolzovatel.Text = "Кассир:";
            // 
            // labelCheckNumber
            // 
            this.labelCheckNumber.AutoSize = true;
            this.labelCheckNumber.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCheckNumber.Location = new System.Drawing.Point(10, 94);
            this.labelCheckNumber.Name = "labelCheckNumber";
            this.labelCheckNumber.Size = new System.Drawing.Size(55, 17);
            this.labelCheckNumber.TabIndex = 4;
            this.labelCheckNumber.Text = "ЧЕК №";
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
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.BackColor = System.Drawing.Color.Wheat;
            this.maskedTextBoxPhone.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(10, 32);
            this.maskedTextBoxPhone.Mask = "+7 000 000-00-00";
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(121, 25);
            this.maskedTextBoxPhone.TabIndex = 8;
            // 
            // buttonFindCustomer
            // 
            this.buttonFindCustomer.BackColor = System.Drawing.Color.Wheat;
            this.buttonFindCustomer.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFindCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonFindCustomer.Location = new System.Drawing.Point(136, 32);
            this.buttonFindCustomer.Name = "buttonFindCustomer";
            this.buttonFindCustomer.Size = new System.Drawing.Size(75, 29);
            this.buttonFindCustomer.TabIndex = 9;
            this.buttonFindCustomer.Text = "Найти";
            this.buttonFindCustomer.UseVisualStyleBackColor = false;
            this.buttonFindCustomer.Click += new System.EventHandler(this.buttonFindCustomer_Click);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.BackColor = System.Drawing.Color.Wheat;
            this.buttonAddProduct.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonAddProduct.Location = new System.Drawing.Point(32, 58);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(86, 32);
            this.buttonAddProduct.TabIndex = 13;
            this.buttonAddProduct.Text = "Добавить товар";
            this.buttonAddProduct.UseVisualStyleBackColor = false;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.BackColor = System.Drawing.Color.Wheat;
            this.buttonDeleteProduct.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDeleteProduct.Location = new System.Drawing.Point(124, 59);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(87, 31);
            this.buttonDeleteProduct.TabIndex = 17;
            this.buttonDeleteProduct.Text = "Удалить товар";
            this.buttonDeleteProduct.UseVisualStyleBackColor = false;
            this.buttonDeleteProduct.Click += new System.EventHandler(this.buttonDeleteProduct_Click);
            // 
            // comboBoxTovars
            // 
            this.comboBoxTovars.BackColor = System.Drawing.Color.Wheat;
            this.comboBoxTovars.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxTovars.FormattingEnabled = true;
            this.comboBoxTovars.Location = new System.Drawing.Point(10, 27);
            this.comboBoxTovars.Name = "comboBoxTovars";
            this.comboBoxTovars.Size = new System.Drawing.Size(201, 24);
            this.comboBoxTovars.TabIndex = 18;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Tan;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonClear.Location = new System.Drawing.Point(593, 72);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(220, 50);
            this.buttonClear.TabIndex = 19;
            this.buttonClear.Text = "Новый чек";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSaveSale
            // 
            this.buttonSaveSale.BackColor = System.Drawing.Color.Tan;
            this.buttonSaveSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveSale.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonSaveSale.Location = new System.Drawing.Point(593, 13);
            this.buttonSaveSale.Name = "buttonSaveSale";
            this.buttonSaveSale.Size = new System.Drawing.Size(220, 50);
            this.buttonSaveSale.TabIndex = 20;
            this.buttonSaveSale.Text = "Оформить продажу";
            this.buttonSaveSale.UseVisualStyleBackColor = false;
            this.buttonSaveSale.Click += new System.EventHandler(this.buttonSaveSale_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.maskedTextBoxPhone);
            this.panel1.Controls.Add(this.buttonFindCustomer);
            this.panel1.Location = new System.Drawing.Point(593, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 69);
            this.panel1.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(7, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Поиск покупателя:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Tan;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.comboBoxTovars);
            this.panel2.Controls.Add(this.buttonAddProduct);
            this.panel2.Controls.Add(this.buttonDeleteProduct);
            this.panel2.Location = new System.Drawing.Point(593, 209);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 99);
            this.panel2.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(7, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Добавление товара:";
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(829, 427);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSaveSale);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.panel);
            this.Name = "SalesForm";
            this.Text = "Оформление продаж";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceipt)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCheckNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelPokupatel;
        private System.Windows.Forms.Label labelPolzovatel;
        private System.Windows.Forms.Button buttonFindCustomer;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewReceipt;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button buttonDeleteProduct;
        private System.Windows.Forms.ComboBox comboBoxPayment;
        private System.Windows.Forms.ComboBox comboBoxTovars;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tovar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolichestvo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Summa;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSaveSale;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
    }
}