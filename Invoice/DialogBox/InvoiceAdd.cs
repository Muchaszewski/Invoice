using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Faktury.Items;
using Faktury.Utils;

namespace Faktury.DialogBox
{
    public partial class InvoiceAdd : Form
    {
        private int edit;
        private bool saved;

        public Invoice sInvoice = new Invoice();

        private List<Tax> totalTaxOnlyValue = new List<Tax>();
        public List<Tax> TotalTaxOnlyValue
        {
            get { return totalTaxOnlyValue; }
        }

        private GetNBPRates _NBPRates = new GetNBPRates(DateTime.Today);
        public GetNBPRates NBPRates
        {
            get { return _NBPRates; }
        }


        public InvoiceAdd(Invoice invoice, int index = -1)
        {
            edit = index;
            InitializeComponent();
            populateCurrencyComboBox();
            sInvoice = invoice.Clone();

            if (edit == -1 || edit == -2)
            {
                RebuildItems();
                comboBoxPaymentCheck.SelectedIndex = Data.Config.DefaultPayment;
                if (sInvoice.Contractors.Count == 0)
                {
                    sInvoice.Contractors.Add(null);
                    sInvoice.Contractors.Add(null);
                }
                else
                {
                    RebuildContractors();
                }
                comboBoxCurrency.SelectedIndex = (int)sInvoice.Currency;
                RebuildOtherData();
                if (edit == -2)
                {
                    TemplateEdit();
                }
            }
            else
            {
                comboBoxPaymentCheck.SelectedIndex = sInvoice.PaymentType;
                comboBoxCurrency.SelectedIndex = (int)sInvoice.Currency;
                RebuildItems();
                RebuildContractors();
                RebuildOtherData();
            }

            ItemChoose.onItemAdded += RebuildItems;
            ContractorChoose.onContractorAdded += RebuildContractors;

            textBoxTable.Text = NBPRates.GetCurrenciesTable("EUR");
            textBoxCurrency.Text = NBPRates.GetCurrenciesRate("EUR");
            if (sInvoice.InvoiceNumer == -1)
            {
                sInvoice.InvoiceNumer = Data.Config.InvoiceNumer;
            }
            textBoxNr.Text = sInvoice.InvoiceNumer.ToString();
            saved = true;
        }

        private void TemplateEdit()
        {
            textBoxNr.Enabled = false;
            textBoxNrYear.Enabled = false;
            dateTimePickerMaking.Enabled = false;
            dateTimePickerSelling.Enabled = false;
            comboBoxPaymentCheck.Enabled = false;
            textBoxAddNote.Enabled = false;
            comboBoxCurrency.Enabled = false;
            dateTimePickerTable.Enabled = false;
            checkBox1.Checked = false;
            textBoxPlace.Enabled = false;
        }

        private void populateCurrencyComboBox()
        {
            foreach (ECurrencyItem item in (ECurrencyItem[])Enum.GetValues(typeof(ECurrencyItem)))
            {
                comboBoxCurrency.Items.Add(Utils.Description.GetDescription(item));
            }
        }

