using Faktury.Utils;
using Faktury.Utils.Backup;
using Google.Apis.Drive.v2.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faktury.Options
{
    public partial class BackupMenu : Form
    {
        
        public BackupMenu()
        {
            InitializeComponent();
            ItemsRebuild();
            if(Program.GoogleAPI == false)
            {
                buttonNewGoogle.Enabled = false;
                buttonRestoreGoogle.Enabled = false;
            }
        }

        public void ItemsRebuild()
        {
            int counter = 0;
            if (Program.GoogleAPI)
            {
                List<BackupItems> listGoogle = GoogleDriveBackup.GetBackupData();
                listView1.Items.Clear();
                foreach (var item in listGoogle)
                {
                    string[] row = { "Google Drive", item.File.CreatedDate.ToString(), item.InvoiceCount.ToString(), item.ConfigCount.ToString(), item.InvoiceData, item.ContractorCount.ToString(), item.ItemCount.ToString() };
                    var listViewItem = new ListViewItem(row, counter++);
                    listView1.Items.Add(listViewItem);
                }
            }
        }

        private void buttonNewGoogle_Click(object sender, EventArgs e)
        {
            GoogleDriveBackup.Make();
            GoogleDriveBackup.Load();
            ItemsRebuild();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            if (Program.GoogleAPI)
            {
                GoogleDriveBackup.Load();
            }
            ItemsRebuild();
        }

        private void buttonRestoreGoogle_Click(object sender, EventArgs e)
        {
            int index = listView1.FocusedItem.Index;
            DialogResult result = MessageBox.Show("Czy napewno chcesz wczytać pliki z dnia: "+ listView1.FocusedItem.SubItems[1]+" z dysku Google?" , "Przywracanie danych", MessageBoxButtons.YesNo);
            if(result == System.Windows.Forms.DialogResult.Yes)
            {
               FileWriter.Replace(FileWriter.ITEMS_LIST, GoogleDriveBackup.DownloadFile(GoogleDriveBackup.DriveContent[(index * 5)]));
               FileWriter.Replace(FileWriter.CONFIG, GoogleDriveBackup.DownloadFile(GoogleDriveBackup.DriveContent[(index * 5) + 1]));
               FileWriter.Replace(FileWriter.CONTRACTORS_LIST, GoogleDriveBackup.DownloadFile(GoogleDriveBackup.DriveContent[(index * 5) + 2]));
               FileWriter.Replace(FileWriter.INVOICES_LIST, GoogleDriveBackup.DownloadFile(GoogleDriveBackup.DriveContent[(index * 5) + 3]));
               Application.Restart();
            }
        }
    }
}
