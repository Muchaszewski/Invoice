namespace Faktury.DialogBox
{
    partial class InvoiceAdd
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
            this.textBoxSeller1 = new System.Windows.Forms.TextBox();
            this.textBoxData1 = new System.Windows.Forms.TextBox();
            this.textBoxData2 = new System.Windows.Forms.TextBox();
            this.textBoxSeller2 = new System.Windows.Forms.TextBox();
            this.groupBoxContractors = new System.Windows.Forms.GroupBox();
            this.buttonChooseSeller = new System.Windows.Forms.Button();
            this.buttonChooseBuyer = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontrahentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produktUsługęToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewItems = new System.Windows.Forms.ListView();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTaxPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTaxValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDeleteItem = new System.Windows.Forms.Button();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.textBoxTaxValue1 = new System.Windows.Forms.TextBox();
            this.labelTotalValue = new System.Windows.Forms.Label();
            this.textBoxTax1 = new System.Windows.Forms.TextBox();
            this.labelTax = new System.Windows.Forms.Label();
            this.textBoxTable = new System.Windows.Forms.TextBox();
            this.textBoxCurrency = new System.Windows.Forms.TextBox();
            this.labelCurrencyPrice = new System.Windows.Forms.Label();
            this.labelMakingDate = new System.Windows.Forms.Label();
            this.dateTimePickerMaking = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerSelling = new System.Windows.Forms.DateTimePicker();
            this.labelSellingDate = new System.Windows.Forms.Label();
            this.labelSellingPlace = new System.Windows.Forms.Label();
            this.textBoxPlace = new System.Windows.Forms.TextBox();
            this.labelPayment = new System.Windows.Forms.Label();
            this.comboBoxPaymentCheck = new System.Windows.Forms.ComboBox();
            this.labelPaymentDate = new System.Windows.Forms.Label();
            this.labelInvoiceNumber = new System.Windows.Forms.Label();
            this.textBoxNr = new System.Windows.Forms.TextBox();
            this.labelNameSlash1 = new System.Windows.Forms.Label();
            this.textBoxNrYear = new System.Windows.Forms.TextBox();
            this.groupBoxDates = new System.Windows.Forms.GroupBox();
            this.textBoxAddNote = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.labelDefaultTax = new System.Windows.Forms.Label();
            this.textBoxTaxDefault = new System.Windows.Forms.TextBox();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.textBoxValue1 = new System.Windows.Forms.TextBox();
            this.labelDefaultPriceCopy = new System.Windows.Forms.Label();
            this.textBoxValueDefault = new System.Windows.Forms.TextBox();
            this.textBoxTaxValueDefault = new System.Windows.Forms.TextBox();
            this.groupBoxSummary = new System.Windows.Forms.GroupBox();
            this.dateTimePickerTable = new System.Windows.Forms.DateTimePicker();
            this.labelDateCurrency = new System.Windows.Forms.Label();
            this.textBoxNumberToWord = new System.Windows.Forms.TextBox();
            this.labelPriceToText = new System.Windows.Forms.Label();
            this.buttonPreview = new System.Windows.Forms.Button();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.textBoxWarning = new System.Windows.Forms.TextBox();
            this.groupBoxWarning = new System.Windows.Forms.GroupBox();
            this.checkBoxWarning = new System.Windows.Forms.CheckBox();
            this.buttonEditItem = new System.Windows.Forms.Button();
            this.labelCurrency = new System.Windows.Forms.Label();
            this.comboBoxCurrency = new System.Windows.Forms.ComboBox();
            this.groupBoxContractors.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.groupBoxDates.SuspendLayout();
            this.groupBoxSummary.SuspendLayout();
            this.groupBoxWarning.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSeller1
            // 
            this.textBoxSeller1.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxSeller1.Location = new System.Drawing.Point(6, 16);
            this.textBoxSeller1.Name = "textBoxSeller1";
            this.textBoxSeller1.ReadOnly = true;
            this.textBoxSeller1.Size = new System.Drawing.Size(100, 20);
            this.textBoxSeller1.TabIndex = 0;
            // 
            // textBoxData1
            // 
            this.textBoxData1.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxData1.Location = new System.Drawing.Point(6, 45);
            this.textBoxData1.Multiline = true;
            this.textBoxData1.Name = "textBoxData1";
            this.textBoxData1.ReadOnly = true;
            this.textBoxData1.Size = new System.Drawing.Size(350, 114);
            this.textBoxData1.TabIndex = 1;
            this.textBoxData1.TextChanged += new System.EventHandler(this.textBoxData1_TextChanged);
            // 
            // textBoxData2
            // 
            this.textBoxData2.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxData2.Location = new System.Drawing.Point(551, 45);
            this.textBoxData2.Multiline = true;
            this.textBoxData2.Name = "textBoxData2";
            this.textBoxData2.ReadOnly = true;
            this.textBoxData2.Size = new System.Drawing.Size(336, 114);
            this.textBoxData2.TabIndex = 3;
            this.textBoxData2.TextChanged += new System.EventHandler(this.textBoxData2_TextChanged);
            // 
            // textBoxSeller2
            // 
            this.textBoxSeller2.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxSeller2.Location = new System.Drawing.Point(551, 16);
            this.textBoxSeller2.Name = "textBoxSeller2";
            this.textBoxSeller2.ReadOnly = true;
            this.textBoxSeller2.Size = new System.Drawing.Size(132, 20);
            this.textBoxSeller2.TabIndex = 2;
            // 
            // groupBoxContractors
            // 
            this.groupBoxContractors.Controls.Add(this.buttonChooseSeller);
            this.groupBoxContractors.Controls.Add(this.buttonChooseBuyer);
            this.groupBoxContractors.Controls.Add(this.textBoxSeller1);
            this.groupBoxContractors.Controls.Add(this.textBoxData2);
            this.groupBoxContractors.Controls.Add(this.textBoxData1);
            this.groupBoxContractors.Controls.Add(this.textBoxSeller2);
            this.groupBoxContractors.Location = new System.Drawing.Point(10, 132);
            this.groupBoxContractors.Name = "groupBoxContractors";
            this.groupBoxContractors.Size = new System.Drawing.Size(893, 165);
            this.groupBoxContractors.TabIndex = 4;
            this.groupBoxContractors.TabStop = false;
            // 
            // buttonChooseSeller
            // 
            this.buttonChooseSeller.Location = new System.Drawing.Point(241, 14);
            this.buttonChooseSeller.Name = "buttonChooseSeller";
            this.buttonChooseSeller.Size = new System.Drawing.Size(115, 23);
            this.buttonChooseSeller.TabIndex = 6;
            this.buttonChooseSeller.Text = "Wybierz Kontrahenta";
            this.buttonChooseSeller.UseVisualStyleBackColor = true;
            this.buttonChooseSeller.Click += new System.EventHandler(this.buttonChoose1_Click);
            // 
            // buttonChooseBuyer
            // 
            this.buttonChooseBuyer.Location = new System.Drawing.Point(772, 13);
            this.buttonChooseBuyer.Name = "buttonChooseBuyer";
            this.buttonChooseBuyer.Size = new System.Drawing.Size(115, 23);
            this.buttonChooseBuyer.TabIndex = 5;
            this.buttonChooseBuyer.Text = "Wybierz Kontrahenta";
            this.buttonChooseBuyer.UseVisualStyleBackColor = true;
            this.buttonChooseBuyer.Click += new System.EventHandler(this.buttonChoose2_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(906, 24);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip1";
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kontrahentaToolStripMenuItem,
            this.produktUsługęToolStripMenuItem});
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.dodajToolStripMenuItem.Text = "Dodaj";
            // 
            // kontrahentaToolStripMenuItem
            // 
            this.kontrahentaToolStripMenuItem.Name = "kontrahentaToolStripMenuItem";
            this.kontrahentaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.kontrahentaToolStripMenuItem.Text = "Kontrahenta";
            // 
            // produktUsługęToolStripMenuItem
            // 
            this.produktUsługęToolStripMenuItem.Name = "produktUsługęToolStripMenuItem";
            this.produktUsługęToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.produktUsługęToolStripMenuItem.Text = "Produkt/Usługę";
            // 
            // listViewItems
            // 
            this.listViewItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderName,
            this.columnHeaderCount,
            this.columnHeaderUnit,
            this.columnHeaderPrice,
            this.columnHeaderTax,
            this.columnHeaderTaxPrice,
            this.columnHeaderTaxValue,
            this.columnHeaderValue});
            this.listViewItems.FullRowSelect = true;
            this.listViewItems.HideSelection = false;
            this.listViewItems.Location = new System.Drawing.Point(10, 303);
            this.listViewItems.MultiSelect = false;
            this.listViewItems.Name = "listViewItems";
            this.listViewItems.Size = new System.Drawing.Size(806, 267);
            this.listViewItems.TabIndex = 9;
            this.listViewItems.UseCompatibleStateImageBehavior = false;
            this.listViewItems.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "Lp";
            this.columnHeaderId.Width = 25;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Nazwa";
            this.columnHeaderName.Width = 280;
            // 
            // columnHeaderCount
            // 
            this.columnHeaderCount.Text = "Ilość";
            this.columnHeaderCount.Width = 40;
            // 
            // columnHeaderUnit
            // 
            this.columnHeaderUnit.Text = "J.m";
            this.columnHeaderUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderUnit.Width = 32;
            // 
            // columnHeaderPrice
            // 
            this.columnHeaderPrice.Text = "Cena Netto";
            this.columnHeaderPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderPrice.Width = 67;
            // 
            // columnHeaderTax
            // 
            this.columnHeaderTax.Text = "Stawka VAT(%)";
            this.columnHeaderTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderTax.Width = 93;
            // 
            // columnHeaderTaxPrice
            // 
            this.columnHeaderTaxPrice.Text = "Cena Brutto";
            this.columnHeaderTaxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderTaxPrice.Width = 69;
            // 
            // columnHeaderTaxValue
            // 
            this.columnHeaderTaxValue.Text = "Wartość Netto";
            this.columnHeaderTaxValue.Width = 90;
            // 
            // columnHeaderValue
            // 
            this.columnHeaderValue.Text = "Wartość Brutto";
            this.columnHeaderValue.Width = 90;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(822, 332);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 51);
            this.buttonEdit.TabIndex = 10;
            this.buttonEdit.Text = "Edytuj ilość";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDeleteItem
            // 
            this.buttonDeleteItem.Location = new System.Drawing.Point(822, 547);
            this.buttonDeleteItem.Name = "buttonDeleteItem";
            this.buttonDeleteItem.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteItem.TabIndex = 8;
            this.buttonDeleteItem.Text = "Usuń";
            this.buttonDeleteItem.UseVisualStyleBackColor = true;
            this.buttonDeleteItem.Click += new System.EventHandler(this.BDeleteItem_Click);
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Location = new System.Drawing.Point(822, 303);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(75, 24);
            this.buttonAddItem.TabIndex = 7;
            this.buttonAddItem.Text = "Dodaj";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Click += new System.EventHandler(this.BAddItem_Click);
            // 
            // textBoxTaxValue1
            // 
            this.textBoxTaxValue1.Location = new System.Drawing.Point(333, 45);
            this.textBoxTaxValue1.Name = "textBoxTaxValue1";
            this.textBoxTaxValue1.ReadOnly = true;
            this.textBoxTaxValue1.Size = new System.Drawing.Size(82, 20);
            this.textBoxTaxValue1.TabIndex = 11;
            this.textBoxTaxValue1.Text = "0,00";
            // 
            // labelTotalValue
            // 
            this.labelTotalValue.AutoSize = true;
            this.labelTotalValue.Location = new System.Drawing.Point(244, 48);
            this.labelTotalValue.Name = "labelTotalValue";
            this.labelTotalValue.Size = new System.Drawing.Size(83, 13);
            this.labelTotalValue.TabIndex = 12;
            this.labelTotalValue.Text = "Łączna wartość";
            // 
            // textBoxTax1
            // 
            this.textBoxTax1.Location = new System.Drawing.Point(89, 16);
            this.textBoxTax1.Name = "textBoxTax1";
            this.textBoxTax1.ReadOnly = true;
            this.textBoxTax1.Size = new System.Drawing.Size(76, 20);
            this.textBoxTax1.TabIndex = 13;
            this.textBoxTax1.Text = "0,00";
            // 
            // labelTax
            // 
            this.labelTax.AutoSize = true;
            this.labelTax.Location = new System.Drawing.Point(12, 19);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(71, 13);
            this.labelTax.TabIndex = 14;
            this.labelTax.Text = "Wartość VAT";
            // 
            // textBoxTable
            // 
            this.textBoxTable.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTable.Location = new System.Drawing.Point(10, 106);
            this.textBoxTable.Name = "textBoxTable";
            this.textBoxTable.ReadOnly = true;
            this.textBoxTable.Size = new System.Drawing.Size(317, 20);
            this.textBoxTable.TabIndex = 15;
            // 
            // textBoxCurrency
            // 
            this.textBoxCurrency.Location = new System.Drawing.Point(84, 81);
            this.textBoxCurrency.Name = "textBoxCurrency";
            this.textBoxCurrency.ReadOnly = true;
            this.textBoxCurrency.Size = new System.Drawing.Size(76, 20);
            this.textBoxCurrency.TabIndex = 16;
            this.textBoxCurrency.Text = "0,00";
            // 
            // labelCurrencyPrice
            // 
            this.labelCurrencyPrice.AutoSize = true;
            this.labelCurrencyPrice.Location = new System.Drawing.Point(12, 84);
            this.labelCurrencyPrice.Name = "labelCurrencyPrice";
            this.labelCurrencyPrice.Size = new System.Drawing.Size(66, 13);
            this.labelCurrencyPrice.TabIndex = 17;
            this.labelCurrencyPrice.Text = "Kurs zł/euro";
            // 
            // labelMakingDate
            // 
            this.labelMakingDate.AutoSize = true;
            this.labelMakingDate.Location = new System.Drawing.Point(37, 16);
            this.labelMakingDate.Name = "labelMakingDate";
            this.labelMakingDate.Size = new System.Drawing.Size(90, 13);
            this.labelMakingDate.TabIndex = 18;
            this.labelMakingDate.Text = "Data wystawienia";
            // 
            // dateTimePickerMaking
            // 
            this.dateTimePickerMaking.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerMaking.Location = new System.Drawing.Point(31, 32);
            this.dateTimePickerMaking.Name = "dateTimePickerMaking";
            this.dateTimePickerMaking.Size = new System.Drawing.Size(111, 20);
            this.dateTimePickerMaking.TabIndex = 19;
            this.dateTimePickerMaking.ValueChanged += new System.EventHandler(this.dateTimePickerMaking_ValueChanged);
            // 
            // dateTimePickerSelling
            // 
            this.dateTimePickerSelling.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSelling.Location = new System.Drawing.Point(177, 32);
            this.dateTimePickerSelling.Name = "dateTimePickerSelling";
            this.dateTimePickerSelling.Size = new System.Drawing.Size(111, 20);
            this.dateTimePickerSelling.TabIndex = 21;
            this.dateTimePickerSelling.ValueChanged += new System.EventHandler(this.dateTimePickerMaking_ValueChanged);
            // 
            // labelSellingDate
            // 
            this.labelSellingDate.AutoSize = true;
            this.labelSellingDate.Location = new System.Drawing.Point(192, 16);
            this.labelSellingDate.Name = "labelSellingDate";
            this.labelSellingDate.Size = new System.Drawing.Size(80, 13);
            this.labelSellingDate.TabIndex = 20;
            this.labelSellingDate.Text = "Data sprzedaży";
            // 
            // labelSellingPlace
            // 
            this.labelSellingPlace.AutoSize = true;
            this.labelSellingPlace.Location = new System.Drawing.Point(336, 16);
            this.labelSellingPlace.Name = "labelSellingPlace";
            this.labelSellingPlace.Size = new System.Drawing.Size(103, 13);
            this.labelSellingPlace.TabIndex = 22;
            this.labelSellingPlace.Text = "Miejsce wystawienia";
            // 
            // textBoxPlace
            // 
            this.textBoxPlace.Location = new System.Drawing.Point(324, 31);
            this.textBoxPlace.Name = "textBoxPlace";
            this.textBoxPlace.Size = new System.Drawing.Size(144, 20);
            this.textBoxPlace.TabIndex = 23;
            this.textBoxPlace.TextChanged += new System.EventHandler(this.textBoxPlace_TextChanged);
            // 
            // labelPayment
            // 
            this.labelPayment.AutoSize = true;
            this.labelPayment.Location = new System.Drawing.Point(518, 16);
            this.labelPayment.Name = "labelPayment";
            this.labelPayment.Size = new System.Drawing.Size(83, 13);
            this.labelPayment.TabIndex = 25;
            this.labelPayment.Text = "Forma płatności";
            // 
            // comboBoxPaymentCheck
            // 
            this.comboBoxPaymentCheck.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPaymentCheck.FormattingEnabled = true;
            this.comboBoxPaymentCheck.Items.AddRange(new object[] {
            "gotówką",
            "przelewem"});
            this.comboBoxPaymentCheck.Location = new System.Drawing.Point(502, 30);
            this.comboBoxPaymentCheck.Name = "comboBoxPaymentCheck";
            this.comboBoxPaymentCheck.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPaymentCheck.TabIndex = 26;
            this.comboBoxPaymentCheck.SelectedIndexChanged += new System.EventHandler(this.comboBoxPaymentCheck_SelectedIndexChanged);
            // 
            // labelPaymentDate
            // 
            this.labelPaymentDate.AutoSize = true;
            this.labelPaymentDate.Location = new System.Drawing.Point(720, 16);
            this.labelPaymentDate.Name = "labelPaymentDate";
            this.labelPaymentDate.Size = new System.Drawing.Size(86, 13);
            this.labelPaymentDate.TabIndex = 27;
            this.labelPaymentDate.Text = "Termin płatności";
            // 
            // labelInvoiceNumber
            // 
            this.labelInvoiceNumber.AutoSize = true;
            this.labelInvoiceNumber.Location = new System.Drawing.Point(12, 33);
            this.labelInvoiceNumber.Name = "labelInvoiceNumber";
            this.labelInvoiceNumber.Size = new System.Drawing.Size(55, 13);
            this.labelInvoiceNumber.TabIndex = 29;
            this.labelInvoiceNumber.Text = "Faktura nr";
            // 
            // textBoxNr
            // 
            this.textBoxNr.Location = new System.Drawing.Point(73, 30);
            this.textBoxNr.Name = "textBoxNr";
            this.textBoxNr.Size = new System.Drawing.Size(55, 20);
            this.textBoxNr.TabIndex = 30;
            this.textBoxNr.Text = "Nr";
            this.textBoxNr.TextChanged += new System.EventHandler(this.textBoxNr_TextChanged);
            // 
            // labelNameSlash1
            // 
            this.labelNameSlash1.AutoSize = true;
            this.labelNameSlash1.Location = new System.Drawing.Point(135, 33);
            this.labelNameSlash1.Name = "labelNameSlash1";
            this.labelNameSlash1.Size = new System.Drawing.Size(12, 13);
            this.labelNameSlash1.TabIndex = 31;
            this.labelNameSlash1.Text = "/";
            // 
            // textBoxNrYear
            // 
            this.textBoxNrYear.Location = new System.Drawing.Point(153, 30);
            this.textBoxNrYear.Name = "textBoxNrYear";
            this.textBoxNrYear.Size = new System.Drawing.Size(55, 20);
            this.textBoxNrYear.TabIndex = 32;
            this.textBoxNrYear.Text = "Year";
            this.textBoxNrYear.TextChanged += new System.EventHandler(this.textBoxNrYear_TextChanged);
            // 
            // groupBoxDates
            // 
            this.groupBoxDates.Controls.Add(this.textBoxAddNote);
            this.groupBoxDates.Controls.Add(this.labelMakingDate);
            this.groupBoxDates.Controls.Add(this.dateTimePickerMaking);
            this.groupBoxDates.Controls.Add(this.labelSellingDate);
            this.groupBoxDates.Controls.Add(this.dateTimePickerSelling);
            this.groupBoxDates.Controls.Add(this.labelSellingPlace);
            this.groupBoxDates.Controls.Add(this.textBoxPlace);
            this.groupBoxDates.Controls.Add(this.labelPaymentDate);
            this.groupBoxDates.Controls.Add(this.labelPayment);
            this.groupBoxDates.Controls.Add(this.comboBoxPaymentCheck);
            this.groupBoxDates.Location = new System.Drawing.Point(10, 59);
            this.groupBoxDates.Name = "groupBoxDates";
            this.groupBoxDates.Size = new System.Drawing.Size(893, 67);
            this.groupBoxDates.TabIndex = 33;
            this.groupBoxDates.TabStop = false;
            // 
            // textBoxAddNote
            // 
            this.textBoxAddNote.Location = new System.Drawing.Point(635, 32);
            this.textBoxAddNote.Name = "textBoxAddNote";
            this.textBoxAddNote.Size = new System.Drawing.Size(252, 20);
            this.textBoxAddNote.TabIndex = 29;
            this.textBoxAddNote.TextChanged += new System.EventHandler(this.textBoxAddNote_TextChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(822, 741);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 34;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(741, 741);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(75, 23);
            this.buttonPrint.TabIndex = 35;
            this.buttonPrint.Text = "Drukuj";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // labelDefaultTax
            // 
            this.labelDefaultTax.AutoSize = true;
            this.labelDefaultTax.Location = new System.Drawing.Point(30, 45);
            this.labelDefaultTax.Name = "labelDefaultTax";
            this.labelDefaultTax.Size = new System.Drawing.Size(53, 13);
            this.labelDefaultTax.TabIndex = 36;
            this.labelDefaultTax.Text = "w złotych";
            // 
            // textBoxTaxDefault
            // 
            this.textBoxTaxDefault.Location = new System.Drawing.Point(89, 42);
            this.textBoxTaxDefault.Name = "textBoxTaxDefault";
            this.textBoxTaxDefault.ReadOnly = true;
            this.textBoxTaxDefault.Size = new System.Drawing.Size(76, 20);
            this.textBoxTaxDefault.TabIndex = 37;
            this.textBoxTaxDefault.Text = "0,00";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Location = new System.Drawing.Point(215, 22);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(112, 13);
            this.labelTotalPrice.TabIndex = 40;
            this.labelTotalPrice.Text = "Łączna wartość Netto";
            // 
            // textBoxValue1
            // 
            this.textBoxValue1.Location = new System.Drawing.Point(333, 19);
            this.textBoxValue1.Name = "textBoxValue1";
            this.textBoxValue1.ReadOnly = true;
            this.textBoxValue1.Size = new System.Drawing.Size(82, 20);
            this.textBoxValue1.TabIndex = 41;
            this.textBoxValue1.Text = "0,00";
            // 
            // labelDefaultPriceCopy
            // 
            this.labelDefaultPriceCopy.AutoSize = true;
            this.labelDefaultPriceCopy.Location = new System.Drawing.Point(421, 22);
            this.labelDefaultPriceCopy.Name = "labelDefaultPriceCopy";
            this.labelDefaultPriceCopy.Size = new System.Drawing.Size(53, 13);
            this.labelDefaultPriceCopy.TabIndex = 42;
            this.labelDefaultPriceCopy.Text = "w złotych";
            // 
            // textBoxValueDefault
            // 
            this.textBoxValueDefault.Location = new System.Drawing.Point(480, 19);
            this.textBoxValueDefault.Name = "textBoxValueDefault";
            this.textBoxValueDefault.ReadOnly = true;
            this.textBoxValueDefault.Size = new System.Drawing.Size(82, 20);
            this.textBoxValueDefault.TabIndex = 45;
            this.textBoxValueDefault.Text = "0,00";
            // 
            // textBoxTaxValueDefault
            // 
            this.textBoxTaxValueDefault.Location = new System.Drawing.Point(480, 45);
            this.textBoxTaxValueDefault.Name = "textBoxTaxValueDefault";
            this.textBoxTaxValueDefault.ReadOnly = true;
            this.textBoxTaxValueDefault.Size = new System.Drawing.Size(82, 20);
            this.textBoxTaxValueDefault.TabIndex = 43;
            this.textBoxTaxValueDefault.Text = "0,00";
            // 
            // groupBoxSummary
            // 
            this.groupBoxSummary.Controls.Add(this.dateTimePickerTable);
            this.groupBoxSummary.Controls.Add(this.labelDateCurrency);
            this.groupBoxSummary.Controls.Add(this.textBoxNumberToWord);
            this.groupBoxSummary.Controls.Add(this.labelPriceToText);
            this.groupBoxSummary.Controls.Add(this.labelTax);
            this.groupBoxSummary.Controls.Add(this.textBoxValueDefault);
            this.groupBoxSummary.Controls.Add(this.textBoxTaxValue1);
            this.groupBoxSummary.Controls.Add(this.textBoxTaxValueDefault);
            this.groupBoxSummary.Controls.Add(this.labelTotalValue);
            this.groupBoxSummary.Controls.Add(this.labelDefaultPriceCopy);
            this.groupBoxSummary.Controls.Add(this.textBoxTax1);
            this.groupBoxSummary.Controls.Add(this.textBoxValue1);
            this.groupBoxSummary.Controls.Add(this.labelDefaultTax);
            this.groupBoxSummary.Controls.Add(this.labelCurrencyPrice);
            this.groupBoxSummary.Controls.Add(this.labelTotalPrice);
            this.groupBoxSummary.Controls.Add(this.textBoxCurrency);
            this.groupBoxSummary.Controls.Add(this.textBoxTable);
            this.groupBoxSummary.Controls.Add(this.textBoxTaxDefault);
            this.groupBoxSummary.Location = new System.Drawing.Point(248, 582);
            this.groupBoxSummary.Name = "groupBoxSummary";
            this.groupBoxSummary.Size = new System.Drawing.Size(568, 135);
            this.groupBoxSummary.TabIndex = 46;
            this.groupBoxSummary.TabStop = false;
            this.groupBoxSummary.Text = "Podsumowanie";
            // 
            // dateTimePickerTable
            // 
            this.dateTimePickerTable.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTable.Location = new System.Drawing.Point(457, 106);
            this.dateTimePickerTable.Name = "dateTimePickerTable";
            this.dateTimePickerTable.Size = new System.Drawing.Size(105, 20);
            this.dateTimePickerTable.TabIndex = 49;
            this.dateTimePickerTable.ValueChanged += new System.EventHandler(this.dateTimePickerTable_ValueChanged);
            // 
            // labelDateCurrency
            // 
            this.labelDateCurrency.AutoSize = true;
            this.labelDateCurrency.Location = new System.Drawing.Point(356, 109);
            this.labelDateCurrency.Name = "labelDateCurrency";
            this.labelDateCurrency.Size = new System.Drawing.Size(95, 13);
            this.labelDateCurrency.TabIndex = 48;
            this.labelDateCurrency.Text = "Data tabeli kursów";
            // 
            // textBoxNumberToWord
            // 
            this.textBoxNumberToWord.Location = new System.Drawing.Point(218, 77);
            this.textBoxNumberToWord.Name = "textBoxNumberToWord";
            this.textBoxNumberToWord.ReadOnly = true;
            this.textBoxNumberToWord.Size = new System.Drawing.Size(344, 20);
            this.textBoxNumberToWord.TabIndex = 47;
            // 
            // labelPriceToText
            // 
            this.labelPriceToText.AutoSize = true;
            this.labelPriceToText.Location = new System.Drawing.Point(166, 80);
            this.labelPriceToText.Name = "labelPriceToText";
            this.labelPriceToText.Size = new System.Drawing.Size(46, 13);
            this.labelPriceToText.TabIndex = 46;
            this.labelPriceToText.Text = "Słownie";
            // 
            // buttonPreview
            // 
            this.buttonPreview.Location = new System.Drawing.Point(645, 741);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new System.Drawing.Size(75, 23);
            this.buttonPreview.TabIndex = 47;
            this.buttonPreview.Text = "Podgląd";
            this.buttonPreview.UseVisualStyleBackColor = true;
            this.buttonPreview.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // textBoxWarning
            // 
            this.textBoxWarning.Location = new System.Drawing.Point(6, 16);
            this.textBoxWarning.Multiline = true;
            this.textBoxWarning.Name = "textBoxWarning";
            this.textBoxWarning.Size = new System.Drawing.Size(203, 135);
            this.textBoxWarning.TabIndex = 48;
            this.textBoxWarning.WordWrap = false;
            this.textBoxWarning.TextChanged += new System.EventHandler(this.textBoxWarning_TextChanged);
            // 
            // groupBoxWarning
            // 
            this.groupBoxWarning.Controls.Add(this.textBoxWarning);
            this.groupBoxWarning.Location = new System.Drawing.Point(16, 605);
            this.groupBoxWarning.Name = "groupBoxWarning";
            this.groupBoxWarning.Size = new System.Drawing.Size(215, 159);
            this.groupBoxWarning.TabIndex = 50;
            this.groupBoxWarning.TabStop = false;
            this.groupBoxWarning.Text = "Uwagi";
            this.groupBoxWarning.Visible = false;
            // 
            // checkBoxWarning
            // 
            this.checkBoxWarning.AutoSize = true;
            this.checkBoxWarning.Location = new System.Drawing.Point(16, 582);
            this.checkBoxWarning.Name = "checkBoxWarning";
            this.checkBoxWarning.Size = new System.Drawing.Size(56, 17);
            this.checkBoxWarning.TabIndex = 51;
            this.checkBoxWarning.Text = "Uwagi";
            this.checkBoxWarning.UseVisualStyleBackColor = true;
            this.checkBoxWarning.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonEditItem
            // 
            this.buttonEditItem.Location = new System.Drawing.Point(822, 389);
            this.buttonEditItem.Name = "buttonEditItem";
            this.buttonEditItem.Size = new System.Drawing.Size(75, 51);
            this.buttonEditItem.TabIndex = 52;
            this.buttonEditItem.Text = "Edytuj pozycję";
            this.buttonEditItem.UseVisualStyleBackColor = true;
            this.buttonEditItem.Click += new System.EventHandler(this.buttonEditItem_Click);
            // 
            // labelCurrency
            // 
            this.labelCurrency.AutoSize = true;
            this.labelCurrency.Location = new System.Drawing.Point(775, 36);
            this.labelCurrency.Name = "labelCurrency";
            this.labelCurrency.Size = new System.Drawing.Size(41, 13);
            this.labelCurrency.TabIndex = 53;
            this.labelCurrency.Text = "Waluta";
            // 
            // comboBoxCurrency
            // 
            this.comboBoxCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCurrency.FormattingEnabled = true;
            this.comboBoxCurrency.Location = new System.Drawing.Point(822, 33);
            this.comboBoxCurrency.Name = "comboBoxCurrency";
            this.comboBoxCurrency.Size = new System.Drawing.Size(72, 21);
            this.comboBoxCurrency.TabIndex = 54;
            this.comboBoxCurrency.SelectedIndexChanged += new System.EventHandler(this.comboBoxCurrency_SelectedIndexChanged);
            // 
            // InvoiceAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 768);
            this.Controls.Add(this.comboBoxCurrency);
            this.Controls.Add(this.labelCurrency);
            this.Controls.Add(this.buttonEditItem);
            this.Controls.Add(this.checkBoxWarning);
            this.Controls.Add(this.groupBoxWarning);
            this.Controls.Add(this.buttonPreview);
            this.Controls.Add(this.groupBoxSummary);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxDates);
            this.Controls.Add(this.textBoxNrYear);
            this.Controls.Add(this.labelNameSlash1);
            this.Controls.Add(this.textBoxNr);
            this.Controls.Add(this.labelInvoiceNumber);
            this.Controls.Add(this.listViewItems);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDeleteItem);
            this.Controls.Add(this.buttonAddItem);
            this.Controls.Add(this.groupBoxContractors);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "InvoiceAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InvoiceAdd";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InvoiceAdd_FormClosing);
            this.groupBoxContractors.ResumeLayout(false);
            this.groupBoxContractors.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBoxDates.ResumeLayout(false);
            this.groupBoxDates.PerformLayout();
            this.groupBoxSummary.ResumeLayout(false);
            this.groupBoxSummary.PerformLayout();
            this.groupBoxWarning.ResumeLayout(false);
            this.groupBoxWarning.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBoxSeller1;
        public System.Windows.Forms.TextBox textBoxData1;
        public System.Windows.Forms.TextBox textBoxData2;
        public System.Windows.Forms.TextBox textBoxSeller2;
        public System.Windows.Forms.GroupBox groupBoxContractors;
        public System.Windows.Forms.MenuStrip menuStrip;
        public System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem kontrahentaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem produktUsługęToolStripMenuItem;
        public System.Windows.Forms.ListView listViewItems;
        public System.Windows.Forms.ColumnHeader columnHeaderName;
        public System.Windows.Forms.ColumnHeader columnHeaderUnit;
        public System.Windows.Forms.ColumnHeader columnHeaderPrice;
        public System.Windows.Forms.ColumnHeader columnHeaderTax;
        public System.Windows.Forms.ColumnHeader columnHeaderTaxPrice;
        public System.Windows.Forms.Button buttonEdit;
        public System.Windows.Forms.Button buttonDeleteItem;
        public System.Windows.Forms.Button buttonAddItem;
        public System.Windows.Forms.ColumnHeader columnHeaderCount;
        public System.Windows.Forms.ColumnHeader columnHeaderValue;
        public System.Windows.Forms.Button buttonChooseSeller;
        public System.Windows.Forms.Button buttonChooseBuyer;
        public System.Windows.Forms.TextBox textBoxTaxValue1;
        public System.Windows.Forms.Label labelTotalValue;
        public System.Windows.Forms.TextBox textBoxTax1;
        public System.Windows.Forms.Label labelTax;
        public System.Windows.Forms.TextBox textBoxTable;
        public System.Windows.Forms.TextBox textBoxCurrency;
        public System.Windows.Forms.Label labelCurrencyPrice;
        public System.Windows.Forms.Label labelMakingDate;
        public System.Windows.Forms.DateTimePicker dateTimePickerMaking;
        public System.Windows.Forms.DateTimePicker dateTimePickerSelling;
        public System.Windows.Forms.Label labelSellingDate;
        public System.Windows.Forms.Label labelSellingPlace;
        public System.Windows.Forms.TextBox textBoxPlace;
        public System.Windows.Forms.Label labelPayment;
        public System.Windows.Forms.ComboBox comboBoxPaymentCheck;
        public System.Windows.Forms.Label labelPaymentDate;
        public System.Windows.Forms.Label labelInvoiceNumber;
        public System.Windows.Forms.TextBox textBoxNr;
        public System.Windows.Forms.Label labelNameSlash1;
        public System.Windows.Forms.TextBox textBoxNrYear;
        public System.Windows.Forms.GroupBox groupBoxDates;
        public System.Windows.Forms.Button buttonSave;
        public System.Windows.Forms.Button buttonPrint;
        public System.Windows.Forms.Label labelDefaultTax;
        public System.Windows.Forms.TextBox textBoxTaxDefault;
        public System.Windows.Forms.ColumnHeader columnHeaderTaxValue;
        public System.Windows.Forms.Label labelTotalPrice;
        public System.Windows.Forms.TextBox textBoxValue1;
        public System.Windows.Forms.Label labelDefaultPriceCopy;
        public System.Windows.Forms.TextBox textBoxValueDefault;
        public System.Windows.Forms.TextBox textBoxTaxValueDefault;
        public System.Windows.Forms.GroupBox groupBoxSummary;
        public System.Windows.Forms.Button buttonPreview;
        public System.Drawing.Printing.PrintDocument printDocument;
        public System.Windows.Forms.ColumnHeader columnHeaderId;
        public System.Windows.Forms.TextBox textBoxNumberToWord;
        public System.Windows.Forms.Label labelPriceToText;
        public System.Windows.Forms.TextBox textBoxWarning;
        public System.Windows.Forms.GroupBox groupBoxWarning;
        public System.Windows.Forms.CheckBox checkBoxWarning;
        public System.Windows.Forms.TextBox textBoxAddNote;
        public System.Windows.Forms.DateTimePicker dateTimePickerTable;
        public System.Windows.Forms.Label labelDateCurrency;
        public System.Windows.Forms.Button buttonEditItem;
        private System.Windows.Forms.Label labelCurrency;
        private System.Windows.Forms.ComboBox comboBoxCurrency;

    }
}