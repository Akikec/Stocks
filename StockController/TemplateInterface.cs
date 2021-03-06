﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockController
{
    class TemplateInterface : Control
    {
        Label label1 = new Label();
        TextBox textBox1 = new TextBox();
        Label label2 = new Label();
        Button bt1 = new Button();

        string label1Name = "Labels";
        string textBoxName = "textBoxs";
        string label2Name = "Labels";
        string bt1Name = "Buttons";

        public Control GetControl
        {
            get{ return label1.Controls.Owner; }
        }

        readonly int[] width = { 14, 141, 155 }; //Расстояние между элементами интерфейса

        public TemplateInterface(int x, int y, int nameSize, Stocks stock, Panel stockConteiner)
        {
            List<string> nameList = stock.GetName();

            //this.SuspendLayout();

            // Имя поставщика

            label1.AutoSize = true;
            label1.BackColor = System.Drawing.SystemColors.Control;
            label1.Location = new System.Drawing.Point(x, y);
            label1.Name = label1Name;
            label1.AutoSize = false;
            label1.Size = new System.Drawing.Size(nameSize, 13);
            label1.TabIndex = 0;
            label1.Text = nameList[0];

            // Название файла

            textBox1.Location = new System.Drawing.Point(x + nameSize + width[0], y - 3);
            textBox1.Name = textBoxName;
            textBox1.Size = new System.Drawing.Size(100, 20);
            textBox1.TabIndex = 1;
            textBox1.Text = nameList[1];
            textBox1.AllowDrop = true;
            textBox1.DragDrop += new DragEventHandler(Form1.Form_DragDrop);
            textBox1.DragEnter += new DragEventHandler(Form1.Form_DragEnter);
            textBox1.DragLeave += new EventHandler(Form1.Form_DragLeave);

            // Кнопка старого файла

            bt1.Location = new System.Drawing.Point(x + nameSize + width[2], y - 3);
            bt1.Name = nameList[1];
            bt1.Size = new System.Drawing.Size(45, 20);
            bt1.TabIndex = 3;
            bt1.Text = "Old";
            bt1.UseVisualStyleBackColor = true;
            bt1.Click += new System.EventHandler(Form1.btn_Send_Old);

            // Статус

            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(x + nameSize + width[1], y);
            label2.Name = label2Name;
            label2.Size = new System.Drawing.Size(35, 13);
            label2.TabIndex = 2;
            label2.Text = "";

            stockConteiner.Controls.Add(label1);
            stockConteiner.Controls.Add(textBox1);
            stockConteiner.Controls.Add(label2);
            stockConteiner.Controls.Add(bt1);
        }

        public void ChangeColor(Color color)
        {
            label1.BackColor = color;
        }

        public Color GetColor()
        {
            return label1.BackColor;
        }
        public int SortColor()
        {
            if (label1.BackColor == Properties.Settings.Default.color_Nothing)
            {
                return -1;
            }
            else if (label1.BackColor == Properties.Settings.Default.color_Correct)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public void ChangeStatus(string status)
        {
            label2.Text = status;
        }

        public Point GetFirstPosition()
        {
            return label1.Location;
        }

        public void ChangePosition(Point pnt, int nameSize)
        {
            label1.Location = new System.Drawing.Point(pnt.X, pnt.Y);
            textBox1.Location = new System.Drawing.Point(pnt.X + nameSize + width[0], pnt.Y - 3);
            label2.Location = new System.Drawing.Point(pnt.X + nameSize + width[1], pnt.Y);
            bt1.Location = new Point(pnt.X + nameSize + width[2], pnt.Y - 3);
        }
    }
}
