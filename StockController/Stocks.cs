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
        public Label _thisLabel; //Убрать

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
                return 0;
            }
        }
    }
}
