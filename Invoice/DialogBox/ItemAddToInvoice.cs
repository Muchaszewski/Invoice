using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Faktury.Items;
using Faktury.Utils;

namespace Faktury.DialogBox
{
    public partial class ItemAddToInvoice : Form
    {
        private bool edit;
        private Item item = Data.ItemInEditing;
        public ItemAddToInvoice(bool edit)
        {
            this.edit = edit;
            InitializeComponent();
            if (edit == true)
            {
                buttonAdd.Text = "Edytuj";
                textBoxQuantity.Text = item.Quantity.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBoxQuantity.Text, @"\d"))
            {
                int t = Convert.ToInt32(textBoxQuantity.Text);
                if (t > 0)
                {
                    item.Quantity = t;
                    if (!edit)
                    {
                        Data.ItemsToAdd.Add(item.Clone());
                    }
                    ItemChoose.RebuildItemAddedEventCaller();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ilość musi być nie ujemja");
                }
            }
            else
            {
                MessageBox.Show("Ilość musi być liczbą");
            }
        }

        private void textBoxQ_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBoxQuantity.Text, @"\d"))
            {
                int t = Convert.ToInt32(textBoxQuantity.Text);
                if (t > 0)
                {
                    textBoxTotalValue.Text = Utils.Utils.CalculateQuantityValue(item.Price, item.Tax, t);
                }
                else
                {
                    textBoxTotalValue.Text = Utils.Utils.CalculateQuantityValue(item.Price, item.Tax, 1);
                }
            }
            else
            {
                textBoxTotalValue.Text = Utils.Utils.CalculateQuantityValue(item.Price, item.Tax, 1);
            }
        }
    }
}
