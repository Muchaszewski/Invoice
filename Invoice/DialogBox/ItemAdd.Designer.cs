﻿namespace Faktury.DialogBox
{
    partial class ItemAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxTax = new System.Windows.Forms.TextBox();
            this.labelTax = new System.Windows.Forms.Label();
            this.labelTaxValue = new System.Windows.Forms.Label();
            this.textBoxTaxValue = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelUnit = new System.Windows.Forms.Label();
            this.textBoxPriceTotal = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelValue = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonConfirm.Location = new System.Drawing.Point(318, 202);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 5;
            this.buttonConfirm.Text = "Dodaj";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.BConfirm_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(238, 202);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // TextBoxName
            // 
            this.TextBoxName.AcceptsTab = true;
            this.TextBoxName.AllowDrop = true;
            this.TextBoxName.Location = new System.Drawing.Point(59, 10);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(334, 20);
            this.TextBoxName.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(13, 13);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(40, 13);
            this.labelName.TabIndex = 20;
            this.labelName.Text = "Nazwa";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(247, 17);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(59, 13);
            this.labelPrice.TabIndex = 7;
            this.labelPrice.Text = "Cena netto";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(310, 15);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(66, 20);
            this.textBoxPrice.TabIndex = 1;
            this.textBoxPrice.Text = "0,00";
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxPrice_TextChanged);
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // textBoxTax
            // 
            this.textBoxTax.Location = new System.Drawing.Point(111, 36);
            this.textBoxTax.Name = "textBoxTax";
            this.textBoxTax.Size = new System.Drawing.Size(100, 20);
            this.textBoxTax.TabIndex = 2;
            this.textBoxTax.Text = "23";
            this.textBoxTax.TextChanged += new System.EventHandler(this.textBoxPrice_TextChanged);
            this.textBoxTax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTax_KeyPress);
            // 
            // labelTax
            // 
            this.labelTax.AutoSize = true;
            this.labelTax.Location = new System.Drawing.Point(20, 40);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(85, 13);
            this.labelTax.TabIndex = 7;
            this.labelTax.Text = "Wartość VAT(%)";
            // 
            // labelTaxValue
            // 
            this.labelTaxValue.AutoSize = true;
            this.labelTaxValue.Location = new System.Drawing.Point(245, 40);
            this.labelTaxValue.Name = "labelTaxValue";
            this.labelTaxValue.Size = new System.Drawing.Size(61, 13);
            this.labelTaxValue.TabIndex = 8;
            this.labelTaxValue.Text = "Kwota VAT";
            // 
            // textBoxTaxValue
            // 
            this.textBoxTaxValue.Location = new System.Drawing.Point(310, 36);
            this.textBoxTaxValue.Name = "textBoxTaxValue";
            this.textBoxTaxValue.ReadOnly = true;
            this.textBoxTaxValue.Size = new System.Drawing.Size(66, 20);
            this.textBoxTaxValue.TabIndex = 9;
            this.textBoxTaxValue.TabStop = false;
            this.textBoxTaxValue.Text = "0,00";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelUnit);
            this.groupBox1.Controls.Add(this.textBoxPriceTotal);
            this.groupBox1.Controls.Add(this.comboBoxType);
            this.groupBox1.Controls.Add(this.labelValue);
            this.groupBox1.Controls.Add(this.labelTax);
            this.groupBox1.Controls.Add(this.textBoxTaxValue);
            this.groupBox1.Controls.Add(this.labelPrice);
            this.groupBox1.Controls.Add(this.labelTaxValue);
            this.groupBox1.Controls.Add(this.textBoxPrice);
            this.groupBox1.Controls.Add(this.textBoxTax);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 101);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cena produktu";
            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.labelUnit.Location = new System.Drawing.Point(22, 72);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(83, 13);
            this.labelUnit.TabIndex = 12;
            this.labelUnit.Text = "Jednostka miary";
            // 
            // textBoxPriceTotal
            // 
            this.textBoxPriceTotal.Location = new System.Drawing.Point(244, 69);
            this.textBoxPriceTotal.Name = "textBoxPriceTotal";
            this.textBoxPriceTotal.ReadOnly = true;
            this.textBoxPriceTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxPriceTotal.TabIndex = 11;
            this.textBoxPriceTotal.TabStop = false;
            this.textBoxPriceTotal.Text = "0,00";
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "szt.",
            "kg.",
            "op.",
            "cm2",
            "m2",
            "litr",
            "m3",
            "min",
            "godz",
            "mc",
            "metr",
            "km"});
            this.comboBoxType.Location = new System.Drawing.Point(111, 69);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(58, 21);
            this.comboBoxType.TabIndex = 3;
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(176, 72);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(62, 13);
            this.labelValue.TabIndex = 10;
            this.labelValue.Text = "Cena brutto";
            // 
            // ItemAdd
            // 
            this.AcceptButton = this.buttonConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(405, 231);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonConfirm);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemAdd";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodaj przedmiot";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxTax;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.Label labelTaxValue;
        private System.Windows.Forms.TextBox textBoxTaxValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxPriceTotal;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelUnit;
    }
}