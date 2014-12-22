using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Faktury.Items;
using System;
using Faktury.Utils.AutoUpdate;

namespace Faktury.Utils
{
    public class FileWriter
    {
        private static readonly string outPutDirectory = Path.GetDirectoryName(Application.ExecutablePath);
        public static readonly string ITEMS_LIST = Path.Combine(outPutDirectory, @"List\Items.flx");
        public static readonly string CONTRACTORS_LIST = Path.Combine(outPutDirectory, @"List\Contractors.flx");
        public static readonly string INVOICES_LIST = Path.Combine(outPutDirectory, @"List\Invoices.flx");
        public static readonly string CONFIG = Path.Combine(outPutDirectory, @"Config.xml");
        public static readonly string TEMPLATE_INVOICE = Path.Combine(outPutDirectory, @"TemplateInvoice.flx");

        public static void Load()
        {
            Directory.CreateDirectory(Path.Combine(outPutDirectory, "List"));

            TextWindow textWindow = new TextWindow("Wczytywanie danych");
            textWindow.Show();
            textWindow.DialogText.Text = "Wczytywanie pliku ITEMS";

            try
            {
                Data.Items = XMLSerialization.ReadFromXmlFile<List<Item>>(ITEMS_LIST);
            }
            catch
            {
                MessageBox.Show("Plik z danymi nie istnieje, lub jest uszkodzony. ITEMS");
                if (!File.Exists(ITEMS_LIST))
                {
                    File.Create(ITEMS_LIST).Close();
                }
                Data.Items = new List<Item>();
                Data.SaveItem();
            }

            textWindow.DialogText.Text = "Wczytywanie pliku CONTRACTORS";

            try
            {
                Data.Contractors = XMLSerialization.ReadFromXmlFile<List<Contractor>>(CONTRACTORS_LIST);
            }
            catch
            {
                MessageBox.Show("Plik z danymi nie istnieje, lub jest uszkodzony. CONTRACOTRS");
                if (!File.Exists(CONTRACTORS_LIST))
                {
                    File.Create(CONTRACTORS_LIST).Close();
                }
                Data.Contractors = new List<Contractor>();
                Data.SaveContractor();
            }

            textWindow.DialogText.Text = "Wczytywanie pliku INVOICE";

            try
            {
                Data.Invoices = XMLSerialization.ReadFromXmlFile<List<Invoice>>(INVOICES_LIST);
            }
            catch
            {
                MessageBox.Show("Plik z danymi nie istnieje, lub jest uszkodzony. INVOICES");
                if (!File.Exists(INVOICES_LIST))
                {
                    File.Create(INVOICES_LIST).Close();
                }
                Data.Invoices = new List<Invoice>();
                Data.SaveInvoice();
            }

            textWindow.DialogText.Text = "Wczytywanie pliku CONFIG";

            try
            {
                Data.Config = XMLSerialization.ReadFromXmlFile<Config>(CONFIG);
            }
            catch
            {
                MessageBox.Show("Plik z danymi nie istnieje, lub jest uszkodzony. CONFIG");
                if (!File.Exists(CONFIG))
                {
                    File.Create(CONFIG).Close();
                }
                Data.Config = new Config();
                Data.SaveConfig();
            }

            textWindow.DialogText.Text = "Wczytywanie pliku TEMPLACE INVOICE";

            try
            {
                if (!File.Exists(TEMPLATE_INVOICE))
                {
                    File.Create(TEMPLATE_INVOICE).Close();
                }
                Data.Template = XMLSerialization.ReadFromXmlFile<Invoice>(TEMPLATE_INVOICE);
            }
            catch
            {
                MessageBox.Show("Plik z danymi nie istnieje, lub jest uszkodzony. TEMPLATE_INVOICE");
                Data.Template = new Invoice() { InvoiceNumer = -1 };
                Data.SaveTemplate();
            }
            textWindow.Close();

        }

        public static void IsFileLocked(string path)
        {
            FileStream stream = null;
            FileInfo file = new FileInfo(path);

            try
            {
                stream = file.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            }
            catch (IOException exception)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)

                DialogResult result;
                result = MessageBox.Show("Plik " + file + " jest obecnie uzywany przez inny proces. Wyłącz wszystkie inne programy i spróbuj ponownie.", "Błąd", MessageBoxButtons.RetryCancel);
                //result = MessageBox.Show(, "Błąd", MessageBoxButtons.RetryCancel);
                if (result == DialogResult.Cancel)
                {
                    Process.GetCurrentProcess().Kill();
                }
                if (result == DialogResult.Retry)
                {
                    IsFileLocked(path);
                }
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
        }

        public static DateTime getModificationDate(string path)
        {
            FileInfo file = new FileInfo(path);
            return file.LastWriteTime;
        }

        public static void Replace(string path, byte[] data)
        {
            File.WriteAllBytes(path, data);
        }

    }
}