        private void RebuildOtherData()
        {
            if (sInvoice.DateMakeing > dateTimePickerMaking.MinDate)
            {
                dateTimePickerMaking.Value = sInvoice.DateMakeing;
            }
            if (sInvoice.DateSelling > dateTimePickerSelling.MinDate)
            {
                dateTimePickerSelling.Value = sInvoice.DateSelling;
            }
            if (sInvoice.DateTable > dateTimePickerMaking.MinDate)
            {
                dateTimePickerTable.Value = sInvoice.DateTable;
            }
            if (sInvoice.SellingPlace != null)
            {
                textBoxPlace.Text = sInvoice.SellingPlace;
            }
            else
            {
                if (sInvoice.Contractors[0] != null)
                    textBoxPlace.Text = textBoxPlace.Text = sInvoice.Contractors[0].City;
            }
            if (sInvoice.Warning != "")
            {
                checkBox1.Checked = true;
                textBoxWarning.Text = sInvoice.Warning;
            }
            else
            {
                checkBox1.Checked = false;
            }

            if (sInvoice.PaymentInfo != null)
            {
                textBoxAddNote.Text = sInvoice.PaymentInfo;
            }
            else
            {
                if (comboBoxPaymentCheck.SelectedIndex == 1)
                {
                    textBoxAddNote.Text = "45 dni od daty dostarczenia kpl. dokumentów";
                }
                if (comboBoxPaymentCheck.SelectedIndex == 0)
                {
                    textBoxAddNote.Text = DateTime.Now.ToShortDateString();
                }
            }
            if (textBoxNrYear.Text == "Year")
            {
                if (edit != -1 && edit != -2)
                {
                    if (sInvoice.InvoiceDate == null)
                    {
                        textBoxNrYear.Text = sInvoice.DateMakeing.Year.ToString();
                    }
                    else
                    {
                        textBoxNrYear.Text = sInvoice.InvoiceDate;
                    }
                }
                else
                {
                    textBoxNrYear.Text = DateTime.Now.Year.ToString();
                }
            }
        }

        private void SaveOtherData()
        {

            sInvoice.DateMakeing = dateTimePickerMaking.Value;
            sInvoice.DateSelling = dateTimePickerSelling.Value;
            sInvoice.PaymentType = comboBoxPaymentCheck.SelectedIndex;
            sInvoice.DateTable = dateTimePickerTable.Value;
            sInvoice.SellingPlace = textBoxPlace.Text;
            sInvoice.Warning = textBoxWarning.Text;
            sInvoice.InvoiceNumer = Convert.ToInt32(textBoxNr.Text);
            sInvoice.InvoiceDate = textBoxNrYear.Text;
            sInvoice.PriceTax = textBoxTaxValue1.Text;
            sInvoice.PaymentInfo = textBoxAddNote.Text;
        }

        private void RebuildItems()
        {
            listView1.Items.Clear();
            decimal tax = 0;
            decimal totalValue = 0;
            decimal totalTaxValue = 0;
            TotalTaxOnlyValue.Clear();
            int i = 1;
            foreach (var item in sInvoice.Items)
            {
                //ListviewDisplay
                string[] row = {
                                   i++.ToString(),
                                   item.Name, 
                                   item.Quantity.ToString(), 
                                   Description.GetDescription(item.Unit), 
                                   Utils.Utils.ConvertToDigitsCostum(item.Price), 
                                   Utils.Utils.ConvertToTax(item.Tax), 
                                   Utils.Utils.CalculateTaxValuePrice(item.Price, item.Tax), 
                                   Utils.Utils.CalculateQuantityValue(item.Price, item.Tax, item.Quantity),
                                   Utils.Utils.CalculateTaxQuantityValue(item.Price, item.Tax, item.Quantity) 
                               };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);

                //Summary

                decimal value = 0;
                decimal valuetax = 0;
                valuetax = (item.Price * ((decimal)item.Tax / 100m));
                valuetax *= item.Quantity;
                tax += valuetax;

                value = 0;
                value = (item.Price);
                value *= item.Quantity;
                totalValue += value;

                totalTaxValue = tax + totalValue;

                if (TotalTaxOnlyValue == null)
                {
                    TotalTaxOnlyValue.Add(new Tax(item.Tax, value, valuetax));
                }
                else
                {
                    bool broken = false;
                    foreach (Tax it in TotalTaxOnlyValue)
                    {
                        if (it.TaxAmount == item.Tax)
                        {
                            it.Price += value;
                            it.PriceTax += valuetax + value;
                            broken = true;
                            break;
                        }
                    }
                    if (broken == false)
                    {
                        TotalTaxOnlyValue.Add(new Tax(item.Tax, value, valuetax + value));
                    }
                }

            }
            textBoxTax1.Text = Utils.Utils.ConvertToPriceCostum(tax, sInvoice.Currency);
            textBoxValue1.Text = Utils.Utils.ConvertToPriceDefault(totalValue, sInvoice.Currency);
            textBoxTaxValue1.Text = Utils.Utils.ConvertToPriceDefault(totalTaxValue, sInvoice.Currency);

