namespace Project
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
            this.Panel = new System.Windows.Forms.Panel();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelArgs = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.FotoPictureBox = new System.Windows.Forms.PictureBox();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.labelNumber);
            this.Panel.Controls.Add(this.labelArgs);
            this.Panel.Controls.Add(this.labelAge);
            this.Panel.Controls.Add(this.labelName);
            this.Panel.Controls.Add(this.FotoPictureBox);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel.Location = new System.Drawing.Point(126, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(674, 450);
            this.Panel.TabIndex = 2;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(133, 87);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(66, 13);
            this.labelNumber.TabIndex = 4;
            this.labelNumber.Text = "labelNumber";
            // 
            // labelArgs
            // 
            this.labelArgs.AutoSize = true;
            this.labelArgs.Location = new System.Drawing.Point(133, 65);
            this.labelArgs.Name = "labelArgs";
            this.labelArgs.Size = new System.Drawing.Size(50, 13);
            this.labelArgs.TabIndex = 3;
            this.labelArgs.Text = "labelArgs";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(133, 43);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(48, 13);
            this.labelAge.TabIndex = 2;
            this.labelAge.Text = "labelAge";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(133, 21);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(57, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "labelName";
            // 
            // FotoPictureBox
            // 
            this.FotoPictureBox.Location = new System.Drawing.Point(18, 12);
            this.FotoPictureBox.Name = "FotoPictureBox";
            this.FotoPictureBox.Size = new System.Drawing.Size(100, 135);
            this.FotoPictureBox.TabIndex = 0;
            this.FotoPictureBox.TabStop = false;
            // 
            // ListBox
            // 
            this.ListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.ListBox.FormattingEnabled = true;
            this.ListBox.Location = new System.Drawing.Point(0, 0);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(120, 450);
            this.ListBox.TabIndex = 3;
            this.ListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.Panel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox FotoPictureBox;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelArgs;
        private System.Windows.Forms.Label labelNumber;
    }
}

