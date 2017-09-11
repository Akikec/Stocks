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
            }
            catch
            {
                ZipFile.CreateFromDirectory(Properties.Settings.Default.target_Stock, Properties.Settings.Default.archive_Stock + @"\" + _followDate.ToString("ddMM") + "Also.zip");
                MessageBox.Show("Архив под названием " + _followDate.ToString("ddMM") + ".zip уже существует, создан " 
                                + _followDate.ToString("ddMM") + "Also.zip", "Ошибка архивации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                foreach (FileInfo file in dirInfo.GetFiles())
                {
                    file.Delete();
                }
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

        public static bool Get_Old(string name)
        {
            int whatDays = -1;
            if (!File.Exists(Properties.Settings.Default.archive_Stock + @"\" + DateTime.Today.AddDays(whatDays).ToString("ddMM") + ".zip"))
            {
                whatDays = -3;
            }
            if (!File.Exists(Properties.Settings.Default.archive_Stock + @"\" + DateTime.Today.AddDays(whatDays).ToString("ddMM") + ".zip"))
            {
                return false;
            }
                using (var zipFile = ZipFile.OpenRead(Properties.Settings.Default.archive_Stock + @"\" + DateTime.Today.AddDays(whatDays).ToString("ddMM") + ".zip"))
            {

                foreach (ZipArchiveEntry entry in zipFile.Entries)
                {
                    if (string.Equals(
                                Path.GetFileName(entry.Name), name,
                                StringComparison.CurrentCultureIgnoreCase))
                    {
                        var path = Properties.Settings.Default.target_Stock + @"\" + entry.Name;
                        entry.ExtractToFile(path);
                        return true;
                    }
                }
            }
            return true;
        }

    }
}