            if (sInvoice.Currency != Data.Config.ConvertedCurrency)
            {
                textBoxTaxDefault.Visible = true;
                textBoxValueDefault.Visible = true;
                textBoxTaxValueDefault.Visible = true;
                labelDefaultCurrency.Visible = true;
                labelDefaultCurrencyCopy.Visible = true;
                labelCurrency.Visible = true;
                textBoxCurrency.Visible = true;
                textBoxTable.Visible = true;
                labelDateCurrency.Visible = true;
                dateTimePickerTable.Visible = true;

                if (Data.Config.ConvertedCurrency == ECurrencyItem.PLN)
                {
                    textBoxTaxDefault.Text = Utils.Utils.ConvertToPriceCostum(tax * decimal.Parse(NBPRates.GetCurrenciesRate("EUR")), ECurrencyItem.PLN);
                    textBoxValueDefault.Text = Utils.Utils.ConvertToPriceCostum(totalValue * decimal.Parse(NBPRates.GetCurrenciesRate("EUR")), ECurrencyItem.PLN);
                    textBoxTaxValueDefault.Text = Utils.Utils.ConvertToPriceCostum(totalTaxValue * decimal.Parse(NBPRates.GetCurrenciesRate("EUR")), ECurrencyItem.PLN);
                    labelDefaultCurrency.Text = "w złotych";
                    labelDefaultCurrencyCopy.Text = "w złotych";
                }

                if (Data.Config.ConvertedCurrency == ECurrencyItem.EUR)
                {
                    textBoxTaxDefault.Text = Utils.Utils.ConvertToPriceCostum(tax / decimal.Parse(NBPRates.GetCurrenciesRate("EUR")), ECurrencyItem.EUR);
                    textBoxValueDefault.Text = Utils.Utils.ConvertToPriceCostum(totalValue / decimal.Parse(NBPRates.GetCurrenciesRate("EUR")), ECurrencyItem.EUR);
                    textBoxTaxValueDefault.Text = Utils.Utils.ConvertToPriceCostum(totalTaxValue / decimal.Parse(NBPRates.GetCurrenciesRate("EUR")), ECurrencyItem.EUR);
                    labelDefaultCurrency.Text = "w euro";
                    labelDefaultCurrencyCopy.Text = "w euro";
                }
            }
            else
            {
                textBoxTaxDefault.Visible = false;
                textBoxValueDefault.Visible = false;
                textBoxTaxValueDefault.Visible = false;
                labelDefaultCurrency.Visible = false;
                labelDefaultCurrencyCopy.Visible = false;
                labelCurrency.Visible = false;
                textBoxCurrency.Visible = false;
                textBoxTable.Visible = false;
                labelDateCurrency.Visible = false;
                dateTimePickerTable.Visible = false;
            }
            textBoxNumberToWord.Text = Utils.NumberFormatting.NumberToWord(Convert.ToInt32(totalTaxValue)) + " " +
                Utils.NumberFormatting.CurrencyToWord(Convert.ToInt32(totalTaxValue), sInvoice.Currency.ToString()) + " i " + Utils.Utils.CalculateFrac(totalTaxValue) + "/100";
        }

