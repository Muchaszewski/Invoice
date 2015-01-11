using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Faktury.DialogBox;
using Faktury.Items;
using Faktury.Utils;
using System.Diagnostics;

namespace Faktury
{
    public partial class FormMain : Form
    {
        private int sortColumnInvoice = -1;
        private int sortColumnContractors = -1;
        private int sortColumnItems = -1;

        private char prevKey = 'a';

        public delegate void OnItemAdded();
        public static event OnItemAdded onItemAdded;

        public FormMain()
        {
            InitializeComponent();
            RebuildInvoices();
            RebuildContractors();
            RebuildItems();
            this.listViewItems.ListViewItemSorter = new Sorter(listViewItems.Columns[1].Index, listViewItems.Sorting);
            this.listViewItems.Sort();
            this.listViewInvoice.ListViewItemSorter = new Sorter(listViewInvoice.Columns[0].Index, listViewInvoice.Sorting);
            this.listViewInvoice.Sort();

            this.dateTimePickerFrom.Value = DateTime.Now;
            this.dateTimePickerSince.Value = DateTime.Now;

            //Events
            Data.onInvoiceChange += RebuildInvoices;
            Data.onContractorChange += RebuildContractors;
            Data.onItemChange += RebuildItems;
        }


        private void RebuildInvoices()
        {
            listViewInvoice.Items.Clear();

            //Combobox lists
            List<object> comboBoxSellerList = new List<object>() {""};
            List<object> comboBoxPayerList = new List<object>() {""};
            List<object> comboBoxCityList = new List<object>() {""};

            //List called id
            int counter = 0;
            foreach (Invoice item in Data.Invoices)
            {
                if (dateTimePickerFrom.Value.Date != DateTime.Now.Date)
                {
                    if (item.DateMakeing.Date < dateTimePickerFrom.Value.Date)
                    {
                        continue;
                    }
                }
                if (dateTimePickerSince.Value.Date != DateTime.Now.Date)
                {
                    if (item.DateMakeing.Date > dateTimePickerSince.Value.Date)
                    {
                        continue;
                    }
                }
                if (comboBoxCity.SelectedIndex != -1 && comboBoxCity.SelectedIndex != 0)
                {
                    if (item.SellingPlace != comboBoxCity.Items[comboBoxCity.SelectedIndex].ToString())
                    {
                        continue;
                    }
                }
                if (comboBoxPayer.SelectedIndex != -1 && comboBoxPayer.SelectedIndex != 0)
                {
                    if (item.Contractors[1].Name != comboBoxPayer.Items[comboBoxPayer.SelectedIndex].ToString())
                    {
                        continue;
                    }
                }
                if (comboBoxSeller.SelectedIndex != -1 && comboBoxSeller.SelectedIndex != 0)
                {
                    if (item.Contractors[0].Name != comboBoxSeller.Items[comboBoxSeller.SelectedIndex].ToString())
                    {
                        continue;
                    }
                }
                if (textBoxSince.Text != "")
                {
                    if(float.Parse(textBoxSince.Text) > float.Parse(item.PriceTax.Remove(item.PriceTax.Length -2)))
                    {
                        continue;
                    }
                }
                if (textBoxUntil.Text != "")
                {
                    if (float.Parse(textBoxUntil.Text) < float.Parse(item.PriceTax.Remove(item.PriceTax.Length - 2)))
                    {
                        continue;
                    }
                }
                if (item.Contractors[0] != null && item.Contractors[1] != null)
                {
                    if (item.PriceTax == null)
                    {
                        item.PriceTax = "Odświerz fakturę, aby obliczyć";
                    }
                    string[] row = { item.InvoiceNumer.ToString(), item.DateMakeing.ToString(), item.Contractors[0].Name.ToString(), item.Contractors[1].Name.ToString(), item.SellingPlace.ToString(), item.PriceTax.ToString() };
                    var listViewItem = new ListViewItem(row, counter);
                    listViewInvoice.Items.Add(listViewItem);

                    if (comboBoxSeller.Items.Count == 0)
                    {
                        if (comboBoxSellerList.Contains(item.Contractors[0].Name) == false)
                        {
                            comboBoxSellerList.Add(item.Contractors[0].Name);
                        }
                        if (comboBoxPayerList.Contains(item.Contractors[1].Name) == false)
                        {
                            comboBoxPayerList.Add(item.Contractors[1].Name);
                        }
                        if (comboBoxCityList.Contains(item.SellingPlace) == false)
                        {
                            comboBoxCityList.Add(item.SellingPlace);
                        }
                    }
                }
                else
                {
                    string[] row = { item.InvoiceNumer.ToString(), item.DateMakeing.ToString(), "WYSTĄPIŁ BŁĄD PODCZAS ZAPISU" };
                    var listViewItem = new ListViewItem(row, counter);
                    listViewInvoice.Items.Add(listViewItem);
                }
                counter++;
            }
            if (comboBoxSeller.Items.Count == 0)
            {
                comboBoxSeller.Items.AddRange(comboBoxSellerList.ToArray());
                comboBoxPayer.Items.AddRange(comboBoxPayerList.ToArray());
                comboBoxCity.Items.AddRange(comboBoxCityList.ToArray());
            }
        }

