using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StockController
{
    class Stocks : IComparable<Stocks>
    {
        private string _provider;
        private string _fileName1;
        private string _fileName2;
        private string _fileName3;
        private string _sender;
        private string _responsible;
        private TemplateInterface _thisTemplate;

        public TemplateInterface ThisTemplate
        {
            get
            {
                return _thisTemplate;
            }

            set
            {
                _thisTemplate = value;
            }
        }

        public Stocks(string[] stringRow)
        {
            _provider = stringRow[0];
            _fileName1 = stringRow[1];
            if (stringRow[2] != null) _fileName2 = stringRow[2];
            if (stringRow[3] != null) _fileName3 = stringRow[3];
            _sender = stringRow[4];
            _responsible = stringRow[5];
        }

        public List<string> GetName()
        {
            List<string> _getname = new List<string>();
            _getname.Add(_provider);
            _getname.Add(_fileName1);
            if (_fileName2 != null) _getname.Add(_fileName2);
            if (_fileName3 != null) _getname.Add(_fileName3);
            return _getname;
        }

        public string GetTooltips
        {
            get {
                StringBuilder strBuilder = new StringBuilder();

                strBuilder.Append("Название: " + _provider);
                strBuilder.AppendLine();
                strBuilder.Append("Имя файла: " + _fileName1 + " " + _fileName2 + " " + _fileName3);
                strBuilder.AppendLine();
                strBuilder.Append("Источник: " + _sender);
                strBuilder.AppendLine();
                strBuilder.Append("Ответственный: " + _responsible);
                strBuilder.AppendLine();
                //string tooltip;
                //tooltip = "Название: " + _provider + "/n/r" +
                //    "Имя файла: " + _fileName1 + " " + _fileName2 + " " + _fileName3 + "/n/r" +
                //    "Источник: " + _sender + "/n/r" +
                //    "Ответственный: " + _responsible;
                return strBuilder.ToString();
            }
        }

        public bool CheakVendorFiles()
        {
            bool cheakBack = File.Exists(Properties.Settings.Default.target_Stock + @"\" + _fileName1);
            if (_fileName2 != String.Empty)
            {
                cheakBack = File.Exists(Properties.Settings.Default.target_Stock + @"\" + _fileName2);
            }
            if (_fileName3 != String.Empty)
            {
                cheakBack = File.Exists(Properties.Settings.Default.target_Stock + @"\" + _fileName3);
            }
            //Проверка на сервере
            return cheakBack;
        }

        public bool CheakStock()
        {
            bool cheakBack = File.Exists(Properties.Settings.Default.self_Stock + @"\" + _fileName1);
            if (_fileName2 != String.Empty)
            {
                cheakBack = File.Exists(Properties.Settings.Default.self_Stock + @"\" + _fileName2);
            }
            if (_fileName3 != String.Empty)
            {
                cheakBack = File.Exists(Properties.Settings.Default.self_Stock + @"\" + _fileName3);
            }
            //Проверка в корневом файле
            return cheakBack;
        }

        public void SetStock()
        {
            //Переброс файлов
        }

        public int CompareTo(Stocks other)
        {
            int a = _thisTemplate.SortColor();
            int b = other.ThisTemplate.SortColor();
            char x = _fileName1[0];
            char y = other._fileName1[0];

            if (a < b)
            {
                return -1;
            }
            else if (a > b)
            {
                return 1;
            }
            else
            {
                if (x < y)
                {
                    return -1;
                }
                else if (x > y)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
