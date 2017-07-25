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
    public partial class Form1 : Form
    {
        CompleteRow _cRow = new CompleteRow();

        public Form1()
        {
            InitializeComponent();
            InitializeBackgroundWorker();

            if (!Properties.Settings.Default.first_Launch)
            {
                //Первый вызов окна с настройками
                OpenSettingsForm(Properties.Settings.Default.first_Launch);

            }
            else
            {
                StockMain();
            }
        }

        private void InitializeBackgroundWorker()
        {
            backgroundWorker1.DoWork +=
                new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.RunWorkerCompleted +=
                new RunWorkerCompletedEventHandler(
            backgroundWorker1_RunWorkerCompleted);
            backgroundWorker1.ProgressChanged +=
                new ProgressChangedEventHandler(
            backgroundWorker1_ProgressChanged);
        }

        private void StockMain()
        {
            _cRow.Main(stockConteiner);
            _cRow.AvailableCheak();
            RefreshStock();
            updateTimer.Interval = 30000;
            updateTimer.Tick += _timer_Tick;
            updateTimer.Start();
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            if(chBox_AutoRefresh.Checked == true)
            {
                _cRow.AvailableCheak();
                _cRow.FilterStock();
            }
            RefreshStock();
        }
        private void RefreshStock()
        {
            //_cRow.AvailableCheak();
            int[] sum = _cRow.GetStatus();
            labelAllFor.Text = String.Format("Выполнено {0}({1}) из {2}", sum[0], sum[1], sum[2]);
        }

        private void btn_Test_Click(object sender, EventArgs e)
        {
            _cRow.AvailableCheak();
        }

        private void bt_Filter_Click(object sender, EventArgs e)
        {
            _cRow.AvailableCheak();
            _cRow.FilterStock();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _cRow.AvailableCheak();
            OutlookMail.CreateMail("Нет остатков", "product@elecomt.ru", _cRow.AvailableSend());
        }

        #region D&D
        public static void Form_DragDrop(object sender, DragEventArgs e)
        {
            TextBox _thistb = (TextBox)sender;
            Form1 _thisForm = (Form1)_thistb.FindForm();
            try
            {
                OutlookDataObject dataObject = new OutlookDataObject(e.Data);
                //string ss = sender.GetType().Name;
                string stockname = _thistb.Text;

                //get the names and data streams of the files dropped
                string[] filenames = (string[])dataObject.GetData("FileGroupDescriptor");
                MemoryStream[] filestreams = (MemoryStream[])dataObject.GetData("FileContents");

                if (stockname.Split('.')[1] != filenames[0].Split('.').Last<string>())
                {
                    if (_thisForm.TopMost != true)
                    {
                        _thisForm.TopMost = true;
                        MessageBox.Show("Некорректный формат, необходимо вручную пересохранить файл", "Ошибка переноса", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _thisForm.TopMost = false;
                    }
                    else
                    {
                        MessageBox.Show("Некорректный формат, необходимо вручную пересохранить файл", "Ошибка переноса", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;
                }
                for (int fileIndex = 0; fileIndex < filenames.Length; fileIndex++)
                {
                    //use the fileindex to get the name and data stream
                    string filename = filenames[fileIndex];
                    MemoryStream filestream = filestreams[fileIndex];

                    //save the file stream using its name to the application path
                    FileStream outputStream = File.Create(Properties.Settings.Default.self_Stock + @"\" + stockname);
                    filestream.WriteTo(outputStream);
                    outputStream.Close();
                }
            }
            catch
            {
                if (_thisForm.TopMost != true)
                {
                    _thisForm.TopMost = true;
                    MessageBox.Show("Необходимо перетащить файл из OutLook", "Ошибка переноса", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _thisForm.TopMost = false;
                }
                else
                {
                    MessageBox.Show("Необходимо перетащить файл из OutLook", "Ошибка переноса", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            _thisForm._cRow.AvailableCheak();
        }

        public static void Form_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        #endregion

        private void labelAllFor_Click(object sender, EventArgs e)
        {
            labelAllFor.Text = DateTime.Today.Second.ToString();
        }

        private void btn_Archive_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Очистить каталоги и архивировать задним числом?",
                                    "Архивация", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) return;

            if (result == DialogResult.Yes)
            {
                CatalogControl.Start(DateTime.Today.AddDays(-1));
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = cb_TopMost.Checked;
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenSettingsForm(Properties.Settings.Default.first_Launch);
        }

        private void OpenSettingsForm(bool cancelcheak)
        {
            Form _settingsForm = new SettingsForm(cancelcheak);
            _settingsForm.Show();
            _settingsForm.TopMost = true;
            _settingsForm.FormClosed += _settingsForm_FormClosed;
            this.Enabled = false;
        }

        private void _settingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
            if (!Properties.Settings.Default.first_Launch)
            {
                Properties.Settings.Default.first_Launch = true;
                StockMain();
            }
            _cRow.AvailableCheak();
        }
        #region Async
        private void button2_Click(object sender, EventArgs e)
        {
            //SendStockToTarget();
            btn_Throw.Enabled = false;
            backgroundWorker1.RunWorkerAsync();

        }
        
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            e.Result = SendStockToTarget(worker, e);
        }
        
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            btn_Throw.Enabled = true;
        }
        
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //
        }

        bool SendStockToTarget(BackgroundWorker worker, DoWorkEventArgs e)
        {
            //string[] allFile = Directory.GetFileSystemEntries(Properties.Settings.Default.self_Stock);
            DirectoryInfo dir = new DirectoryInfo(Properties.Settings.Default.self_Stock);
            FileInfo[] fileInf = dir.GetFiles();
            for (int n = 0; n < fileInf.Length; n++)
            {
                if (!File.Exists(Properties.Settings.Default.target_Stock + "\\" + fileInf[n].Name))
                    fileInf[n].CopyTo(Properties.Settings.Default.target_Stock + "\\" + fileInf[n].Name, true);
            }
            return true;
        }
        #endregion
    }
}
