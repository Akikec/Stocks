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

namespace TestDragAndDrop
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_DragDrop(object sender, DragEventArgs e)
        {
            OutlookDataObject dataObject = new OutlookDataObject(e.Data);

            //string ss = sender.GetType().Name;
            //Form _thisForm = (Form)sender;
            //_thisForm.BackColor = Color.Green;

            //get the names and data streams of the files dropped
            string[] filenames = (string[])dataObject.GetData("FileGroupDescriptor");
            MemoryStream[] filestreams = (MemoryStream[])dataObject.GetData("FileContents");

            for (int fileIndex = 0; fileIndex < filenames.Length; fileIndex++)
            {
                //use the fileindex to get the name and data stream
                string filename = filenames[fileIndex];
                MemoryStream filestream = filestreams[fileIndex];

                //save the file stream using its name to the application path
                FileStream outputStream = File.Create("То что мне надо.xlsx");
                filestream.WriteTo(outputStream);
                outputStream.Close();
            }
            
        }

        private void Form3_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
    }
}
