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
                DialogResult result;
                result = MessageBox.Show("Последнее использование программы: " +
                    Properties.Settings.Default.lastWorkDate.ToString("dd MMMM") +
                    "\r\n" + "Текущая дата: " + DateTime.Today.ToString("dd MMMM") +
                    "\r\n" + "Выполнить архивацию?",
                    "Архивация", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Cancel) return;

                if (result == DialogResult.Yes)
                {
                    CatalogControl.Start();
                    Properties.Settings.Default.lastWorkDate = DateTime.Today;
                    Properties.Settings.Default.Save();
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