        private void RebuildContractors()
        {
            int counter = 0;
            listViewContractors.Items.Clear();
            foreach (var item in Data.Contractors)
            {
                string[] row = { item.CompanyName, item.Name, Description.GetDescription(item.Type), item.City, item.Street, item.PostCode };
                var listViewContractorsItem = new ListViewItem(row, counter++);
                listViewContractors.Items.Add(listViewContractorsItem);
            }
        }

        private void RebuildItems()
        {
            listViewItems.Items.Clear();
            int counter = 0;
            foreach (var item in Data.Items)
            {
                string[] row = { (counter + 1).ToString(), item.Name, Description.GetDescription(item.Unit), Utils.Utils.ConvertToDigitsCostum(item.Price), Utils.Utils.ConvertToTax(item.Tax), Utils.Utils.CalculateTaxValue(item.Price, item.Tax), Utils.Utils.CalculateTaxValuePrice(item.Price, item.Tax) };
                var listViewItem = new ListViewItem(row, counter++);
                listViewItems.Items.Add(listViewItem);
            }
        }


        #region Invoice
        private void wyjścieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void opcjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormOptions().ShowDialog();
        }

        private void BAddItem_Click(object sender, EventArgs e)
        {
            new ItemAdd().ShowDialog();
        }
        private void buttonAddContractor_Click(object sender, EventArgs e)
        {
            new ContractorAdd().ShowDialog();
        }


        private void button4_Click_1(object sender, EventArgs e)
        {
            new InvoiceAdd(new Invoice()).ShowDialog();
        }

