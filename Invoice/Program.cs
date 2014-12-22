using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Faktury.DialogBox;
using Faktury.Utils;
using Faktury.Utils.Backup;
using Faktury.Utils.AutoUpdate;

namespace Faktury
{
    static class Program
    {
        public static bool GoogleAPI = true;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FileWriter.Load();
            try
            {
                GoogleDriveBackup.Connect();
            }
            catch
            {
                GoogleAPI = false;
            }
            try
            {
                if (VersionChecker.IsNewUpdate(Application.ProductVersion))
                {
                    var result = MessageBox.Show("Dostępna jest nowa wersja. Czy chcesz aktualizować teraz?", "Nowa wersja jest dostępna", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Update.Download();
                    }
                }
            }
            catch
            {

            }
            Application.Run(new FMain());
        }
    }
}
