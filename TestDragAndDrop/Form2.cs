using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDragAndDrop
{
    public partial class Form2 : Form
    {
        List<Label> lb_list = new List<Label>();
        List<Label> Cheak = new List<Label>();
        public Form2()
        {
            InitializeComponent();
            Creatlabel();
        }

        public void Creatlabel()
        {
            for(int i = 0; i < 100; i++)
            {
                Label label1 = new Label();

                label1.AutoSize = true;
                label1.BackColor = System.Drawing.SystemColors.Control;
                label1.Location = new Point(20, i * 20);
                label1.Name = "lbl_"+i;
                label1.AutoSize = false;
                label1.Size = new System.Drawing.Size(100, 13);
                label1.TabIndex = 0;
                label1.Text = "Я номер " + i;

                panel1.Controls.Add(label1);
                lb_list.Add(label1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            Point fPoint = lb_list[0].Location;
            foreach (Label lb in lb_list)
            {
                lb.Location = Point.Add(fPoint,new Size(new Point(0, i * 20)));//new System.Drawing.Point(20, i * 20);
                i++;
                Refresh();
            }
            Point pn = panel1.AutoScrollPosition;
        }
    }
}
