using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockController
{
    public partial class Form1 : Form
    {
        //List<Stocks> _stocksList = new List<Stocks>();
        //List<TemplateInterface> _interfaceList = new List<TemplateInterface>();
        //int _x = 20;
        //int _y = 20;

        CompleteRow _cRow = new CompleteRow();

        //string label1Name = "Label1";
        //string textBoxName = "textBox1";
        //string label2Name = "Label2";
        //int _nameSize;

        public Form1()
        {
            InitializeComponent();

            _cRow.Main(stockConteiner);
            _cRow.AvailableCheak();
            RefreshStock();
            //ReturnCSV(); //Обработка документа со списком остатков

            //for (int i = 0; i < _stocksList.Count; i++)
            //{
            //    CreateRow(i);
            //}
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
            //CheakTest();
            _cRow.AvailableCheak();
        }

        private void bt_Filter_Click(object sender, EventArgs e)
        {
            _cRow.FilterStock();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OutlookMail.CreateMail("Нет остатков", "product@elecomt.ru", _cRow.AvailableSend());

            //2

            //string subjectEmail = "Meeting has been rescheduled.";
            //string bodyEmail = "Meeting is one hour later.";
            //Ma
            //Outlook.MAPIFolder sentContacts = (Outlook.MAPIFolder)
            //    this.Application.ActiveExplorer().Session.GetDefaultFolder
            //    (Outlook.OlDefaultFolders.olFolderContacts);

            //foreach (Outlook.ContactItem contact in sentContacts.Items)
            //{
            //    if (contact.Email1Address.Contains("example.com"))
            //    {
            //        this.CreateEmailItem(subjectEmail, contact
            //            .Email1Address, bodyEmail);
            //    }
            //}

            //1

            //SmtpClient Smtp = new SmtpClient("128.0.0.1"); //MailV-F.elecomt.ru
            ////Smtp.Credentials = new NetworkCredential("name@yandex.ru", "pass");
            //Smtp.Port = 587;
            //MailMessage Message = new MailMessage();
            //Message.From = new MailAddress("name@yandex.ru");
            //Message.To.Add(new MailAddress("name@yandex.ru"));
            //Message.Subject = "тема";
            //Message.Body = "сообщение";
            //try
            //{
            //    Message.
            //    Smtp.Send(Message);
            //}
            //catch (SmtpException)
            //{
            //    MessageBox.Show("Ошибка!");
            //}
            //Формирование Письма
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

        //private void CheakTest()
        //{
        //    for (int i = 0; i < _stocksList.Count; i++)
        //    {
        //        //
        //        string self_Path = Properties.Settings.Default.self_Stock;
        //        string target_Path = Properties.Settings.Default.target_Stock;

        //        List<string> nameList = _stocksList[i].GetName();

        //        if (File.Exists(self_Path + @"\" + nameList[1]))
        //        {
        //            _stocksList[i]._thisLabel.BackColor = Color.LawnGreen;
        //        }
        //        else
        //        {
        //            _stocksList[i]._thisLabel.BackColor = Color.Red;
        //        }
        //    }
        //}

        //void ReturnCSV()
        //{
        //    var fs = File.OpenRead(Properties.Settings.Default.file_StocksList);
        //    var reader = new StreamReader(fs, Encoding.GetEncoding(1251));

        //    reader.ReadLine();

        //    while (!reader.EndOfStream)
        //    {
        //        var line = reader.ReadLine();
        //        var values = line.Split(';');

        //        _stocksList.Add(new Stocks(values));
        //        if (_nameSize < values[0].Length) _nameSize = values[0].Length; // Поиск самого длинного названия
        //    }
        //    _nameSize *= 6;
        //}

        //void CreateRow(int i)
        //{
        //    List<string> nameList = _stocksList[i].GetName();

        //    Label label1 = new System.Windows.Forms.Label();
        //    TextBox textBox1 = new System.Windows.Forms.TextBox();
        //    Label label2 = new System.Windows.Forms.Label();
        //    //this.SuspendLayout();
        //    _stocksList[i]._thisLabel = label1;
        //    // 
        //    // label1
        //    // 
        //    label1.AutoSize = true;
        //    label1.BackColor = System.Drawing.SystemColors.Control;
        //    label1.Location = new System.Drawing.Point(_x, _y);
        //    label1.Name = label1Name;
        //    label1.Size = new System.Drawing.Size(35, 13);
        //    label1.TabIndex = 0;
        //    label1.Text = nameList[0];
        //    // 
        //    // textBox1
        //    // 
        //    textBox1.Location = new System.Drawing.Point(_x +_nameSize+14, _y-3);
        //    textBox1.Name = textBoxName;
        //    textBox1.Size = new System.Drawing.Size(100, 20);
        //    textBox1.TabIndex = 1;
        //    textBox1.Text = nameList[1];
        //    // 
        //    // label2
        //    // 
        //    label2.AutoSize = true;
        //    label2.Location = new System.Drawing.Point(_x+ _nameSize + 141, _y);
        //    label2.Name = label2Name;
        //    label2.Size = new System.Drawing.Size(35, 13);
        //    label2.TabIndex = 2;
        //    label2.Text = nameList[2];

        //    stockConteiner.Controls.Add(label1);
        //    stockConteiner.Controls.Add(textBox1);
        //    stockConteiner.Controls.Add(label2);

        //    _y += 25;
        //    //label1Name = "Label1"+1;
        //    //textBoxName = "textBox1"+1;
        //    //label2Name = "Label2"+2;
        //}

    }
}