        private void edit()
        {
            if (listViewInvoice.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nie wybrano żadnego elementu");
            }
            else
            {
                new InvoiceAdd(Data.Invoices[listViewInvoice.FocusedItem.ImageIndex].Clone(), listViewInvoice.FocusedItem.ImageIndex).ShowDialog();
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            edit();
        }

        private void listView4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            edit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listViewInvoice.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nie wybrano żadnego elementu");
            }
            else
            {
                Data.DeleteInvoice(listViewInvoice.SelectedItems[0].Index);
            }
        }

        private void listView4_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine whether the column is the same as the last column clicked.
            if (e.Column != sortColumnInvoice)
            {
                // Set the sort column to the new column.
                sortColumnInvoice = e.Column;
                // Set the sort order to ascending by default.
                listViewInvoice.Sorting = SortOrder.Ascending;
            }
            else
            {
                // Determine what the last sort order was and change it.
                if (listViewInvoice.Sorting == SortOrder.Ascending)
                    listViewInvoice.Sorting = SortOrder.Descending;
                else
                    listViewInvoice.Sorting = SortOrder.Ascending;
            }
            this.listViewInvoice.ListViewItemSorter = new Sorter(e.Column, listViewInvoice.Sorting);
            listViewInvoice.Sort();

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerSince.Value < dateTimePickerFrom.Value)
            {
                dateTimePickerSince.Value = dateTimePickerFrom.Value;
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerSince.Value < dateTimePickerFrom.Value)
            {
                dateTimePickerFrom.Value = dateTimePickerSince.Value;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            dateTimePickerFrom.Value = DateTime.Now;
            dateTimePickerSince.Value = DateTime.Now;
            comboBoxSeller.SelectedIndex = -1;
            comboBoxPayer.SelectedIndex = -1;
            comboBoxCity.SelectedIndex = -1;
            textBoxUntil.Text = "";
            textBoxSince.Text = "";
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            RebuildInvoices();
        }
        #endregion

        #region Contractors

        private void editContractors()
        {
            if (listViewContractors.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nie wybrano żadnego elementu");
            }
            else
            {
                int index = listViewContractors.SelectedItems[0].ImageIndex;
                new ContractorAdd(index).ShowDialog();
            }
        }

        private void buttonEditContractos_Click(object sender, EventArgs e)
        {
            editContractors();
        }
        private void listViewContractors_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            editContractors();
        }

        private void buttonAddContractor_Click_1(object sender, EventArgs e)
        {
            new ContractorAdd().ShowDialog();
        }

        private void buttonDeleteContractors_Click(object sender, EventArgs e)
        {
            if (listViewContractors.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nie wybrano żadnego elementu");
            }
            else
            {
                int index = listViewContractors.SelectedItems[0].ImageIndex;
                Data.DeleteContractor(index);
                listViewContractors.SelectedItems.Clear();
            }
        }

        private void listViewContractors_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine whether the column is the same as the last column clicked.
            if (e.Column != sortColumnContractors)
            {
                // Set the sort column to the new column.
                sortColumnContractors = e.Column;
                // Set the sort order to ascending by default.
                listViewContractors.Sorting = SortOrder.Ascending;
            }
            else
            {
                // Determine what the last sort order was and change it.
                if (listViewContractors.Sorting == SortOrder.Ascending)
                    listViewContractors.Sorting = SortOrder.Descending;
                else
                    listViewContractors.Sorting = SortOrder.Ascending;
            }
            listViewContractors.Sort();
            this.listViewContractors.ListViewItemSorter = new ListViewItemComparer(e.Column, listViewContractors.Sorting);
        }

        private void listViewContractors_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                int index;
                if (prevKey != e.KeyChar)
                {
                    index = listViewContractors.FindItemWithText(e.KeyChar + "").Index;
                    prevKey = e.KeyChar;
                }
                else
                {
                    if (listViewContractors.Items[listViewContractors.FocusedItem.Index + 1].SubItems[1].Text[0] == prevKey)
                    {
                        index = listViewContractors.FocusedItem.Index + 1;
                    }
                    else
                    {
                        index = listViewContractors.FindItemWithText(e.KeyChar + "").Index;
                    }
                }
                listViewContractors.Items[index].Selected = true;
                listViewContractors.Items[index].Focused = true;
                listViewContractors.Items[index].EnsureVisible();
            }
            catch
            {

            }
        }
        #endregion

        #region Items
        public static void RebuildItemAddedEventCaller()
        {
            if (onItemAdded != null)
            {
                onItemAdded();
            }
        }

        private void BAddItem_Click_1(object sender, EventArgs e)
        {
            Data.ItemInEditing = new Item();
            new ItemAdd().ShowDialog();
            if (Data.ItemInEditing.Name != null)
            {
                Data.Items.Add(Data.ItemInEditing);
            }
            Data.SaveItem();
        }

        private void editItems()
        {
            if (listViewItems.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nie wybrano żadnego elementu");
            }
            else
            {
                int index = listViewItems.FocusedItem.ImageIndex;
                Data.ItemInEditing = Data.Items[index];
                new ItemAdd().ShowDialog();
                Data.Items[index] = Data.ItemInEditing;
                Data.SaveItem();
            }
        }

        private void buttonEditItem_Click(object sender, EventArgs e)
        {
            editItems();
        }

        private void listViewItems_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            editItems();
        }

        private void BDeleteItem_Click(object sender, EventArgs e)
        {
            if (listViewItems.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nie wybrano żadnego elementu");
            }
            else
            {
                int index = listViewItems.SelectedItems[0].ImageIndex;
                Data.DeleteItem(index);
                listViewItems.SelectedItems.Clear();
            }
        }

        private void listViewItems_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine whether the column is the same as the last column clicked.
            if (e.Column != sortColumnItems)
            {
                // Set the sort column to the new column.
                sortColumnItems = e.Column;
                // Set the sort order to ascending by default.
                listViewItems.Sorting = SortOrder.Ascending;
            }
            else
            {
                // Determine what the last sort order was and change it.
                if (listViewItems.Sorting == SortOrder.Ascending)
                    listViewItems.Sorting = SortOrder.Descending;
                else
                    listViewItems.Sorting = SortOrder.Ascending;
            }
            listViewItems.Sort();
            this.listViewItems.ListViewItemSorter = new ListViewItemComparer(e.Column, listViewItems.Sorting);

        }

        private void listViewItems_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                int index;
                if (prevKey != e.KeyChar)
                {
                    index = listViewItems.FindItemWithText(e.KeyChar + "").Index;
                    prevKey = e.KeyChar;
                }
                else
                {
                    if (listViewItems.Items[listViewItems.FocusedItem.Index + 1].SubItems[1].Text[0] == prevKey)
                    {
                        index = listViewItems.FocusedItem.Index + 1;
                    }
                    else
                    {
                        index = listViewItems.FindItemWithText(e.KeyChar + "").Index;
                    }
                }
                listViewItems.Items[index].Selected = true;
                listViewItems.Items[index].Focused = true;
                listViewItems.Items[index].EnsureVisible();
            }
            catch
            {

            }
        }
        #endregion

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.F))
            {
                if (this.tabControl.SelectedIndex == 0)
                {
                    //new InvoiceFilter().Show();
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new InvoiceAdd(Data.Template, -1).ShowDialog();
        }

      
    }

}

