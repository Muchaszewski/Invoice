namespace Faktury.DialogBox
{
    partial class ContractorAdd
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
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.groupBoxAdress = new System.Windows.Forms.GroupBox();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.labelState = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPostCode2 = new System.Windows.Forms.TextBox();
            this.textBoxPostCode1 = new System.Windows.Forms.TextBox();
            this.labelPostalCode = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.labelCountry = new System.Windows.Forms.Label();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.labelStreet = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelNIP = new System.Windows.Forms.Label();
            this.textBoxNIP = new System.Windows.Forms.TextBox();
            this.labelBankNumber = new System.Windows.Forms.Label();
            this.textBoxBank = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelBankName = new System.Windows.Forms.Label();
            this.textBoxBancAccName = new System.Windows.Forms.TextBox();
            this.textBoxCompany = new System.Windows.Forms.TextBox();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.labelRegon = new System.Windows.Forms.Label();
            this.textBoxREGON = new System.Windows.Forms.TextBox();
            this.buttonValidate = new System.Windows.Forms.Button();
            this.groupBoxAdress.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(7, 35);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(78, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Imię i nazwisko";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(91, 32);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(294, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sprzedawca",
            "Nabywca",
            "Wystawca",
            "Odbiorca"});
            this.comboBox1.Location = new System.Drawing.Point(47, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(12, 61);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(25, 13);
            this.labelType.TabIndex = 3;
            this.labelType.Text = "Typ";
            // 
            // groupBoxAdress
            // 
            this.groupBoxAdress.Controls.Add(this.comboBoxState);
            this.groupBoxAdress.Controls.Add(this.labelState);
            this.groupBoxAdress.Controls.Add(this.label1);
            this.groupBoxAdress.Controls.Add(this.textBoxPostCode2);
            this.groupBoxAdress.Controls.Add(this.textBoxPostCode1);
            this.groupBoxAdress.Controls.Add(this.labelPostalCode);
            this.groupBoxAdress.Controls.Add(this.textBox4);
            this.groupBoxAdress.Controls.Add(this.labelCountry);
            this.groupBoxAdress.Controls.Add(this.textBoxStreet);
            this.groupBoxAdress.Controls.Add(this.labelStreet);
            this.groupBoxAdress.Controls.Add(this.textBoxCity);
            this.groupBoxAdress.Controls.Add(this.labelCity);
            this.groupBoxAdress.Location = new System.Drawing.Point(6, 162);
            this.groupBoxAdress.Name = "groupBoxAdress";
            this.groupBoxAdress.Size = new System.Drawing.Size(387, 99);
            this.groupBoxAdress.TabIndex = 4;
            this.groupBoxAdress.TabStop = false;
            this.groupBoxAdress.Text = "Adres";
            // 
            // comboBoxState
            // 
            this.comboBoxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Items.AddRange(new object[] {
            "dolnośląskie",
            "kujawsko-pomorskie",
            "łódzkie",
            "lubelskie",
            "lubuskie",
            "małopolskie",
            "mazowieckie",
            "opolskie",
            "podkarpackie",
            "podlaskie",
            "pomorskie",
            "śląskie",
            "świętokrzyskie",
            "warmińsko-mazurskie",
            "wielkopolskie",
            "zachodniopomorskie"});
            this.comboBoxState.Location = new System.Drawing.Point(247, 17);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(132, 21);
            this.comboBoxState.TabIndex = 7;
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(168, 20);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(74, 13);
            this.labelState.TabIndex = 10;
            this.labelState.Text = "Województwo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(342, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "-";
            // 
            // textBoxPostCode2
            // 
            this.textBoxPostCode2.Location = new System.Drawing.Point(353, 43);
            this.textBoxPostCode2.MaxLength = 3;
            this.textBoxPostCode2.Name = "textBoxPostCode2";
            this.textBoxPostCode2.Size = new System.Drawing.Size(26, 20);
            this.textBoxPostCode2.TabIndex = 10;
            // 
            // textBoxPostCode1
            // 
            this.textBoxPostCode1.Location = new System.Drawing.Point(322, 43);
            this.textBoxPostCode1.MaxLength = 2;
            this.textBoxPostCode1.Name = "textBoxPostCode1";
            this.textBoxPostCode1.Size = new System.Drawing.Size(19, 20);
            this.textBoxPostCode1.TabIndex = 9;
            this.textBoxPostCode1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPostCode1_KeyDown);
            this.textBoxPostCode1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPostCode1_KeyPress);
            // 
            // labelPostalCode
            // 
            this.labelPostalCode.AutoSize = true;
            this.labelPostalCode.Location = new System.Drawing.Point(246, 46);
            this.labelPostalCode.Name = "labelPostalCode";
            this.labelPostalCode.Size = new System.Drawing.Size(75, 13);
            this.labelPostalCode.TabIndex = 6;
            this.labelPostalCode.Text = "Kod Pocztowy";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(50, 17);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(112, 20);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "Polska";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(16, 20);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(25, 13);
            this.labelCountry.TabIndex = 4;
            this.labelCountry.Text = "Kraj";
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(53, 70);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(326, 20);
            this.textBoxStreet.TabIndex = 11;
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new System.Drawing.Point(16, 73);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(31, 13);
            this.labelStreet.TabIndex = 2;
            this.labelStreet.Text = "Ulica";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(90, 43);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(153, 20);
            this.textBoxCity.TabIndex = 8;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(16, 46);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(68, 13);
            this.labelCity.TabIndex = 0;
            this.labelCity.Text = "Miejscowość";
            // 
            // labelNIP
            // 
            this.labelNIP.AutoSize = true;
            this.labelNIP.Location = new System.Drawing.Point(12, 88);
            this.labelNIP.Name = "labelNIP";
            this.labelNIP.Size = new System.Drawing.Size(25, 13);
            this.labelNIP.TabIndex = 8;
            this.labelNIP.Text = "NIP";
            // 
            // textBoxNIP
            // 
            this.textBoxNIP.Location = new System.Drawing.Point(47, 85);
            this.textBoxNIP.Name = "textBoxNIP";
            this.textBoxNIP.Size = new System.Drawing.Size(87, 20);
            this.textBoxNIP.TabIndex = 3;
            // 
            // labelBankNumber
            // 
            this.labelBankNumber.AutoSize = true;
            this.labelBankNumber.Location = new System.Drawing.Point(9, 139);
            this.labelBankNumber.Name = "labelBankNumber";
            this.labelBankNumber.Size = new System.Drawing.Size(139, 13);
            this.labelBankNumber.TabIndex = 10;
            this.labelBankNumber.Text = "Numer rachunku bakowego";
            // 
            // textBoxBank
            // 
            this.textBoxBank.Location = new System.Drawing.Point(154, 136);
            this.textBoxBank.Name = "textBoxBank";
            this.textBoxBank.Size = new System.Drawing.Size(233, 20);
            this.textBoxBank.TabIndex = 6;
            // 
            // buttonAdd
            // 
            this.buttonAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAdd.Location = new System.Drawing.Point(310, 267);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(229, 267);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 14;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelBankName
            // 
            this.labelBankName.AutoSize = true;
            this.labelBankName.Location = new System.Drawing.Point(16, 113);
            this.labelBankName.Name = "labelBankName";
            this.labelBankName.Size = new System.Drawing.Size(129, 13);
            this.labelBankName.TabIndex = 15;
            this.labelBankName.Text = "Nazwa konta bankowego";
            // 
            // textBoxBancAccName
            // 
            this.textBoxBancAccName.Location = new System.Drawing.Point(154, 110);
            this.textBoxBancAccName.Name = "textBoxBancAccName";
            this.textBoxBancAccName.Size = new System.Drawing.Size(231, 20);
            this.textBoxBancAccName.TabIndex = 5;
            // 
            // textBoxCompany
            // 
            this.textBoxCompany.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCompany.Location = new System.Drawing.Point(91, 6);
            this.textBoxCompany.Name = "textBoxCompany";
            this.textBoxCompany.Size = new System.Drawing.Size(296, 20);
            this.textBoxCompany.TabIndex = 0;
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Location = new System.Drawing.Point(12, 9);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(64, 13);
            this.labelCompanyName.TabIndex = 18;
            this.labelCompanyName.Text = "Nazwa firmy";
            // 
            // labelRegon
            // 
            this.labelRegon.AutoSize = true;
            this.labelRegon.Location = new System.Drawing.Point(152, 88);
            this.labelRegon.Name = "labelRegon";
            this.labelRegon.Size = new System.Drawing.Size(39, 13);
            this.labelRegon.TabIndex = 19;
            this.labelRegon.Text = "Regon";
            // 
            // textBoxREGON
            // 
            this.textBoxREGON.Location = new System.Drawing.Point(197, 85);
            this.textBoxREGON.Name = "textBoxREGON";
            this.textBoxREGON.Size = new System.Drawing.Size(100, 20);
            this.textBoxREGON.TabIndex = 4;
            // 
            // buttonValidate
            // 
            this.buttonValidate.Location = new System.Drawing.Point(10, 267);
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.Size = new System.Drawing.Size(97, 23);
            this.buttonValidate.TabIndex = 20;
            this.buttonValidate.Text = "Sprawdź dane";
            this.buttonValidate.UseVisualStyleBackColor = true;
            this.buttonValidate.Click += new System.EventHandler(this.buttonValidate_Click);
            // 
            // ContractorAdd
            // 
            this.AcceptButton = this.buttonAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(399, 296);
            this.ControlBox = false;
            this.Controls.Add(this.buttonValidate);
            this.Controls.Add(this.textBoxREGON);
            this.Controls.Add(this.labelRegon);
            this.Controls.Add(this.labelCompanyName);
            this.Controls.Add(this.textBoxCompany);
            this.Controls.Add(this.textBoxBancAccName);
            this.Controls.Add(this.labelBankName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxBank);
            this.Controls.Add(this.labelBankNumber);
            this.Controls.Add(this.textBoxNIP);
            this.Controls.Add(this.labelNIP);
            this.Controls.Add(this.groupBoxAdress);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContractorAdd";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ContractorAdd";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ContractorAdd_FormClosing);
            this.groupBoxAdress.ResumeLayout(false);
            this.groupBoxAdress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.GroupBox groupBoxAdress;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPostCode2;
        private System.Windows.Forms.TextBox textBoxPostCode1;
        private System.Windows.Forms.Label labelPostalCode;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelNIP;
        private System.Windows.Forms.TextBox textBoxNIP;
        private System.Windows.Forms.Label labelBankNumber;
        private System.Windows.Forms.TextBox textBoxBank;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelBankName;
        private System.Windows.Forms.TextBox textBoxBancAccName;
        private System.Windows.Forms.TextBox textBoxCompany;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Label labelRegon;
        private System.Windows.Forms.TextBox textBoxREGON;
        private System.Windows.Forms.Button buttonValidate;
    }
}