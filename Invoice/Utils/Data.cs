using Faktury.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Faktury.DialogBox;

namespace Faktury.Utils
{
    static class Data
    {
        public static List<Item> ItemsToAdd { get; set; }
        public static Item ItemInEditing;

        public static List<Item> Items;
        public delegate void OnItemChanged();
        public static event OnItemChanged onItemChange;

        public static List<Contractor> Contractors;
        public static Contractor ContractorInEditing;
        public delegate void OnContractorChange();
        public static event OnContractorChange onContractorChange;

        public static List<Invoice> Invoices;
        public static Invoice InvoiceInEditing;
        public delegate void OnInvoiceChanged();
        public static event OnInvoiceChanged onInvoiceChange;

        public static Config Config = new Config();
        public delegate void OnConfigChanged();
        public static event OnConfigChanged onConfigChange;

        public static Invoice Template = new Invoice() { InvoiceNumer = -1 };

        #region Save
        public static void SaveItem()
        {
            //Items.Sort();
            XMLSerialization.WriteToXmlFile(FileWriter.ITEMS_LIST, Items);
            if (onItemChange != null)
            {
                onItemChange();
            }
        }

        public static void SaveContractor()
        {
            //Contractors.Sort();
            XMLSerialization.WriteToXmlFile(FileWriter.CONTRACTORS_LIST, Contractors);
            if (onContractorChange != null)
            {
                onContractorChange();
            }
        }

        public static void SaveInvoice()
        {
            //Invoices.Sort();
            XMLSerialization.WriteToXmlFile(FileWriter.INVOICES_LIST, Invoices);
            if (onInvoiceChange != null)
            {
                onInvoiceChange();
            }
        }

        public static void SaveTemplate()
        {
            XMLSerialization.WriteToXmlFile(FileWriter.TEMPLATE_INVOICE, Template);
        }

        public static void SaveConfig()
        {
            XMLSerialization.WriteToXmlFile(FileWriter.CONFIG, Config);
        }
        #endregion

        #region Delete
        public static void DeleteItem(int index)
        {

            DialogResult resault;
            resault = MessageBox.Show("Czy napewno chcesz usunąć " + Items[index].Name, "Ostrzeżenie", MessageBoxButtons.YesNo);
            if (resault == DialogResult.Yes)
            {
                Items.RemoveAt(index);
                SaveItem();
            }
        }

        public static void DeleteContractor(int index)
        {

            DialogResult resault;
            resault = MessageBox.Show("Czy napewno chcesz usunąć " + Contractors[index].Name, "Ostrzeżenie", MessageBoxButtons.YesNo);
            if (resault == DialogResult.Yes)
            {
                Contractors.RemoveAt(index);
                SaveContractor();
            }
        }

        public static void DeleteInvoice(int index)
        {

            DialogResult resault;
            resault = MessageBox.Show("Czy napewno chcesz usunąć fakturę nr." + Invoices[index].InvoiceNumer.ToString(), "Ostrzeżenie", MessageBoxButtons.YesNo);
            if (resault == DialogResult.Yes)
            {
                Invoices.RemoveAt(index);
                SaveInvoice();
            }
        }
        #endregion
    }
}
