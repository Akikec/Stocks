using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StockController
{
    public partial class SettingsForm : Form
    {


        public SettingsForm(bool bt_cancel_cheak)
        {
            InitializeComponent();
            bt_Cancel.Enabled = bt_cancel_cheak;
            lb_LastWorkDate.Text = Properties.Settings.Default.lastWorkDate.ToString("dd MMMM");
        }

        #region Color
        private void bt_Color_Correct_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                bt_Color_Correct.BackColor = colorDialog1.Color;
            }
        }

        private void bt_Color_Incorrect_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                bt_Color_Incorrect.BackColor = colorDialog1.Color;
            }
        }

        private void bt_Color_Nothing_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                bt_Color_Nothing.BackColor = colorDialog1.Color;
            }
        }

        #endregion

        private void bt_Save_Click(object sender, EventArgs e)
        {
            //Проверка и Сохранение всех параметров
            if(CheackSettings())
            {
                Properties.Settings.Default.target_Stock = tb_TargetStock.Text;
                Properties.Settings.Default.self_Stock = tb_SelfStock.Text;
                Properties.Settings.Default.file_StocksList = tb_MainFile.Text;
                Properties.Settings.Default.archive_Stock = tb_Archive.Text;
                Properties.Settings.Default.color_Correct = bt_Color_Correct.BackColor;
                Properties.Settings.Default.color_Incorrect = bt_Color_Incorrect.BackColor;
                Properties.Settings.Default.color_Nothing = bt_Color_Nothing.BackColor;
                //Properties.Settings.Default.first_Launch = true;
                Properties.Settings.Default.Save();
                
                lb_SaveStatus.Font = new Font(lb_SaveStatus.Font, FontStyle.Bold);
                lb_SaveStatus.Text = "Все настройки сохранены";
                bt_Cancel.Enabled = true;
                Refresh();
                System.Threading.Thread.Sleep(250);
                this.Close();
            }
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool CheackSettings()
        {
            if (!File.Exists(tb_MainFile.Text))
            {
                lb_SaveStatus.Text = "По указанному пути не существует файла .csv";
                return false;
            }
            DirectoryInfo[] dir = { new DirectoryInfo(tb_SelfStock.Text), new DirectoryInfo(tb_TargetStock.Text), new DirectoryInfo(tb_Archive.Text) };
            for(int i=0; i<3; i++)
            {
                if (dir[i].Exists == false)
                {
                    lb_SaveStatus.Text = "Один из указанных каталогов не существует";
                    return false;
                }
            }
            return true;
        }

        #region Dialog Buttons
        private void bt_FDialog_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            tb_MainFile.Text = openFileDialog1.FileName;
        }

        private void bt_BDialog1_Click(object sender, EventArgs e)
        {

            tb_SelfStock.Text = Folder();
        }

        private void bt_BDialog2_Click(object sender, EventArgs e)
        {
            tb_TargetStock.Text = Folder();
        }

        private void bt_BDialog3_Click(object sender, EventArgs e)
        {
            tb_Archive.Text = Folder();
        }

        private string Folder()
        {
            folderBrowserDialog1.ShowDialog();
            return folderBrowserDialog1.SelectedPath;
        }
        #endregion
    }
}
