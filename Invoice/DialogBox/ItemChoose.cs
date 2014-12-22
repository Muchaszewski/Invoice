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
            this.listView1.ListViewItemSorter = new ListViewItemComparer(listView1.Columns[1].Index, listView1.Sorting);
            this.listView1.Sort();
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
            listView1.Items.Clear();
            int counter = 0;
            foreach (var item in Data.Items)
            {
                string[] row = { (counter + 1).ToString(), item.Name, Description.GetDescription(item.Unit), Utils.Utils.ConvertToDigitsCostum(item.Price), Utils.Utils.ConvertToTax(item.Tax), Utils.Utils.CalculateTaxValue(item.Price, item.Tax), Utils.Utils.CalculateTaxValuePrice(item.Price, item.Tax) };
                var listViewItem = new ListViewItem(row, counter++);
                listView1.Items.Add(listViewItem);
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
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nie wybrano żadnego elementu");
            }
            else
            {
                int index = listView1.SelectedItems[0].ImageIndex;
                Data.DeleteItem(index);
                listView1.SelectedItems.Clear();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nie wybrano żadnego elementu");
            }
            else
            {
                int index = listView1.FocusedItem.ImageIndex;
                Data.ItemInEditing = Data.Items[index];
                new ItemAdd().ShowDialog();
                Data.Items[index] = Data.ItemInEditing;
                Data.SaveItem();
            }
        }

        private void ChooseItem()
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nie wybrano żadnego elementu");
            }
            else
            {
                int index = listView1.FocusedItem.ImageIndex;
                Data.ItemInEditing = Data.Items[index];
                new ItemAddToInvoice().ShowDialog();

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
                listView1.Sorting = SortOrder.Ascending;
            }
            else
            {
                // Determine what the last sort order was and change it.
                if (listView1.Sorting == SortOrder.Ascending)
                    listView1.Sorting = SortOrder.Descending;
                else
                    listView1.Sorting = SortOrder.Ascending;
            }
            listView1.Sort();
            this.listView1.ListViewItemSorter = new ListViewItemComparer(e.Column, listView1.Sorting);

        }

        private void listView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                int index;
                if (prevKey != e.KeyChar)
                {
                    index = listView1.FindItemWithText(e.KeyChar + "").Index;
                    prevKey = e.KeyChar;
                }
                else
                {
                    if (listView1.Items[listView1.FocusedItem.Index + 1].SubItems[1].Text[0] == prevKey)
                    {
                        index = listView1.FocusedItem.Index + 1;
                    }
                    else
                    {
                        index = listView1.FindItemWithText(e.KeyChar + "").Index;
                    }
                }
                listView1.Items[index].Selected = true;
                listView1.Items[index].Focused = true;
                listView1.Items[index].EnsureVisible();
            }
            catch
            {

            }
        }

    }
}
