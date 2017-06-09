namespace StockController
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.stockConteiner = new System.Windows.Forms.Panel();
            this.labelStockName = new System.Windows.Forms.Label();
            this.panelButton = new System.Windows.Forms.Panel();
            this.btn_MailSend = new System.Windows.Forms.Button();
            this.labelAllFor = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.bt_Filter = new System.Windows.Forms.Button();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.stockConteiner.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // stockConteiner
            // 
            this.stockConteiner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stockConteiner.AutoScroll = true;
            this.stockConteiner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stockConteiner.CausesValidation = false;
            this.stockConteiner.Controls.Add(this.labelStockName);
            this.stockConteiner.Location = new System.Drawing.Point(0, 69);
            this.stockConteiner.Name = "stockConteiner";
            this.stockConteiner.Size = new System.Drawing.Size(369, 415);
            this.stockConteiner.TabIndex = 0;
            // 
            // labelStockName
            // 
            this.labelStockName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelStockName.Location = new System.Drawing.Point(11, 0);
            this.labelStockName.Name = "labelStockName";
            this.labelStockName.Size = new System.Drawing.Size(124, 13);
            this.labelStockName.TabIndex = 2;
            this.labelStockName.Text = "Строки поставщиков:";
            // 
            // panelButton
            // 
            this.panelButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelButton.CausesValidation = false;
            this.panelButton.Controls.Add(this.btn_MailSend);
            this.panelButton.Controls.Add(this.labelAllFor);
            this.panelButton.Controls.Add(this.btn_Refresh);
            this.panelButton.Controls.Add(this.bt_Filter);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButton.Location = new System.Drawing.Point(0, 0);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(369, 63);
            this.panelButton.TabIndex = 1;
            // 
            // btn_MailSend
            // 
            this.btn_MailSend.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_MailSend.AutoSize = true;
            this.btn_MailSend.Location = new System.Drawing.Point(121, 33);
            this.btn_MailSend.Name = "btn_MailSend";
            this.btn_MailSend.Size = new System.Drawing.Size(75, 29);
            this.btn_MailSend.TabIndex = 5;
            this.btn_MailSend.Text = "Письмо";
            this.btn_MailSend.UseVisualStyleBackColor = true;
            this.btn_MailSend.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelAllFor
            // 
            this.labelAllFor.AutoSize = true;
            this.labelAllFor.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelAllFor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelAllFor.Location = new System.Drawing.Point(367, 0);
            this.labelAllFor.Name = "labelAllFor";
            this.labelAllFor.Size = new System.Drawing.Size(0, 13);
            this.labelAllFor.TabIndex = 0;
            this.labelAllFor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(293, 33);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 29);
            this.btn_Refresh.TabIndex = 3;
            this.btn_Refresh.Text = "Обновить";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Test_Click);
            // 
            // bt_Filter
            // 
            this.bt_Filter.Location = new System.Drawing.Point(202, 33);
            this.bt_Filter.Name = "bt_Filter";
            this.bt_Filter.Size = new System.Drawing.Size(85, 29);
            this.bt_Filter.TabIndex = 4;
            this.bt_Filter.Text = "Фильтровать";
            this.bt_Filter.UseVisualStyleBackColor = true;
            this.bt_Filter.Click += new System.EventHandler(this.bt_Filter_Click);
            // 
            // updateTimer
            // 
            this.updateTimer.Enabled = true;
            this.updateTimer.Interval = 9999;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 483);
            this.Controls.Add(this.panelButton);
            this.Controls.Add(this.stockConteiner);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(385, 1000);
            this.MinimumSize = new System.Drawing.Size(385, 300);
            this.Name = "Form1";
            this.Text = "Form1";
            this.stockConteiner.ResumeLayout(false);
            this.panelButton.ResumeLayout(false);
            this.panelButton.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel stockConteiner;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Label labelStockName;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.Button bt_Filter;
        private System.Windows.Forms.Button btn_MailSend;
        private System.Windows.Forms.Label labelAllFor;
    }
}

