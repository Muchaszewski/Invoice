using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Faktury.Utils;

namespace Faktury.DialogBox
{
    public partial class ContractorChoose : Form
    {
        private int sortColumn = -1;
        private char prevKey = 'a';

        public delegate void OnContractorAdded();
        public static event OnContractorAdded onContractorAdded;

        private int index;

        public ContractorChoose(int index)
        {
            InitializeComponent();
            RebuildContractors();
            Data.onContractorChange += RebuildContractors;
            this.index = index;
        }

        public static void RebuildItemAddedEventCaller()
        {
            if (onContractorAdded != null)
            {
                onContractorAdded();
            }
        }

        private void RebuildContractors()
        {
            int counter = 0;
            listViewContractors.Items.Clear();
            foreach (var item in Data.Contractors)
            {
                string[] row = { item.Name, Description.GetDescription(item.Type), item.City, item.Street, item.PostCode };
                var listViewItem = new ListViewItem(row, counter++);
                listViewContractors.Items.Add(listViewItem);
            }
        }

        private void buttonEditContractos_Click(object sender, EventArgs e)
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

        private void buttonAddContractor_Click(object sender, EventArgs e)
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
        private void Choose()
        {
            if (listViewContractors.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nie wybrano żadnego elementu");
            }
            else
            {
                Data.ContractorInEditing = Data.Contractors[listViewContractors.FocusedItem.ImageIndex];
                onContractorAdded();
                this.Close();
            }
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            Choose();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Choose();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine whether the column is the same as the last column clicked.
            if (e.Column != sortColumn)
            {
                // Set the sort column to the new column.
                sortColumn = e.Column;
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
    }
}
