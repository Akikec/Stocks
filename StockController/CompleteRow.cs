﻿using System;
using System.Drawing;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace StockController
{
    class CompleteRow
    {
        Panel _ourPanel;
        List<Stocks> _stocksList = new List<Stocks>();
        ToolTip _tooltip = new ToolTip();
        //List<TemplateInterface> _filterInterfaceList = new List<TemplateInterface>();

        internal List<Stocks> StocksList
        {
            get
            {
                return _stocksList;
            }

            set
            {
                _stocksList = value;
            }
        }
        /// <summary>
        /// Проверка на наличие. 1 значение кол-во зеленых, 2 значение из них желтых, 3 значение всего.
        /// </summary>
        public int[] GetStatus()
        {
            int[] sum = new int[3];
            for (int i = 0; i < _stocksList.Count; i++)
            {
                if (_stocksList[i].ThisTemplate.GetColor() == Properties.Settings.Default.color_Correct)
                {
                    sum[0] += 1;
                }
                if (_stocksList[i].ThisTemplate.GetColor() == Properties.Settings.Default.color_Incorrect)
                {
                    sum[1] += 1;
                }
            }
            sum[2] = _stocksList.Count;
            return sum;
        }
        
        int _nameSize;
        int _x = 20;
        int _y = 25;
        const int _Y= 25;

        #region Main

        public CompleteRow Main(Panel stockConteiner)
        {
            _tooltip.AutoPopDelay = 2000;
            _tooltip.InitialDelay = 100;
            _tooltip.ReshowDelay = 500;
            _tooltip.ShowAlways = true;

            _ourPanel = stockConteiner;

            ReturnStockListFromCSV();

            for (int i = 0; i < _stocksList.Count; i++)
            {
                _stocksList[i].ThisTemplate = ReturnInterface(_stocksList[i]);
                AddToolTip(i);
                //ReturnInterface(_stocksList[i]);
                _y += _Y;
            }

            return this;
        }

        private void AddToolTip(int i)
        {
            _tooltip.SetToolTip(_stocksList[i].ThisTemplate.GetControl, _stocksList[i].GetTooltips);                
        }

        #endregion

        #region Lists Builder
        private void ReturnStockListFromCSV()
        {
            if (!File.Exists(Properties.Settings.Default.file_StocksList)) return;
            using (FileStream fs = File.OpenRead(Properties.Settings.Default.file_StocksList))
            using (StreamReader reader = new StreamReader(fs, Encoding.GetEncoding(1251)))
            {
                reader.ReadLine(); // Пропуск заголовков

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    _stocksList.Add(new Stocks(values));

                    if (_nameSize < values[0].Length) _nameSize = values[0].Length; // Поиск самого длинного названия
                }
                _nameSize *= 5;
            }
        }

        private TemplateInterface ReturnInterface(Stocks stock)
        {
            TemplateInterface tempInterface = new TemplateInterface(_x, _y, _nameSize, stock, _ourPanel);
            //tempInterface.CreateRow(_x, _y, stock, _ourPanel);
            //_interfaceList.Add(tempInterface);
            return tempInterface;
        }
        #endregion

        #region Edit
        public void AvailableCheak()
        {
            for (int i = 0; i < _stocksList.Count; i++)
            {
                string self_Path = Properties.Settings.Default.self_Stock;
                string target_Path = Properties.Settings.Default.target_Stock;

                List<string> nameList = _stocksList[i].GetName();

                if (_stocksList[i].CheakVendorFiles() && _stocksList[i].CheakStock())
                {
                    _stocksList[i].ThisTemplate.ChangeColor(Properties.Settings.Default.color_Correct);
                }
                else if (_stocksList[i].CheakVendorFiles() || _stocksList[i].CheakStock())
                {
                    _stocksList[i].ThisTemplate.ChangeColor(Properties.Settings.Default.color_Incorrect);
                }
                else
                {
                    _stocksList[i].ThisTemplate.ChangeColor(Properties.Settings.Default.color_Nothing);
                    //_stocksList[i]._thisLabel.BackColor = Color.Red; По старому
                }
            }
        }

        public void FilterStock()
        {
            Point currentFirstPoint = _stocksList[0].ThisTemplate.GetFirstPosition();
            _stocksList.Sort();

            for (int i = 0; i < _stocksList.Count; i++)
            {
                _stocksList[i].ThisTemplate.ChangePosition(currentFirstPoint, _nameSize);
                //ReturnInterface(_stocksList[i]);
                currentFirstPoint = Point.Add(currentFirstPoint, new Size(new Point(0, _Y)));
            }
        }

        public string AvailableSend()
        {
            StringBuilder bodyBuilder = new StringBuilder();

            for (int i = 0; i < _stocksList.Count; i++)
            {
                if(_stocksList[i].ThisTemplate.GetColor()== Properties.Settings.Default.color_Nothing)
                {
                    bodyBuilder.Append(_stocksList[i].GetName()[0]);
                    bodyBuilder.AppendLine();
                }                
            }

            return bodyBuilder.ToString();
        }
        #endregion
    }
}
