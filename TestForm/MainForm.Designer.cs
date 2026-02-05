namespace TestForm
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
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EnterButton = new System.Windows.Forms.Button();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginСomboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLabel.Location = new System.Drawing.Point(12, 41);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PasswordLabel.Size = new System.Drawing.Size(124, 18);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = ":Введите пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(53, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 3;
            // 
            // EnterButton
            // 
            this.EnterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.EnterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EnterButton.Location = new System.Drawing.Point(311, 7);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(108, 54);
            this.EnterButton.TabIndex = 4;
            this.EnterButton.Text = "Войти";
            this.EnterButton.UseVisualStyleBackColor = false;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.Location = new System.Drawing.Point(16, 9);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LoginLabel.Size = new System.Drawing.Size(114, 18);
            this.LoginLabel.TabIndex = 5;
            this.LoginLabel.Text = ":Введите логин";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(142, 39);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(164, 20);
            this.PasswordTextBox.TabIndex = 6;
            // 
            // LoginСomboBox
            // 
            this.LoginСomboBox.FormattingEnabled = true;
            this.LoginСomboBox.Location = new System.Drawing.Point(142, 7);
            this.LoginСomboBox.Name = "LoginСomboBox";
            this.LoginСomboBox.Size = new System.Drawing.Size(164, 21);
            this.LoginСomboBox.TabIndex = 7;
            this.LoginСomboBox.SelectedIndexChanged += new System.EventHandler(this.LoginСomboBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(431, 73);
            this.Controls.Add(this.LoginСomboBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PasswordLabel);
            this.Name = "MainForm";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.ComboBox LoginСomboBox;
    }
}

