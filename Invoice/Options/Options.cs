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
using Faktury.Utils;
using Faktury.Options;
using Faktury.Utils.Backup;
using Faktury.Items;
using Faktury.DialogBox;

namespace Faktury
{
    public partial class FormOptions : Form
    {
        public FormOptions()
        {
            InitializeComponent();
            populateCurrencyComboBox();
            textBoxNextInvoiceNr.Text = Data.Config.InvoiceNumer.ToString();
            comboBoxCurrency.SelectedIndex = (int)Data.Config.NewDefaultCurrency;
            comboBoxCurrencyDefault.SelectedIndex = (int)Data.Config.ConvertedCurrency;
            comboBoxPayment.SelectedIndex = Data.Config.DefaultPayment;

            labelVersion.Text = "Version: " +  Application.ProductVersion;
            labelVersionOnline.Text = "Version Online: " + VersionChecker.latestVersion;

#if DEBUG
            textBox2.Visible = true;
            labelCommand.Visible = true;
#endif

            if(Program.GoogleAPI == false)
            {
                buttonNewGoogle.Enabled = false;
            }
        }

        private void populateCurrencyComboBox()
        {
            foreach (ECurrencyItem item in (ECurrencyItem[])Enum.GetValues(typeof(ECurrencyItem)))
            {
                comboBoxCurrency.Items.Add(Utils.Description.GetDescription(item));
                comboBoxCurrencyDefault.Items.Add(Utils.Description.GetDescription(item));
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBoxNextInvoiceNr.Text, @"\d"))
            {
            Data.Config.InvoiceNumer = int.Parse(textBoxNextInvoiceNr.Text);
            Data.SaveConfig();
            }
        }

        private void checkBoxDEBUG_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonRestoreLoad_Click(object sender, EventArgs e)
        {
            new BackupMenu().ShowDialog();
        }

        private void buttonNewGoogle_Click(object sender, EventArgs e)
        {
            GoogleDriveBackup.Make();
        }

        private void comboBoxCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            Data.Config.NewDefaultCurrency = (ECurrencyItem)comboBoxCurrency.SelectedIndex;
            Data.SaveConfig();
        }

        private void comboBoxCurrencyDefault_SelectedIndexChanged(object sender, EventArgs e)
        {
            Data.Config.ConvertedCurrency = (ECurrencyItem)comboBoxCurrencyDefault.SelectedIndex;
            Data.SaveConfig();
        }

        private void comboBoxPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            Data.Config.DefaultPayment = comboBoxPayment.SelectedIndex;
            Data.SaveConfig();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new InvoiceAdd(Data.Template,-2).ShowDialog();
        }

        private void FOptions_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "Update")
            {
                VersionChecker.OpenSqlConnectionUpdate();
                MessageBox.Show("Updated");
                textBox2.Text = "";
            }
        }
    }
}