        private void RebuildContractors()
        {
            if (sInvoice.Contractors[0] != null)
            {
                textBoxSeller1.Text = Description.GetDescription(sInvoice.Contractors[0].Type);
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append(sInvoice.Contractors[0].CompanyName + "\r\n");
                stringBuilder.Append(sInvoice.Contractors[0].Name + "\r\n");
                stringBuilder.Append(sInvoice.Contractors[0].Street + ", " + sInvoice.Contractors[0].PostCode + " " + sInvoice.Contractors[0].City + "\r\n");
                stringBuilder.Append("NIP: " + sInvoice.Contractors[0].NIP);
                if (sInvoice.Contractors[0].REGON != "")
                {
                    stringBuilder.Append("   REGON: " + sInvoice.Contractors[0].REGON + "\r\n" + "\r\n");
                }
                stringBuilder.Append("Numer rachunku bankowego: " + "\r\n");
                stringBuilder.Append("" + sInvoice.Contractors[0].BankAccName + "\r\n");
                stringBuilder.Append("" + sInvoice.Contractors[0].BankAcc);
                textBoxData1.Text = stringBuilder.ToString();
                textBoxPlace.Text = sInvoice.Contractors[0].City;
            }
            if (sInvoice.Contractors[1] != null)
            {
                textBoxSeller2.Text = Description.GetDescription(sInvoice.Contractors[1].Type);
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append(sInvoice.Contractors[1].CompanyName + "\r\n");
                stringBuilder.Append(sInvoice.Contractors[1].Name + "\r\n");
                stringBuilder.Append(sInvoice.Contractors[1].Street + ", " + sInvoice.Contractors[1].PostCode + " " + sInvoice.Contractors[1].City + "\r\n");
                stringBuilder.Append("NIP: " + sInvoice.Contractors[1].NIP);
                if (sInvoice.Contractors[1].REGON != "")
                {
                    stringBuilder.Append("   REGON: " + sInvoice.Contractors[1].REGON + "\r\n" + "\r\n");
                }
                textBoxData2.Text = stringBuilder.ToString();
                //"Numer konta bankowego: " + sInvoice.Contractors[1].BankAcc;
            }
        }
        //________________________________________________________________________________
        #region Events
        //________________________________________________________________________________
        private void buttonChoose1_Click(object sender, EventArgs e)
        {
            Data.ContractorInEditing = sInvoice.Contractors[0];
            new ContractorChoose(0).ShowDialog();
            sInvoice.Contractors[0] = Data.ContractorInEditing;
            RebuildContractors();
        }

        private void buttonChoose2_Click(object sender, EventArgs e)
        {
            Data.ContractorInEditing = sInvoice.Contractors[1];
            new ContractorChoose(1).ShowDialog();
            sInvoice.Contractors[1] = Data.ContractorInEditing;
            RebuildContractors();

        }

