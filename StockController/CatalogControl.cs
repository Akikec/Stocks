using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace StockController
{
    class CatalogControl
    {
        public static void Start()
        {
            ArchiveAndClearTarget();
            ClearSelfStock();
        }

        private static void ArchiveAndClearTarget()
        {
            DirectoryInfo dirInfo = new DirectoryInfo(Properties.Settings.Default.target_Stock);
            if (dirInfo == null) return;
            if (!File.Exists(Properties.Settings.Default.archive_Stock + @"\" + Properties.Settings.Default.lastWorkDate.ToString("ddMM") + ".zip"))
            {
                ZipFile.CreateFromDirectory(Properties.Settings.Default.target_Stock, Properties.Settings.Default.archive_Stock + @"\" + Properties.Settings.Default.lastWorkDate.ToString("ddMM") + ".zip");

                foreach (FileInfo file in dirInfo.GetFiles())
                {
                    file.Delete();
                }
            }
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
