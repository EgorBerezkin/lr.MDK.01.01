namespace Biblioteka
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
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewKnigi = new System.Windows.Forms.DataGridView();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSortirovat = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonNaiti = new System.Windows.Forms.Button();
            this.buttonDobav = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKnigi)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(92, 349);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(189, 22);
            this.textBoxGenre.TabIndex = 27;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(92, 320);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(189, 22);
            this.textBoxYear.TabIndex = 26;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(92, 291);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(189, 22);
            this.textBoxAuthor.TabIndex = 25;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(92, 262);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(189, 22);
            this.textBoxTitle.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Жанр";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Год";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Автор";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Название";
            // 
            // dataGridViewKnigi
            // 
            this.dataGridViewKnigi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKnigi.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewKnigi.Name = "dataGridViewKnigi";
            this.dataGridViewKnigi.RowHeadersWidth = 51;
            this.dataGridViewKnigi.RowTemplate.Height = 24;
            this.dataGridViewKnigi.Size = new System.Drawing.Size(431, 231);
            this.dataGridViewKnigi.TabIndex = 19;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(327, 372);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(116, 23);
            this.buttonClear.TabIndex = 18;
            this.buttonClear.Text = "Очичтить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSortirovat
            // 
            this.buttonSortirovat.Location = new System.Drawing.Point(327, 343);
            this.buttonSortirovat.Name = "buttonSortirovat";
            this.buttonSortirovat.Size = new System.Drawing.Size(116, 23);
            this.buttonSortirovat.TabIndex = 17;
            this.buttonSortirovat.Text = "Сортировать";
            this.buttonSortirovat.UseVisualStyleBackColor = true;
            this.buttonSortirovat.Click += new System.EventHandler(this.buttonSortirovat_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(327, 314);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(116, 23);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonNaiti
            // 
            this.buttonNaiti.Location = new System.Drawing.Point(327, 285);
            this.buttonNaiti.Name = "buttonNaiti";
            this.buttonNaiti.Size = new System.Drawing.Size(116, 23);
            this.buttonNaiti.TabIndex = 15;
            this.buttonNaiti.Text = "Найти";
            this.buttonNaiti.UseVisualStyleBackColor = true;
            this.buttonNaiti.Click += new System.EventHandler(this.buttonNaiti_Click);
            // 
            // buttonDobav
            // 
            this.buttonDobav.Location = new System.Drawing.Point(327, 256);
            this.buttonDobav.Name = "buttonDobav";
            this.buttonDobav.Size = new System.Drawing.Size(116, 23);
            this.buttonDobav.TabIndex = 14;
            this.buttonDobav.Text = "Добавить";
            this.buttonDobav.UseVisualStyleBackColor = true;
            this.buttonDobav.Click += new System.EventHandler(this.buttonDobav_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 406);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewKnigi);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSortirovat);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonNaiti);
            this.Controls.Add(this.buttonDobav);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKnigi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewKnigi;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSortirovat;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonNaiti;
        private System.Windows.Forms.Button buttonDobav;
    }
}