        private void comboBoxPaymentCheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            saved = false;
            if (comboBoxPaymentCheck.SelectedIndex == 1)
            {
                if (textBoxAddNote.Text == "" || textBoxAddNote.Text == DateTime.Now.ToShortDateString())
                {
                    textBoxAddNote.Text = "45 dni od daty dostarczenia kpl. dokumentów";
                }
            }
            if (comboBoxPaymentCheck.SelectedIndex == 0)
            {
                if (textBoxAddNote.Text == "" || textBoxAddNote.Text == "45 dni od daty dostarczenia kpl. dokumentów")
                {
                    textBoxAddNote.Text = DateTime.Now.ToShortDateString();
                }
            }
        }

        private void BAddItem_Click(object sender, EventArgs e)
        {
            saved = false;
            Data.ItemsToAdd = new List<Item>();
            new ItemChoose().ShowDialog();
            foreach (Item item in Data.ItemsToAdd)
            {
                sInvoice.Items.Add(item);
            }
            RebuildItems();

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nie wybrano żadnego elementu");
            }
            else
            {
                saved = false;
                int index = listView1.FocusedItem.Index;
                Data.ItemInEditing = sInvoice.Items[index];
                new ItemAddToInvoice().ShowDialog();
                sInvoice.Items[index] = Data.ItemInEditing;
                RebuildItems();
            }
        }

        private void BDeleteItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nie wybrano żadnego elementu");
            }
            else
            {
                saved = false;
                int index = listView1.SelectedItems[0].Index;

                DialogResult resault;
                resault = MessageBox.Show("Czy napewno chcesz usunąć " + sInvoice.Items[index].Name, "Ostrzeżenie", MessageBoxButtons.YesNo);
                if (resault == DialogResult.Yes)
                {
                    sInvoice.Items.RemoveAt(index);
                }
                RebuildItems();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.WindowState = FormWindowState.Maximized;
            ppd.PrintPreviewControl.AutoZoom = false;
            ppd.PrintPreviewControl.Zoom = 2.0f;
            ppd.PrintPreviewControl.Document = printDocument1;
            ppd.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Utils.PrintPreview.Draw(this, sender, e);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (groupBoxWarning.Visible == false)
                groupBoxWarning.Visible = true;
            else
            {
                textBoxWarning.Clear();
                groupBoxWarning.Visible = false;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (sInvoice.Contractors[0] == null || sInvoice.Contractors[1] == null)
            {
                MessageBox.Show("Brakuje Sprzedawcy/Nabywcy");
            }
            else
            {
                if (edit != -2)
                {
                    saved = true;
                    SaveOtherData();
                    if (edit == -1)
                    {
                        Data.Invoices.Add(sInvoice);
                        Data.Config.InvoiceNumer++;
                        Data.SaveConfig();
                        edit = Data.Invoices.Count - 1;
                    }
                    if (edit >= 0)
                    {
                        Data.Invoices[edit] = sInvoice;
                    }
                    Data.SaveInvoice();
                }
                else
                {
                    sInvoice.InvoiceNumer = -1;
                    Data.Template = sInvoice;
                    Data.SaveTemplate();
                    this.Close();
                }
            }

        }
        //textBoxAddNote.Text = "45 dni od daty dostarczenia dokumentów";
        private void dateTimePickerMaking_ValueChanged(object sender, EventArgs e)
        {
            saved = false;
            if (comboBoxPaymentCheck.SelectedIndex == 1)
            {
                textBoxAddNote.Text = "45 dni od daty dostarczenia dokumentów";
            }
            if (comboBoxPaymentCheck.SelectedIndex == 0)
            {
                textBoxAddNote.Text = DateTime.Now.ToShortDateString();
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            DialogResult resault;
            PrintDialog pd = new PrintDialog();
            pd.Document = printDocument1;
            resault = pd.ShowDialog();
            if (resault == System.Windows.Forms.DialogResult.OK)
            {
                printDocument1.Print();
            }
        }


        private void dateTimePickerTable_ValueChanged(object sender, EventArgs e)
        {
            saved = false;
            _NBPRates = new GetNBPRates(dateTimePickerTable.Value);
            textBoxTable.Text = NBPRates.GetCurrenciesTable("EUR");
            textBoxCurrency.Text = NBPRates.GetCurrenciesRate("EUR");
            RebuildItems();
        }

        private void buttonEditItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nie wybrano żadnego elementu");
            }
            else
            {
                saved = false;
                int index = listView1.FocusedItem.Index;
                Data.ItemInEditing = sInvoice.Items[index];
                new ItemAdd().ShowDialog();
                sInvoice.Items[index] = Data.ItemInEditing;
                RebuildItems();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void InvoiceAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (saved == false)
            {
                DialogResult resault;
                resault = MessageBox.Show("Czy napewno chcesz zamknąć nie zapisaną fakturę?", "Ostrzeżenie", MessageBoxButtons.YesNo);
                if (resault == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void textBoxNr_TextChanged(object sender, EventArgs e)
        {
            saved = false;
        }

        private void textBoxNrYear_TextChanged(object sender, EventArgs e)
        {
            saved = false;

        }

        private void textBoxPlace_TextChanged(object sender, EventArgs e)
        {
            saved = false;
        }

        private void textBoxAddNote_TextChanged(object sender, EventArgs e)
        {
            saved = false;
        }

        private void textBoxSeller1_TextChanged(object sender, EventArgs e)
        {
            saved = false;
        }

        private void textBoxData1_TextChanged(object sender, EventArgs e)
        {
            saved = false;
        }

        private void textBoxData2_TextChanged(object sender, EventArgs e)
        {
            saved = false;
        }

        private void textBoxWarning_TextChanged(object sender, EventArgs e)
        {
            saved = false;
        }

        private void comboBoxCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            saved = false;
            sInvoice.Currency = (ECurrencyItem)comboBoxCurrency.SelectedIndex;
            RebuildItems();
        }

        #endregion
    }
}
