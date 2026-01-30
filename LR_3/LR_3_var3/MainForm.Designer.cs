namespace LR_3_var3
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
            this.LabelNaimenowanie = new System.Windows.Forms.Label();
            this.Panel = new System.Windows.Forms.Panel();
            this.FilmsComboBox = new System.Windows.Forms.ComboBox();
            this.FotoPictureBox = new System.Windows.Forms.PictureBox();
            this.LabelOpisanie = new System.Windows.Forms.Label();
            this.LabelRecjiser = new System.Windows.Forms.Label();
            this.LabelDate = new System.Windows.Forms.Label();
            this.LabelSum = new System.Windows.Forms.Label();
            this.LabelNumber = new System.Windows.Forms.Label();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelNaimenowanie
            // 
            this.LabelNaimenowanie.AutoSize = true;
            this.LabelNaimenowanie.Location = new System.Drawing.Point(179, 24);
            this.LabelNaimenowanie.Name = "LabelNaimenowanie";
            this.LabelNaimenowanie.Size = new System.Drawing.Size(35, 13);
            this.LabelNaimenowanie.TabIndex = 0;
            this.LabelNaimenowanie.Text = "label1";
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.LabelNumber);
            this.Panel.Controls.Add(this.LabelSum);
            this.Panel.Controls.Add(this.LabelDate);
            this.Panel.Controls.Add(this.LabelRecjiser);
            this.Panel.Controls.Add(this.LabelOpisanie);
            this.Panel.Controls.Add(this.FotoPictureBox);
            this.Panel.Controls.Add(this.LabelNaimenowanie);
            this.Panel.Location = new System.Drawing.Point(234, -2);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(486, 309);
            this.Panel.TabIndex = 1;
            // 
            // FilmsComboBox
            // 
            this.FilmsComboBox.FormattingEnabled = true;
            this.FilmsComboBox.Location = new System.Drawing.Point(9, 6);
            this.FilmsComboBox.Name = "FilmsComboBox";
            this.FilmsComboBox.Size = new System.Drawing.Size(215, 21);
            this.FilmsComboBox.TabIndex = 2;
            this.FilmsComboBox.SelectedIndexChanged += new System.EventHandler(this.FilmsComboBox_SelectedIndexChanged);
            // 
            // FotoPictureBox
            // 
            this.FotoPictureBox.Location = new System.Drawing.Point(16, 13);
            this.FotoPictureBox.Name = "FotoPictureBox";
            this.FotoPictureBox.Size = new System.Drawing.Size(142, 198);
            this.FotoPictureBox.TabIndex = 1;
            this.FotoPictureBox.TabStop = false;
            // 
            // LabelOpisanie
            // 
            this.LabelOpisanie.AutoSize = true;
            this.LabelOpisanie.Location = new System.Drawing.Point(179, 53);
            this.LabelOpisanie.Name = "LabelOpisanie";
            this.LabelOpisanie.Size = new System.Drawing.Size(35, 13);
            this.LabelOpisanie.TabIndex = 2;
            this.LabelOpisanie.Text = "label2";
            // 
            // LabelRecjiser
            // 
            this.LabelRecjiser.AutoSize = true;
            this.LabelRecjiser.Location = new System.Drawing.Point(179, 122);
            this.LabelRecjiser.Name = "LabelRecjiser";
            this.LabelRecjiser.Size = new System.Drawing.Size(35, 13);
            this.LabelRecjiser.TabIndex = 3;
            this.LabelRecjiser.Text = "label3";
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Location = new System.Drawing.Point(179, 147);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(35, 13);
            this.LabelDate.TabIndex = 4;
            this.LabelDate.Text = "label4";
            // 
            // LabelSum
            // 
            this.LabelSum.AutoSize = true;
            this.LabelSum.Location = new System.Drawing.Point(179, 178);
            this.LabelSum.Name = "LabelSum";
            this.LabelSum.Size = new System.Drawing.Size(35, 13);
            this.LabelSum.TabIndex = 5;
            this.LabelSum.Text = "label5";
            // 
            // LabelNumber
            // 
            this.LabelNumber.AutoSize = true;
            this.LabelNumber.Location = new System.Drawing.Point(344, 147);
            this.LabelNumber.Name = "LabelNumber";
            this.LabelNumber.Size = new System.Drawing.Size(35, 13);
            this.LabelNumber.TabIndex = 6;
            this.LabelNumber.Text = "label6";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(723, 308);
            this.Controls.Add(this.FilmsComboBox);
            this.Controls.Add(this.Panel);
            this.Name = "MainForm";
            this.Text = "Кинофильмы";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelNaimenowanie;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Label LabelNumber;
        private System.Windows.Forms.Label LabelSum;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.Label LabelRecjiser;
        private System.Windows.Forms.Label LabelOpisanie;
        private System.Windows.Forms.PictureBox FotoPictureBox;
        private System.Windows.Forms.ComboBox FilmsComboBox;
    }
}

