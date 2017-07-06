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
            this.button1 = new System.Windows.Forms.Button();
            this.cb_TopMost = new System.Windows.Forms.CheckBox();
            this.btn_Archive = new System.Windows.Forms.Button();
            this.btn_MailSend = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.bt_Filter = new System.Windows.Forms.Button();
            this.labelAllFor = new System.Windows.Forms.Label();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.chBox_AutoRefresh = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.panelButton.Controls.Add(this.button1);
            this.panelButton.Controls.Add(this.cb_TopMost);
            this.panelButton.Controls.Add(this.btn_Archive);
            this.panelButton.Controls.Add(this.btn_MailSend);
            this.panelButton.Controls.Add(this.btn_Refresh);
            this.panelButton.Controls.Add(this.bt_Filter);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButton.Location = new System.Drawing.Point(0, 0);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(369, 49);
            this.panelButton.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 10);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cb_TopMost
            // 
            this.cb_TopMost.AutoSize = true;
            this.cb_TopMost.Location = new System.Drawing.Point(183, 23);
            this.cb_TopMost.Name = "cb_TopMost";
            this.cb_TopMost.Size = new System.Drawing.Size(15, 14);
            this.cb_TopMost.TabIndex = 7;
            this.cb_TopMost.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btn_Archive
            // 
            this.btn_Archive.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Archive.AutoSize = true;
            this.btn_Archive.Location = new System.Drawing.Point(289, 16);
            this.btn_Archive.Name = "btn_Archive";
            this.btn_Archive.Size = new System.Drawing.Size(75, 29);
            this.btn_Archive.TabIndex = 6;
            this.btn_Archive.Text = "Архивация";
            this.btn_Archive.UseVisualStyleBackColor = true;
            this.btn_Archive.Click += new System.EventHandler(this.btn_Archive_Click);
            // 
            // btn_MailSend
            // 
            this.btn_MailSend.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_MailSend.AutoSize = true;
            this.btn_MailSend.Location = new System.Drawing.Point(208, 15);
            this.btn_MailSend.Name = "btn_MailSend";
            this.btn_MailSend.Size = new System.Drawing.Size(75, 29);
            this.btn_MailSend.TabIndex = 5;
            this.btn_MailSend.Text = "Письмо";
            this.btn_MailSend.UseVisualStyleBackColor = true;
            this.btn_MailSend.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(11, 15);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 29);
            this.btn_Refresh.TabIndex = 3;
            this.btn_Refresh.Text = "Обновить";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Test_Click);
            // 
            // bt_Filter
            // 
            this.bt_Filter.Location = new System.Drawing.Point(92, 15);
            this.bt_Filter.Name = "bt_Filter";
            this.bt_Filter.Size = new System.Drawing.Size(85, 29);
            this.bt_Filter.TabIndex = 4;
            this.bt_Filter.Text = "Фильтровать";
            this.bt_Filter.UseVisualStyleBackColor = true;
            this.bt_Filter.Click += new System.EventHandler(this.bt_Filter_Click);
            // 
            // labelAllFor
            // 
            this.labelAllFor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAllFor.AutoSize = true;
            this.labelAllFor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelAllFor.Location = new System.Drawing.Point(241, 52);
            this.labelAllFor.Name = "labelAllFor";
            this.labelAllFor.Size = new System.Drawing.Size(0, 13);
            this.labelAllFor.TabIndex = 0;
            this.labelAllFor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // updateTimer
            // 
            this.updateTimer.Interval = 30000;
            // 
            // chBox_AutoRefresh
            // 
            this.chBox_AutoRefresh.AutoSize = true;
            this.chBox_AutoRefresh.Location = new System.Drawing.Point(12, 51);
            this.chBox_AutoRefresh.Name = "chBox_AutoRefresh";
            this.chBox_AutoRefresh.Size = new System.Drawing.Size(149, 17);
            this.chBox_AutoRefresh.TabIndex = 7;
            this.chBox_AutoRefresh.Text = "Обновлять автоматички";
            this.chBox_AutoRefresh.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 483);
            this.Controls.Add(this.chBox_AutoRefresh);
            this.Controls.Add(this.panelButton);
            this.Controls.Add(this.labelAllFor);
            this.Controls.Add(this.stockConteiner);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(385, 1000);
            this.MinimumSize = new System.Drawing.Size(385, 300);
            this.Name = "Form1";
            this.Text = "Контроль остатков";
            this.stockConteiner.ResumeLayout(false);
            this.panelButton.ResumeLayout(false);
            this.panelButton.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btn_Archive;
        private System.Windows.Forms.CheckBox chBox_AutoRefresh;
        private System.Windows.Forms.CheckBox cb_TopMost;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

