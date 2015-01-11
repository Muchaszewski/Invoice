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
    public partial class ContractorAdd : Form
    {
        bool edit = false;
        bool toContinue;
        int index;

        public ContractorAdd()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBoxState.SelectedIndex = 0;
        }

        public ContractorAdd(int index)
        {
            InitializeComponent();
            Contractor item = Data.Contractors[index];
            textBoxName.Text = item.Name;
            textBoxCompany.Text = item.CompanyName;
            comboBox1.SelectedIndex = (int)item.Type;
            textBoxNIP.Text = item.NIP;
            textBoxREGON.Text = item.REGON;
            textBoxBancAccName.Text = item.BankAccName;
            textBoxBank.Text = item.BankAcc;
            comboBoxState.SelectedIndex = comboBoxState.FindString(item.Province);
            textBoxCity.Text = item.City;
            textBoxStreet.Text = item.Street;
            textBoxPostCode1.Text = item.PostCode[0] + "" + item.PostCode[1];
            textBoxPostCode2.Text = item.PostCode[3] + "" + item.PostCode[4] + "" + item.PostCode[5];
            this.index = index;
            edit = true;
            buttonAdd.Text = "Edytuj";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            toContinue = true;
            this.Close();
        }

        private void items(Contractor item)
        {
            item.Name = textBoxName.Text;
            item.CompanyName = textBoxCompany.Text;
            item.Type = (EContractorType)comboBox1.SelectedIndex;
            item.NIP = textBoxNIP.Text;
            item.REGON = textBoxREGON.Text;
            item.BankAcc = textBoxBank.Text;
            item.BankAccName = textBoxBancAccName.Text;
            item.Province = comboBoxState.SelectedText;
            item.City = textBoxCity.Text;
            item.Street = textBoxStreet.Text;
            item.PostCode = textBoxPostCode1.Text + "-" + textBoxPostCode2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            toContinue = true;
            if (!checkValidation())
            {
                DialogResult dr = MessageBox.Show("Formularz zawiera nie błędy!\r\nCzy chcesz kontynułować?", "Uwaga!", MessageBoxButtons.YesNo);
                if (dr == System.Windows.Forms.DialogResult.No)
                {
                    toContinue = false;
                }
            }
            if (toContinue == true)
            {
                if (edit == false)
                {
                    Contractor item = new Contractor();
                    items(item);
                    Data.Contractors.Add(item);
                    Data.SaveContractor();
                }
                else
                {
                    Contractor item = Data.Contractors[index];
                    items(item);
                    Data.SaveContractor();
                }
                this.Close();
            }
        }

        private bool checkValidation()
        {
            Color warning = Color.MistyRose;
            bool toReturn = true;
            if (textBoxName.Text.Length == 0)
            {
                textBoxName.BackColor = warning;
                toReturn = false;
            }
            else
            {
                this.textBoxName.BackColor = System.Drawing.SystemColors.Window;
            }
            if (textBoxCompany.Text.Length == 0)
            {
                textBoxCompany.BackColor = warning;
                toReturn = false;
            }
            else
            {
                this.textBoxCompany.BackColor = System.Drawing.SystemColors.Window;
            }

            if (!Utils.Validate.NIP(textBoxNIP.Text))
            {
                textBoxNIP.BackColor = warning;
                toReturn = false;
            }
            else
            {
                textBoxNIP.BackColor = System.Drawing.SystemColors.Window;
            }

            //if (!Utils.Validate.Regon(textBoxREGON.Text))
            //{
            //    textBoxREGON.BackColor = warning;
            //    toReturn = false;
            //}
            //else
            //{
            //    textBoxNIP.BackColor = System.Drawing.SystemColors.Window;
            //}

            if (textBoxCity.Text.Length == 0)
            {
                textBoxCity.BackColor = warning;
                toReturn = false;
            }
            else
            {
                textBoxCity.BackColor = System.Drawing.SystemColors.Window;
            }

            if (textBoxStreet.Text.Length == 0)
            {
                textBoxStreet.BackColor = warning;
                toReturn = false;
            }
            else
            {
                textBoxStreet.BackColor = System.Drawing.SystemColors.Window;
            }
            int n;
            if (textBoxPostCode1.Text.Length == 2 && int.TryParse(textBoxPostCode1.Text, out n))
            {
                textBoxPostCode1.BackColor = System.Drawing.SystemColors.Window;
            }
            else
            {
                textBoxPostCode1.BackColor = warning;
                toReturn = false;
            }

            if (textBoxPostCode2.Text.Length == 3 && int.TryParse(textBoxPostCode2.Text, out n))
            {
                textBoxPostCode2.BackColor = System.Drawing.SystemColors.Window;
            }
            else
            {
                textBoxPostCode2.BackColor = warning;
                toReturn = false;
            }

            //if (textBoxBancAccName.Text.Length != 0)
            //{
            //    textBoxBancAccName.BackColor = System.Drawing.SystemColors.Window;
            //}
            //else
            //{
            //    textBoxBancAccName.BackColor = warning;
            //    toReturn = false;
            //}

            //if (textBoxBank.Text.Length == 0)
            //{
            //    textBoxBank.BackColor = warning;
            //    toReturn = false;
            //}
            //else
            //{
            //    textBoxBank.BackColor = System.Drawing.SystemColors.Window;
            //}

            return toReturn;
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            checkValidation();
        }

        private void textBoxPostCode1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void textBoxPostCode1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.OemMinus)
            {
                this.ProcessTabKey(true);
            }
        }

        private void ContractorAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(toContinue == false)
            {
                e.Cancel = true;
            }
        }
    }
}
