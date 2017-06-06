using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockController
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Properties.Settings.Default.lastWorkDate != DateTime.Today)
            {
                CatalogControl.Start();
                Properties.Settings.Default.lastWorkDate = DateTime.Today;
                Properties.Settings.Default.Save();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Timer _timer = new Timer();
            _timer.Interval = 60000;
            _timer.Tick += _timer_Tick;
            _timer.Start();
        }

        private static void _timer_Tick(object sender, EventArgs e)
        {
            // старт чек.
        }
    }
}
