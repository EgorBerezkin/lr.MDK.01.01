namespace Homosapiens
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
            this.StudentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.HomosapiensRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StudentRichTextBox
            // 
            this.StudentRichTextBox.Location = new System.Drawing.Point(13, 49);
            this.StudentRichTextBox.Name = "StudentRichTextBox";
            this.StudentRichTextBox.Size = new System.Drawing.Size(190, 96);
            this.StudentRichTextBox.TabIndex = 0;
            this.StudentRichTextBox.Text = "";
            // 
            // HomosapiensRichTextBox
            // 
            this.HomosapiensRichTextBox.Location = new System.Drawing.Point(222, 49);
            this.HomosapiensRichTextBox.Name = "HomosapiensRichTextBox";
            this.HomosapiensRichTextBox.Size = new System.Drawing.Size(190, 96);
            this.HomosapiensRichTextBox.TabIndex = 1;
            this.HomosapiensRichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Список студентов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(222, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Список людей";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(432, 162);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HomosapiensRichTextBox);
            this.Controls.Add(this.StudentRichTextBox);
            this.Name = "MainForm";
            this.Text = "Списки людей и студентов";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox StudentRichTextBox;
        private System.Windows.Forms.RichTextBox HomosapiensRichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

