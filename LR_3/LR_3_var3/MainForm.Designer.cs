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
            this.RichTextBox = new System.Windows.Forms.RichTextBox();
            this.OtchetButton = new System.Windows.Forms.Button();
            this.FilmsComboBox = new System.Windows.Forms.ComboBox();
            this.LabelNumber = new System.Windows.Forms.Label();
            this.LabelSum = new System.Windows.Forms.Label();
            this.LabelDate = new System.Windows.Forms.Label();
            this.LabelRecjiser = new System.Windows.Forms.Label();
            this.LabelOpisanie = new System.Windows.Forms.Label();
            this.FotoPictureBox = new System.Windows.Forms.PictureBox();
            this.FilmsListBox = new System.Windows.Forms.ListBox();
            this.Button_dobav = new System.Windows.Forms.Button();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelNaimenowanie
            // 
            this.LabelNaimenowanie.AutoSize = true;
            this.LabelNaimenowanie.Location = new System.Drawing.Point(192, 20);
            this.LabelNaimenowanie.Name = "LabelNaimenowanie";
            this.LabelNaimenowanie.Size = new System.Drawing.Size(35, 13);
            this.LabelNaimenowanie.TabIndex = 0;
            this.LabelNaimenowanie.Text = "label1";
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.DarkKhaki;
            this.Panel.Controls.Add(this.Button_dobav);
            this.Panel.Controls.Add(this.RichTextBox);
            this.Panel.Controls.Add(this.OtchetButton);
            this.Panel.Controls.Add(this.FilmsComboBox);
            this.Panel.Controls.Add(this.LabelNumber);
            this.Panel.Controls.Add(this.LabelSum);
            this.Panel.Controls.Add(this.LabelDate);
            this.Panel.Controls.Add(this.LabelRecjiser);
            this.Panel.Controls.Add(this.LabelOpisanie);
            this.Panel.Controls.Add(this.FotoPictureBox);
            this.Panel.Controls.Add(this.LabelNaimenowanie);
            this.Panel.Location = new System.Drawing.Point(134, -2);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(692, 400);
            this.Panel.TabIndex = 1;
            // 
            // RichTextBox
            // 
            this.RichTextBox.BackColor = System.Drawing.Color.DarkKhaki;
            this.RichTextBox.Location = new System.Drawing.Point(0, 292);
            this.RichTextBox.Name = "RichTextBox";
            this.RichTextBox.Size = new System.Drawing.Size(692, 108);
            this.RichTextBox.TabIndex = 8;
            this.RichTextBox.Text = "";
            // 
            // OtchetButton
            // 
            this.OtchetButton.BackColor = System.Drawing.Color.RosyBrown;
            this.OtchetButton.Location = new System.Drawing.Point(579, 231);
            this.OtchetButton.Name = "OtchetButton";
            this.OtchetButton.Size = new System.Drawing.Size(102, 39);
            this.OtchetButton.TabIndex = 7;
            this.OtchetButton.Text = "Отчёт";
            this.OtchetButton.UseVisualStyleBackColor = false;
            this.OtchetButton.Click += new System.EventHandler(this.OtchetButton_Click);
            // 
            // FilmsComboBox
            // 
            this.FilmsComboBox.BackColor = System.Drawing.Color.DarkGray;
            this.FilmsComboBox.FormattingEnabled = true;
            this.FilmsComboBox.Location = new System.Drawing.Point(277, 17);
            this.FilmsComboBox.Name = "FilmsComboBox";
            this.FilmsComboBox.Size = new System.Drawing.Size(197, 21);
            this.FilmsComboBox.TabIndex = 2;
            this.FilmsComboBox.SelectedIndexChanged += new System.EventHandler(this.FilmsComboBox_SelectedIndexChanged);
            // 
            // LabelNumber
            // 
            this.LabelNumber.AutoSize = true;
            this.LabelNumber.Location = new System.Drawing.Point(328, 167);
            this.LabelNumber.Name = "LabelNumber";
            this.LabelNumber.Size = new System.Drawing.Size(35, 13);
            this.LabelNumber.TabIndex = 6;
            this.LabelNumber.Text = "label6";
            // 
            // LabelSum
            // 
            this.LabelSum.AutoSize = true;
            this.LabelSum.Location = new System.Drawing.Point(192, 188);
            this.LabelSum.Name = "LabelSum";
            this.LabelSum.Size = new System.Drawing.Size(35, 13);
            this.LabelSum.TabIndex = 5;
            this.LabelSum.Text = "label5";
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Location = new System.Drawing.Point(192, 167);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(35, 13);
            this.LabelDate.TabIndex = 4;
            this.LabelDate.Text = "label4";
            // 
            // LabelRecjiser
            // 
            this.LabelRecjiser.AutoSize = true;
            this.LabelRecjiser.Location = new System.Drawing.Point(192, 147);
            this.LabelRecjiser.Name = "LabelRecjiser";
            this.LabelRecjiser.Size = new System.Drawing.Size(35, 13);
            this.LabelRecjiser.TabIndex = 3;
            this.LabelRecjiser.Text = "label3";
            // 
            // LabelOpisanie
            // 
            this.LabelOpisanie.AutoSize = true;
            this.LabelOpisanie.Location = new System.Drawing.Point(192, 47);
            this.LabelOpisanie.Name = "LabelOpisanie";
            this.LabelOpisanie.Size = new System.Drawing.Size(35, 13);
            this.LabelOpisanie.TabIndex = 2;
            this.LabelOpisanie.Text = "label2";
            // 
            // FotoPictureBox
            // 
            this.FotoPictureBox.Location = new System.Drawing.Point(3, 12);
            this.FotoPictureBox.Name = "FotoPictureBox";
            this.FotoPictureBox.Size = new System.Drawing.Size(158, 226);
            this.FotoPictureBox.TabIndex = 1;
            this.FotoPictureBox.TabStop = false;
            // 
            // FilmsListBox
            // 
            this.FilmsListBox.BackColor = System.Drawing.Color.RosyBrown;
            this.FilmsListBox.FormattingEnabled = true;
            this.FilmsListBox.Location = new System.Drawing.Point(-1, -2);
            this.FilmsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.FilmsListBox.Name = "FilmsListBox";
            this.FilmsListBox.Size = new System.Drawing.Size(136, 407);
            this.FilmsListBox.TabIndex = 2;
            this.FilmsListBox.SelectedIndexChanged += new System.EventHandler(this.FilmsListBox_SelectedIndexChanged);
            // 
            // Button_dobav
            // 
            this.Button_dobav.BackColor = System.Drawing.Color.RosyBrown;
            this.Button_dobav.Location = new System.Drawing.Point(471, 231);
            this.Button_dobav.Name = "Button_dobav";
            this.Button_dobav.Size = new System.Drawing.Size(102, 39);
            this.Button_dobav.TabIndex = 9;
            this.Button_dobav.Text = "Добавить";
            this.Button_dobav.UseVisualStyleBackColor = false;
            this.Button_dobav.Click += new System.EventHandler(this.Button_dobav_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(827, 397);
            this.Controls.Add(this.FilmsListBox);
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
        private System.Windows.Forms.ListBox FilmsListBox;
        private System.Windows.Forms.Button OtchetButton;
        private System.Windows.Forms.RichTextBox RichTextBox;
        private System.Windows.Forms.Button Button_dobav;
    }
}

