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
            this.panelButton = new System.Windows.Forms.Panel();
            this.labelStockName = new System.Windows.Forms.Label();
            this.btn_Test = new System.Windows.Forms.Button();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.bt_Filter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stockConteiner
            // 
            this.stockConteiner.AutoScroll = true;
            this.stockConteiner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stockConteiner.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stockConteiner.Location = new System.Drawing.Point(0, 92);
            this.stockConteiner.Name = "stockConteiner";
            this.stockConteiner.Size = new System.Drawing.Size(369, 385);
            this.stockConteiner.TabIndex = 0;
            // 
            // panelButton
            // 
            this.panelButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButton.Location = new System.Drawing.Point(0, 0);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(369, 63);
            this.panelButton.TabIndex = 1;
            // 
            // labelStockName
            // 
            this.labelStockName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelStockName.AutoSize = true;
            this.labelStockName.Location = new System.Drawing.Point(13, 73);
            this.labelStockName.Name = "labelStockName";
            this.labelStockName.Size = new System.Drawing.Size(114, 13);
            this.labelStockName.TabIndex = 2;
            this.labelStockName.Text = "Строки поставщиков";
            // 
            // btn_Test
            // 
            this.btn_Test.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Test.Location = new System.Drawing.Point(294, 63);
            this.btn_Test.Name = "btn_Test";
            this.btn_Test.Size = new System.Drawing.Size(75, 29);
            this.btn_Test.TabIndex = 3;
            this.btn_Test.Text = "Test";
            this.btn_Test.UseVisualStyleBackColor = true;
            this.btn_Test.Click += new System.EventHandler(this.btn_Test_Click);
            // 
            // updateTimer
            // 
            this.updateTimer.Enabled = true;
            this.updateTimer.Interval = 30000;
            // 
            // bt_Filter
            // 
            this.bt_Filter.Dock = System.Windows.Forms.DockStyle.Right;
            this.bt_Filter.Location = new System.Drawing.Point(219, 63);
            this.bt_Filter.Name = "bt_Filter";
            this.bt_Filter.Size = new System.Drawing.Size(75, 29);
            this.bt_Filter.TabIndex = 4;
            this.bt_Filter.Text = "Filter";
            this.bt_Filter.UseVisualStyleBackColor = true;
            this.bt_Filter.Click += new System.EventHandler(this.bt_Filter_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(144, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(369, 477);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_Filter);
            this.Controls.Add(this.btn_Test);
            this.Controls.Add(this.labelStockName);
            this.Controls.Add(this.panelButton);
            this.Controls.Add(this.stockConteiner);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel stockConteiner;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Label labelStockName;
        private System.Windows.Forms.Button btn_Test;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.Button bt_Filter;
        private System.Windows.Forms.Button button1;
    }
}

