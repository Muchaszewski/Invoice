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

namespace Faktury.DialogBox
{
    public partial class ItemChoose : Form
    {
        private int sortColumn = 0;
        private char prevKey = 'a';

        public delegate void OnItemAdded();
        public static event OnItemAdded onItemAdded;

        public ItemChoose()
        {
            InitializeComponent();
            RebuildItems();
            Data.onItemChange += RebuildItems;
            this.listViewItems.ListViewItemSorter = new ListViewItemComparer(listViewItems.Columns[1].Index, listViewItems.Sorting);
            this.listViewItems.Sort();
        }

        public static void RebuildItemAddedEventCaller()
        {
            if (onItemAdded != null)
            {
                onItemAdded();
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

        private void BAddItem_Click(object sender, EventArgs e)
        {
            Data.ItemInEditing = new Item();
            new ItemAdd().ShowDialog();
            if (Data.ItemInEditing.Name != null)
            {
                Data.Items.Add(Data.ItemInEditing);
            }
            Data.SaveItem();
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

        private void buttonEdit_Click(object sender, EventArgs e)
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

        private void ChooseItem()
        {
            if (listViewItems.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nie wybrano żadnego elementu");
            }
            else
            {
                int index = listViewItems.FocusedItem.ImageIndex;
                Data.ItemInEditing = Data.Items[index];
                new ItemAddToInvoice(false).ShowDialog();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChooseItem();
        }

        private void listView1_MousedecimalClick(object sender, MouseEventArgs e)
        {
            ChooseItem();
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine whether the column is the same as the last column clicked.
            if (e.Column != sortColumn)
            {
                // Set the sort column to the new column.
                sortColumn = e.Column;
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

        private void listView1_KeyPress(object sender, KeyPressEventArgs e)
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

    }
}
