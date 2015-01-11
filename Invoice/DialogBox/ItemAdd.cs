using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Faktury.Items;
using Faktury.Utils;

namespace Faktury.DialogBox
{
    public partial class ItemAdd : Form
    {
        bool edit = false;
        public ItemAdd()
        {
            InitializeComponent();
            if (Data.ItemInEditing.Name == null)
            {
                createEmpty();
            }
            else
            {
                load();
            }

        }

        private void createEmpty()
        {
            comboBoxType.SelectedIndex = 0;
        }

        private void load()
        {
            edit = true;

            buttonConfirm.Text = "Edytuj";

            TextBoxName.Text = Data.ItemInEditing.Name;
            textBoxPrice.Text = Utils.Utils.ConvertToDigitsCostum(Data.ItemInEditing.Price);
            textBoxTax.Text = Data.ItemInEditing.Tax.ToString();

            comboBoxType.SelectedIndex = (int)Data.ItemInEditing.Unit;

            update();
        }

        private void save()
        {
            if (TextBoxName.Text == "")
            {
                DialogResult resault;
                resault = MessageBox.Show("Brak nazwy produktu\r\nDodaj nazwę i spróbuj ponownie", "Ostrzeżenie");
            }
            else
            {
                Data.ItemInEditing.Name = TextBoxName.Text;
                Data.ItemInEditing.Price = decimal.Parse(textBoxPrice.Text);
                Data.ItemInEditing.Tax = Convert.ToInt32(textBoxTax.Text);
                Data.ItemInEditing.Unit = (EUnitItem)comboBoxType.SelectedIndex;
                this.Close();
            }
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BConfirm_Click(object sender, EventArgs e)
        {
            save();
        }

        /// <summary>
        /// Calculate Value and Price
        /// </summary>
        private void update()
        {
            decimal temp;
            if (decimal.TryParse(textBoxPrice.Text, out temp))
            {
                textBoxTaxValue.Text = Utils.Utils.CalculateTaxValue(decimal.Parse(textBoxPrice.Text), Convert.ToInt32(textBoxTax.Text));
                textBoxPriceTotal.Text = Utils.Utils.CalculateTaxValuePrice(decimal.Parse(textBoxPrice.Text), Convert.ToInt32(textBoxTax.Text));
            }
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            update();
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '.')
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

        private void textBoxTax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
