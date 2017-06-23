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
        bool _topMost = false;

        public Form1()
        {
            InitializeComponent();

            _cRow.Main(stockConteiner);
            _cRow.AvailableCheak();
            RefreshStock();
            updateTimer.Interval = 6000;
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
            _cRow.FilterStock();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OutlookMail.CreateMail("Нет остатков", "product@elecomt.ru", _cRow.AvailableSend());
        }

        public static void Form_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                OutlookDataObject dataObject = new OutlookDataObject(e.Data);


                //string ss = sender.GetType().Name;

                TextBox _thistb = (TextBox)sender;
                string stockname = _thistb.Text;

                //get the names and data streams of the files dropped
                string[] filenames = (string[])dataObject.GetData("FileGroupDescriptor");
                MemoryStream[] filestreams = (MemoryStream[])dataObject.GetData("FileContents");

                if (stockname.Split('.')[1] != filenames[0].Split('.').Last<string>())
                {
                    if (Form1.ActiveForm.TopMost != true)
                    {
                        Form1.ActiveForm.TopMost = true;
                        MessageBox.Show("Некорректный формат, необходимо вручную пересохранить файл", "Ошибка переноса", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Form1.ActiveForm.TopMost = false;
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
                if (Form1.ActiveForm.TopMost != true)
                {
                    Form1.ActiveForm.TopMost = true;
                    MessageBox.Show("Необходимо перетащить файл из OutLook", "Ошибка переноса", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Form1.ActiveForm.TopMost = false;
                }
                else
                {
                    MessageBox.Show("Необходимо перетащить файл из OutLook", "Ошибка переноса", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void Form_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

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
    }
}
