using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace DepartureOfBalances
{
    public partial class Form1 : Form
    {
        List<WebController> allLink;
        List<CheckBox> allCheckBox = new List<CheckBox>();

        string balancesPath = @"C:\Users\Gareev\Documents\Остатки\";

        public Form1()
        {
            InitializeComponent();
            //Проверка времени
            if(!Directory.Exists(balancesPath + DateTime.Today.ToString("ddMM")))
            {
                Directory.CreateDirectory(balancesPath + DateTime.Today.ToString("ddMM"));
            }
            //Список всех остатков
            allLink = new List<WebController>()
            {
                //Empty Secret info
            };
            //Список всех элементов CheackBox
            foreach (var cb in tableLayoutPanel1.Controls.OfType<CheckBox>())
            {
                allCheckBox.Insert(0, cb);
            }

        }

        private void btDownloads_Click(object sender, EventArgs e)
        {
            allCheckBox[3].Checked = allLink[3].DownloadFile();

            for (int i = 0; i < allLink.Count; i++)
            {
                allCheckBox[i].Checked = allLink[i].DownloadFile();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
