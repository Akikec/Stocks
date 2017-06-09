using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace TestDragAndDrop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.AllowDrop = true;
            textBox1.DragEnter += new DragEventHandler(textBox1_DragEnter);
            //textBox1.DragDrop += new DragEventHandler(textBox1_DragDrop);
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            //if (e.Data.GetDataPresent(DataFormats.FileDrop) &&
                //((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move))

                //e.Effect = DragDropEffects.Move;

            //if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            //else
                //e.Effect = DragDropEffects.None;
        }

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            // //if (e.Data.GetDataPresent(DataFormats.FileDrop) && e.Effect == DragDropEffects.Move)
            // //{
            //     string[] objects = (string[])e.Data.GetData(DataFormats.FileDrop);
            //     // В objects хранятся пути к папкам и файлам
            //     textBox1.Text = null;
            //     for (int i = 0; i < objects.Length; i++)
            //         textBox1.Text += objects[i] + "\r\n";
            //// }

            try
            {
                textBox1.Text = e.Data.GetData(DataFormats.Text).ToString();
            }
            catch { }
            try
            {
                string[] ss = e.Data.GetFormats();
                for(int i =0; i< ss.Length; i++)
                {
                    textBox1.Text += ss[i];
                }
                //"FileContents"
                

                object nw;
                textBox1.Text += e.Data.GetData("FileContents");
                //textBox1.Text += e.Data.GetData(".jpg");
                //textBox1.Text += e.Data.GetData(DataFormats.Bitmap);
                //textBox1.Text += e.Data.GetData(DataFormats.CommaSeparatedValue);
                //textBox1.Text += e.Data.GetData(DataFormats.Dib);
                //textBox1.Text += e.Data.GetData(DataFormats.Dif);
                //textBox1.Text += e.Data.GetData(DataFormats.EnhancedMetafile);
                //textBox1.Text += e.Data.GetData(DataFormats.FileDrop);
                //textBox1.Text += e.Data.GetData(DataFormats.Html);
                //textBox1.Text += e.Data.GetData(DataFormats.Locale);
                //textBox1.Text += e.Data.GetData(DataFormats.MetafilePict);
                //textBox1.Text += e.Data.GetData(DataFormats.OemText);
                //textBox1.Text += e.Data.GetData(DataFormats.Palette);
                //textBox1.Text += e.Data.GetData(DataFormats.PenData);
                //textBox1.Text += e.Data.GetData(DataFormats.Riff);
                //textBox1.Text += e.Data.GetData(DataFormats.Rtf);
                //textBox1.Text += e.Data.GetData(DataFormats.Serializable);
                //textBox1.Text += e.Data.GetData(DataFormats.StringFormat);
                //textBox1.Text += e.Data.GetData(DataFormats.SymbolicLink);
                //textBox1.Text += e.Data.GetData(DataFormats.Text);
                //textBox1.Text += e.Data.GetData(DataFormats.Tiff);
                //textBox1.Text += e.Data.GetData(DataFormats.UnicodeText);
                //textBox1.Text += e.Data.GetData(DataFormats.WaveAudio);

            }
            catch { }
        }

        private void FormRegion2_DragDrop_1(object sender, DragEventArgs e)
        {
            string[] fileNames = null;

            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                fileNames = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string fileName in fileNames)
                {
                    label1.Text = fileName;
                }
            }
            else if (e.Data.GetDataPresent("FileGroupDescriptor"))
            {
                //OutlookDataObject dataObject = new OutlookDataObject(e.Data);
                //string[] filenames = (string[])dataObject.GetData("FileGroupDescriptor");
                //for (int fileIndex = 0; fileIndex < filenames.Length; fileIndex++)
                //{
                //    File.ReadAllBytes()
                //        //Write your logic here u get multiple file name here
                //    label1.Text += filenames[fileIndex];
                //}
                object s = e.Data.GetData("FileGroupDescriptor");

                Stream theStream = (Stream)e.Data.GetData("FileGroupDescriptor");
                
                byte[] fileGroupDescriptor = new byte[512];
                theStream.Read(fileGroupDescriptor, 0, 512);

                StringBuilder fileName = new StringBuilder("");

                for (int i = 76; fileGroupDescriptor[i] != 0; i++)
                { fileName.Append(Convert.ToChar(fileGroupDescriptor[i])); }

                string theFile = fileName.ToString();
                String fileName1 = System.IO.Path.GetFileName(theFile);
                StreamWriter sw = new StreamWriter(fileName1);
            }
        }
    }
}
