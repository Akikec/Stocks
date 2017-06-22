using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace StockController
{
    class CatalogControl
    {
        private static DateTime _followDate;

        public static void Start(DateTime date)
        {
            _followDate = date;
            ArchiveAndClearTarget();
            ClearSelfStock();
        }

        private static void ArchiveAndClearTarget()
        {
            DirectoryInfo dirInfo = new DirectoryInfo(Properties.Settings.Default.target_Stock);
            if (dirInfo == null) return;
            //if (!File.Exists(Properties.Settings.Default.archive_Stock + @"\" + _followDate.ToString("ddMM") + ".zip"))
            //{
            try { 
                ZipFile.CreateFromDirectory(Properties.Settings.Default.target_Stock, Properties.Settings.Default.archive_Stock + @"\" + _followDate.ToString("ddMM") + ".zip");

                foreach (FileInfo file in dirInfo.GetFiles())
                {
                    file.Delete();
                }
            }
            catch
            {
                MessageBox.Show("Архив под названием "+ _followDate.ToString("ddMM") + ".zip уже существует", "Ошибка архивации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //}
        }

        private static void ClearSelfStock()
        {
            DirectoryInfo dirInfo = new DirectoryInfo(Properties.Settings.Default.self_Stock);
            if (dirInfo == null) return;

            foreach (FileInfo file in dirInfo.GetFiles())
            {
                file.Delete();
            }
        }
    }
}
