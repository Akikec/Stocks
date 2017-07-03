namespace StockController
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.tb_SelfStock = new System.Windows.Forms.TextBox();
            this.tb_TargetStock = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Archive = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_MainFile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_LastWorkDate = new System.Windows.Forms.Label();
            this.bt_Save = new System.Windows.Forms.Button();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.bt_Color_Correct = new System.Windows.Forms.Button();
            this.bt_Color_Incorrect = new System.Windows.Forms.Button();
            this.bt_Color_Nothing = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_SaveStatus = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.bt_FDialog = new System.Windows.Forms.Button();
            this.bt_BDialog1 = new System.Windows.Forms.Button();
            this.bt_BDialog2 = new System.Windows.Forms.Button();
            this.bt_BDialog3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Остатки на компьютере:";
            // 
            // tb_SelfStock
            // 
            this.tb_SelfStock.Location = new System.Drawing.Point(12, 73);
            this.tb_SelfStock.Name = "tb_SelfStock";
            this.tb_SelfStock.Size = new System.Drawing.Size(327, 20);
            this.tb_SelfStock.TabIndex = 2;
            this.tb_SelfStock.Text = global::StockController.Properties.Settings.Default.self_Stock;
            // 
            // tb_TargetStock
            // 
            this.tb_TargetStock.Location = new System.Drawing.Point(12, 112);
            this.tb_TargetStock.Name = "tb_TargetStock";
            this.tb_TargetStock.Size = new System.Drawing.Size(327, 20);
            this.tb_TargetStock.TabIndex = 4;
            this.tb_TargetStock.Text = global::StockController.Properties.Settings.Default.target_Stock;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Остатки в общей папке:";
            // 
            // tb_Archive
            // 
            this.tb_Archive.Location = new System.Drawing.Point(12, 153);
            this.tb_Archive.Name = "tb_Archive";
            this.tb_Archive.Size = new System.Drawing.Size(327, 20);
            this.tb_Archive.TabIndex = 6;
            this.tb_Archive.Text = global::StockController.Properties.Settings.Default.archive_Stock;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Папка с архивами:";
            // 
            // tb_MainFile
            // 
            this.tb_MainFile.Location = new System.Drawing.Point(12, 34);
            this.tb_MainFile.Name = "tb_MainFile";
            this.tb_MainFile.Size = new System.Drawing.Size(327, 20);
            this.tb_MainFile.TabIndex = 8;
            this.tb_MainFile.Text = global::StockController.Properties.Settings.Default.file_StocksList;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Файл с информацие по остаткам:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Последняя дата входа:";
            // 
            // lb_LastWorkDate
            // 
            this.lb_LastWorkDate.AutoSize = true;
            this.lb_LastWorkDate.Location = new System.Drawing.Point(139, 176);
            this.lb_LastWorkDate.Name = "lb_LastWorkDate";
            this.lb_LastWorkDate.Size = new System.Drawing.Size(64, 13);
            this.lb_LastWorkDate.TabIndex = 10;
            this.lb_LastWorkDate.Text = "нет данных";
            // 
            // bt_Save
            // 
            this.bt_Save.Location = new System.Drawing.Point(14, 273);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(120, 23);
            this.bt_Save.TabIndex = 11;
            this.bt_Save.Text = "Сохранить";
            this.bt_Save.UseVisualStyleBackColor = true;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Location = new System.Drawing.Point(258, 273);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(116, 23);
            this.bt_Cancel.TabIndex = 12;
            this.bt_Cancel.Text = "Отмена";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // bt_Color_Correct
            // 
            this.bt_Color_Correct.BackColor = global::StockController.Properties.Settings.Default.color_Correct;
            this.bt_Color_Correct.Location = new System.Drawing.Point(18, 20);
            this.bt_Color_Correct.Name = "bt_Color_Correct";
            this.bt_Color_Correct.Size = new System.Drawing.Size(30, 30);
            this.bt_Color_Correct.TabIndex = 13;
            this.bt_Color_Correct.UseVisualStyleBackColor = false;
            this.bt_Color_Correct.Click += new System.EventHandler(this.bt_Color_Correct_Click);
            // 
            // bt_Color_Incorrect
            // 
            this.bt_Color_Incorrect.BackColor = global::StockController.Properties.Settings.Default.color_Incorrect;
            this.bt_Color_Incorrect.Location = new System.Drawing.Point(119, 20);
            this.bt_Color_Incorrect.Name = "bt_Color_Incorrect";
            this.bt_Color_Incorrect.Size = new System.Drawing.Size(30, 30);
            this.bt_Color_Incorrect.TabIndex = 14;
            this.bt_Color_Incorrect.UseVisualStyleBackColor = false;
            this.bt_Color_Incorrect.Click += new System.EventHandler(this.bt_Color_Incorrect_Click);
            // 
            // bt_Color_Nothing
            // 
            this.bt_Color_Nothing.BackColor = global::StockController.Properties.Settings.Default.color_Nothing;
            this.bt_Color_Nothing.Location = new System.Drawing.Point(245, 20);
            this.bt_Color_Nothing.Name = "bt_Color_Nothing";
            this.bt_Color_Nothing.Size = new System.Drawing.Size(30, 30);
            this.bt_Color_Nothing.TabIndex = 15;
            this.bt_Color_Nothing.UseVisualStyleBackColor = false;
            this.bt_Color_Nothing.Click += new System.EventHandler(this.bt_Color_Nothing_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Готово";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(155, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Некорректный";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(281, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Отсутствует";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.bt_Color_Correct);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.bt_Color_Incorrect);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.bt_Color_Nothing);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 53);
            this.panel1.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(54, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(256, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Цветовая схема, отображения наличия остатков";
            // 
            // lb_SaveStatus
            // 
            this.lb_SaveStatus.AutoSize = true;
            this.lb_SaveStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_SaveStatus.Location = new System.Drawing.Point(24, 253);
            this.lb_SaveStatus.Name = "lb_SaveStatus";
            this.lb_SaveStatus.Size = new System.Drawing.Size(0, 13);
            this.lb_SaveStatus.TabIndex = 20;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Файл с остатками|*.csv";
            // 
            // bt_FDialog
            // 
            this.bt_FDialog.Location = new System.Drawing.Point(345, 34);
            this.bt_FDialog.Name = "bt_FDialog";
            this.bt_FDialog.Size = new System.Drawing.Size(29, 20);
            this.bt_FDialog.TabIndex = 21;
            this.bt_FDialog.Text = "...";
            this.bt_FDialog.UseVisualStyleBackColor = true;
            this.bt_FDialog.Click += new System.EventHandler(this.bt_FDialog_Click);
            // 
            // bt_BDialog1
            // 
            this.bt_BDialog1.Location = new System.Drawing.Point(345, 73);
            this.bt_BDialog1.Name = "bt_BDialog1";
            this.bt_BDialog1.Size = new System.Drawing.Size(29, 20);
            this.bt_BDialog1.TabIndex = 22;
            this.bt_BDialog1.Text = "...";
            this.bt_BDialog1.UseVisualStyleBackColor = true;
            this.bt_BDialog1.Click += new System.EventHandler(this.bt_BDialog1_Click);
            // 
            // bt_BDialog2
            // 
            this.bt_BDialog2.Location = new System.Drawing.Point(345, 112);
            this.bt_BDialog2.Name = "bt_BDialog2";
            this.bt_BDialog2.Size = new System.Drawing.Size(29, 20);
            this.bt_BDialog2.TabIndex = 23;
            this.bt_BDialog2.Text = "...";
            this.bt_BDialog2.UseVisualStyleBackColor = true;
            this.bt_BDialog2.Click += new System.EventHandler(this.bt_BDialog2_Click);
            // 
            // bt_BDialog3
            // 
            this.bt_BDialog3.Location = new System.Drawing.Point(345, 153);
            this.bt_BDialog3.Name = "bt_BDialog3";
            this.bt_BDialog3.Size = new System.Drawing.Size(29, 20);
            this.bt_BDialog3.TabIndex = 24;
            this.bt_BDialog3.Text = "...";
            this.bt_BDialog3.UseVisualStyleBackColor = true;
            this.bt_BDialog3.Click += new System.EventHandler(this.bt_BDialog3_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 308);
            this.ControlBox = false;
            this.Controls.Add(this.bt_BDialog3);
            this.Controls.Add(this.bt_BDialog2);
            this.Controls.Add(this.bt_BDialog1);
            this.Controls.Add(this.bt_FDialog);
            this.Controls.Add(this.lb_SaveStatus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_Save);
            this.Controls.Add(this.lb_LastWorkDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_MainFile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_Archive);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_TargetStock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_SelfStock);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(402, 347);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(402, 347);
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.Text = "Настройки";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_SelfStock;
        private System.Windows.Forms.TextBox tb_TargetStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Archive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_MainFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_LastWorkDate;
        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button bt_Color_Correct;
        private System.Windows.Forms.Button bt_Color_Incorrect;
        private System.Windows.Forms.Button bt_Color_Nothing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_SaveStatus;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button bt_FDialog;
        private System.Windows.Forms.Button bt_BDialog1;
        private System.Windows.Forms.Button bt_BDialog2;
        private System.Windows.Forms.Button bt_BDialog3;
    }
}