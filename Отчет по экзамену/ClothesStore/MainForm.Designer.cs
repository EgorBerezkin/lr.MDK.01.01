namespace ClothesStore
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonOut = new System.Windows.Forms.Button();
            this.buttonReports = new System.Windows.Forms.Button();
            this.buttonTovars = new System.Windows.Forms.Button();
            this.buttonPokupatel = new System.Windows.Forms.Button();
            this.buttonSale = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Tan;
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.lblUserInfo);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1156, 100);
            this.panelHeader.TabIndex = 0;
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.BackColor = System.Drawing.Color.Tan;
            this.lblUserInfo.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUserInfo.Location = new System.Drawing.Point(319, 60);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(289, 30);
            this.lblUserInfo.TabIndex = 1;
            this.lblUserInfo.Text = "Пользователь: не авторизован";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(350, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(278, 52);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Магазин одежды";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.NavajoWhite;
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.buttonOut);
            this.panelMenu.Controls.Add(this.buttonReports);
            this.panelMenu.Controls.Add(this.buttonTovars);
            this.panelMenu.Controls.Add(this.buttonPokupatel);
            this.panelMenu.Controls.Add(this.buttonSale);
            this.panelMenu.Location = new System.Drawing.Point(0, 100);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 553);
            this.panelMenu.TabIndex = 2;
            // 
            // buttonOut
            // 
            this.buttonOut.BackColor = System.Drawing.Color.Tan;
            this.buttonOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOut.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonOut.Location = new System.Drawing.Point(10, 380);
            this.buttonOut.Name = "buttonOut";
            this.buttonOut.Size = new System.Drawing.Size(200, 75);
            this.buttonOut.TabIndex = 7;
            this.buttonOut.Text = "Выход";
            this.buttonOut.UseVisualStyleBackColor = false;
            this.buttonOut.Click += new System.EventHandler(this.buttonOut_Click);
            // 
            // buttonReports
            // 
            this.buttonReports.BackColor = System.Drawing.Color.Tan;
            this.buttonReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReports.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonReports.Location = new System.Drawing.Point(10, 290);
            this.buttonReports.Name = "buttonReports";
            this.buttonReports.Size = new System.Drawing.Size(200, 75);
            this.buttonReports.TabIndex = 6;
            this.buttonReports.Text = "Отчёт по выручке";
            this.buttonReports.UseVisualStyleBackColor = false;
            this.buttonReports.Click += new System.EventHandler(this.buttonReports_Click);
            // 
            // buttonTovars
            // 
            this.buttonTovars.BackColor = System.Drawing.Color.Tan;
            this.buttonTovars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTovars.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTovars.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonTovars.Location = new System.Drawing.Point(10, 200);
            this.buttonTovars.Name = "buttonTovars";
            this.buttonTovars.Size = new System.Drawing.Size(200, 75);
            this.buttonTovars.TabIndex = 5;
            this.buttonTovars.Text = "Товары";
            this.buttonTovars.UseVisualStyleBackColor = false;
            this.buttonTovars.Click += new System.EventHandler(this.buttonTovars_Click);
            // 
            // buttonPokupatel
            // 
            this.buttonPokupatel.BackColor = System.Drawing.Color.Tan;
            this.buttonPokupatel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPokupatel.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPokupatel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonPokupatel.Location = new System.Drawing.Point(10, 110);
            this.buttonPokupatel.Name = "buttonPokupatel";
            this.buttonPokupatel.Size = new System.Drawing.Size(200, 75);
            this.buttonPokupatel.TabIndex = 4;
            this.buttonPokupatel.Text = "Клиенты";
            this.buttonPokupatel.UseVisualStyleBackColor = false;
            this.buttonPokupatel.Click += new System.EventHandler(this.buttonPokupatel_Click);
            // 
            // buttonSale
            // 
            this.buttonSale.BackColor = System.Drawing.Color.Tan;
            this.buttonSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSale.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonSale.Location = new System.Drawing.Point(10, 20);
            this.buttonSale.Name = "buttonSale";
            this.buttonSale.Size = new System.Drawing.Size(200, 75);
            this.buttonSale.TabIndex = 3;
            this.buttonSale.Text = "Оформить продажу";
            this.buttonSale.UseVisualStyleBackColor = false;
            this.buttonSale.Click += new System.EventHandler(this.buttonSale_Click_1);
            // 
            // panelContent
            // 
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContent.Location = new System.Drawing.Point(217, 100);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(948, 523);
            this.panelContent.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1155, 597);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Система учёта магазина одежды";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonSale;
        private System.Windows.Forms.Button buttonPokupatel;
        private System.Windows.Forms.Button buttonTovars;
        private System.Windows.Forms.Button buttonOut;
        private System.Windows.Forms.Button buttonReports;
        private System.Windows.Forms.Panel panelContent;
    }
}

