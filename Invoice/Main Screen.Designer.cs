using System;
using System.Collections.Generic;
using Faktury.Items;
using Faktury.Utils;
namespace Faktury
{
    partial class FormMain
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.opcjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyjścieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageInvoice = new System.Windows.Forms.TabPage();
            this.groupBoxInvoice = new System.Windows.Forms.GroupBox();
            this.buttonCreateDefaultInvoice = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelValueSince = new System.Windows.Forms.Label();
            this.labelValueFrom = new System.Windows.Forms.Label();
            this.textBoxSince = new System.Windows.Forms.TextBox();
            this.textBoxUntil = new System.Windows.Forms.TextBox();
            this.labelSearchPlace = new System.Windows.Forms.Label();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.comboBoxPayer = new System.Windows.Forms.ComboBox();
            this.labelSearchBuyer = new System.Windows.Forms.Label();
            this.labelSearchContractor = new System.Windows.Forms.Label();
            this.comboBoxSeller = new System.Windows.Forms.ComboBox();
            this.labelDateSince = new System.Windows.Forms.Label();
            this.labelDateFrom = new System.Windows.Forms.Label();
            this.dateTimePickerSince = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.labelFilter = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonCreateInvoice = new System.Windows.Forms.Button();
            this.listViewInvoice = new System.Windows.Forms.ListView();
            this.columnHeaderNr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderContractor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBuyer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPlace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageItems = new System.Windows.Forms.TabPage();
            this.groupBoxItems = new System.Windows.Forms.GroupBox();
            this.listViewItems = new System.Windows.Forms.ListView();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderItemPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTaxPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderItemValeu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonEditItem = new System.Windows.Forms.Button();
            this.buttonDeleteItem = new System.Windows.Forms.Button();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBoxContractors = new System.Windows.Forms.GroupBox();
            this.buttonDeleteContractors = new System.Windows.Forms.Button();
            this.buttonEditContractos = new System.Windows.Forms.Button();
            this.buttonAddContractor = new System.Windows.Forms.Button();
            this.listViewContractors = new System.Windows.Forms.ListView();
            this.columnHeaderCoName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderContName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCoPlace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStreett = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPostal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageInvoice.SuspendLayout();
            this.groupBoxInvoice.SuspendLayout();
            this.tabPageItems.SuspendLayout();
            this.groupBoxItems.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBoxContractors.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcjeToolStripMenuItem,
            this.wyjścieToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1092, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // opcjeToolStripMenuItem
            // 
            this.opcjeToolStripMenuItem.Name = "opcjeToolStripMenuItem";
            this.opcjeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.opcjeToolStripMenuItem.Text = "Opcje";
            this.opcjeToolStripMenuItem.Click += new System.EventHandler(this.opcjeToolStripMenuItem_Click);
            // 
            // wyjścieToolStripMenuItem
            // 
            this.wyjścieToolStripMenuItem.Name = "wyjścieToolStripMenuItem";
            this.wyjścieToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.wyjścieToolStripMenuItem.Text = "Wyjście";
            this.wyjścieToolStripMenuItem.Click += new System.EventHandler(this.wyjścieToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageInvoice);
            this.tabControl.Controls.Add(this.tabPageItems);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(0, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1094, 590);
            this.tabControl.TabIndex = 9;
            // 
            // tabPageInvoice
            // 
            this.tabPageInvoice.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageInvoice.Controls.Add(this.groupBoxInvoice);
            this.tabPageInvoice.Location = new System.Drawing.Point(4, 22);
            this.tabPageInvoice.Name = "tabPageInvoice";
            this.tabPageInvoice.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInvoice.Size = new System.Drawing.Size(1086, 564);
            this.tabPageInvoice.TabIndex = 0;
            this.tabPageInvoice.Text = "Faktury";
            // 
            // groupBoxInvoice
            // 
            this.groupBoxInvoice.Controls.Add(this.buttonCreateDefaultInvoice);
            this.groupBoxInvoice.Controls.Add(this.buttonClear);
            this.groupBoxInvoice.Controls.Add(this.buttonSearch);
            this.groupBoxInvoice.Controls.Add(this.labelValueSince);
            this.groupBoxInvoice.Controls.Add(this.labelValueFrom);
            this.groupBoxInvoice.Controls.Add(this.textBoxSince);
            this.groupBoxInvoice.Controls.Add(this.textBoxUntil);
            this.groupBoxInvoice.Controls.Add(this.labelSearchPlace);
            this.groupBoxInvoice.Controls.Add(this.comboBoxCity);
            this.groupBoxInvoice.Controls.Add(this.comboBoxPayer);
            this.groupBoxInvoice.Controls.Add(this.labelSearchBuyer);
            this.groupBoxInvoice.Controls.Add(this.labelSearchContractor);
            this.groupBoxInvoice.Controls.Add(this.comboBoxSeller);
            this.groupBoxInvoice.Controls.Add(this.labelDateSince);
            this.groupBoxInvoice.Controls.Add(this.labelDateFrom);
            this.groupBoxInvoice.Controls.Add(this.dateTimePickerSince);
            this.groupBoxInvoice.Controls.Add(this.dateTimePickerFrom);
            this.groupBoxInvoice.Controls.Add(this.labelFilter);
            this.groupBoxInvoice.Controls.Add(this.buttonDelete);
            this.groupBoxInvoice.Controls.Add(this.buttonEdit);
            this.groupBoxInvoice.Controls.Add(this.buttonCreateInvoice);
            this.groupBoxInvoice.Controls.Add(this.listViewInvoice);
            this.groupBoxInvoice.Location = new System.Drawing.Point(8, 6);
            this.groupBoxInvoice.Name = "groupBoxInvoice";
            this.groupBoxInvoice.Size = new System.Drawing.Size(1068, 555);
            this.groupBoxInvoice.TabIndex = 0;
            this.groupBoxInvoice.TabStop = false;
            this.groupBoxInvoice.Text = "Faktury";
            // 
            // buttonCreateDefaultInvoice
            // 
            this.buttonCreateDefaultInvoice.Location = new System.Drawing.Point(987, 97);
            this.buttonCreateDefaultInvoice.Name = "buttonCreateDefaultInvoice";
            this.buttonCreateDefaultInvoice.Size = new System.Drawing.Size(75, 44);
            this.buttonCreateDefaultInvoice.TabIndex = 21;
            this.buttonCreateDefaultInvoice.Text = "Utwórz domyślną";
            this.buttonCreateDefaultInvoice.UseVisualStyleBackColor = true;
            this.buttonCreateDefaultInvoice.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(987, 11);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 20;
            this.buttonClear.Text = "Wyczyść";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(987, 38);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 19;
            this.buttonSearch.Text = "Szukaj";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelValueSince
            // 
            this.labelValueSince.AutoSize = true;
            this.labelValueSince.Location = new System.Drawing.Point(861, 45);
            this.labelValueSince.Name = "labelValueSince";
            this.labelValueSince.Size = new System.Drawing.Size(21, 13);
            this.labelValueSince.TabIndex = 18;
            this.labelValueSince.Text = "Do";
            // 
            // labelValueFrom
            // 
            this.labelValueFrom.AutoSize = true;
            this.labelValueFrom.Location = new System.Drawing.Point(861, 16);
            this.labelValueFrom.Name = "labelValueFrom";
            this.labelValueFrom.Size = new System.Drawing.Size(21, 13);
            this.labelValueFrom.TabIndex = 17;
            this.labelValueFrom.Text = "Od";
            // 
            // textBoxSince
            // 
            this.textBoxSince.Location = new System.Drawing.Point(881, 13);
            this.textBoxSince.Name = "textBoxSince";
            this.textBoxSince.Size = new System.Drawing.Size(100, 20);
            this.textBoxSince.TabIndex = 16;
            this.textBoxSince.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBoxUntil
            // 
            this.textBoxUntil.Location = new System.Drawing.Point(881, 41);
            this.textBoxUntil.Name = "textBoxUntil";
            this.textBoxUntil.Size = new System.Drawing.Size(100, 20);
            this.textBoxUntil.TabIndex = 15;
            this.textBoxUntil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // labelSearchPlace
            // 
            this.labelSearchPlace.AutoSize = true;
            this.labelSearchPlace.Location = new System.Drawing.Point(752, 22);
            this.labelSearchPlace.Name = "labelSearchPlace";
            this.labelSearchPlace.Size = new System.Drawing.Size(103, 13);
            this.labelSearchPlace.TabIndex = 14;
            this.labelSearchPlace.Text = "Miejsce wystawienia";
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Location = new System.Drawing.Point(755, 42);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(102, 21);
            this.comboBoxCity.TabIndex = 13;
            // 
            // comboBoxPayer
            // 
            this.comboBoxPayer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxPayer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxPayer.FormattingEnabled = true;
            this.comboBoxPayer.Location = new System.Drawing.Point(453, 41);
            this.comboBoxPayer.Name = "comboBoxPayer";
            this.comboBoxPayer.Size = new System.Drawing.Size(296, 21);
            this.comboBoxPayer.TabIndex = 12;
            // 
            // labelSearchBuyer
            // 
            this.labelSearchBuyer.AutoSize = true;
            this.labelSearchBuyer.Location = new System.Drawing.Point(450, 22);
            this.labelSearchBuyer.Name = "labelSearchBuyer";
            this.labelSearchBuyer.Size = new System.Drawing.Size(50, 13);
            this.labelSearchBuyer.TabIndex = 11;
            this.labelSearchBuyer.Text = "Odbiorca";
            // 
            // labelSearchContractor
            // 
            this.labelSearchContractor.AutoSize = true;
            this.labelSearchContractor.Location = new System.Drawing.Point(152, 22);
            this.labelSearchContractor.Name = "labelSearchContractor";
            this.labelSearchContractor.Size = new System.Drawing.Size(57, 13);
            this.labelSearchContractor.TabIndex = 10;
            this.labelSearchContractor.Text = "Wystawca";
            // 
            // comboBoxSeller
            // 
            this.comboBoxSeller.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxSeller.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSeller.FormattingEnabled = true;
            this.comboBoxSeller.Location = new System.Drawing.Point(155, 40);
            this.comboBoxSeller.Name = "comboBoxSeller";
            this.comboBoxSeller.Size = new System.Drawing.Size(292, 21);
            this.comboBoxSeller.TabIndex = 9;
            // 
            // labelDateSince
            // 
            this.labelDateSince.AutoSize = true;
            this.labelDateSince.Location = new System.Drawing.Point(45, 48);
            this.labelDateSince.Name = "labelDateSince";
            this.labelDateSince.Size = new System.Drawing.Size(21, 13);
            this.labelDateSince.TabIndex = 8;
            this.labelDateSince.Text = "Do";
            // 
            // labelDateFrom
            // 
            this.labelDateFrom.AutoSize = true;
            this.labelDateFrom.Location = new System.Drawing.Point(45, 22);
            this.labelDateFrom.Name = "labelDateFrom";
            this.labelDateFrom.Size = new System.Drawing.Size(21, 13);
            this.labelDateFrom.TabIndex = 7;
            this.labelDateFrom.Text = "Od";
            // 
            // dateTimePickerSince
            // 
            this.dateTimePickerSince.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSince.Location = new System.Drawing.Point(72, 42);
            this.dateTimePickerSince.Name = "dateTimePickerSince";
            this.dateTimePickerSince.Size = new System.Drawing.Size(77, 20);
            this.dateTimePickerSince.TabIndex = 6;
            this.dateTimePickerSince.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(72, 16);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(77, 20);
            this.dateTimePickerFrom.TabIndex = 5;
            this.dateTimePickerFrom.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFilter.Location = new System.Drawing.Point(9, 16);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(34, 13);
            this.labelFilter.TabIndex = 4;
            this.labelFilter.Text = "Filtry";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(987, 525);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Usuń";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(987, 147);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Edytuj";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // buttonCreateInvoice
            // 
            this.buttonCreateInvoice.Location = new System.Drawing.Point(987, 68);
            this.buttonCreateInvoice.Name = "buttonCreateInvoice";
            this.buttonCreateInvoice.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateInvoice.TabIndex = 1;
            this.buttonCreateInvoice.Text = "Utwórz";
            this.buttonCreateInvoice.UseVisualStyleBackColor = true;
            this.buttonCreateInvoice.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // listViewInvoice
            // 
            this.listViewInvoice.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNr,
            this.columnHeaderData,
            this.columnHeaderContractor,
            this.columnHeaderBuyer,
            this.columnHeaderPlace,
            this.columnHeaderValue});
            this.listViewInvoice.Cursor = System.Windows.Forms.Cursors.Default;
            this.listViewInvoice.FullRowSelect = true;
            this.listViewInvoice.HideSelection = false;
            this.listViewInvoice.Location = new System.Drawing.Point(6, 68);
            this.listViewInvoice.MultiSelect = false;
            this.listViewInvoice.Name = "listViewInvoice";
            this.listViewInvoice.Size = new System.Drawing.Size(975, 480);
            this.listViewInvoice.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.listViewInvoice.TabIndex = 0;
            this.listViewInvoice.UseCompatibleStateImageBehavior = false;
            this.listViewInvoice.View = System.Windows.Forms.View.Details;
            this.listViewInvoice.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView4_ColumnClick);
            this.listViewInvoice.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView4_MouseDoubleClick);
            // 
            // columnHeaderNr
            // 
            this.columnHeaderNr.Tag = "Numeric";
            this.columnHeaderNr.Text = "Nr.";
            this.columnHeaderNr.Width = 32;
            // 
            // columnHeaderData
            // 
            this.columnHeaderData.Text = "Data";
            this.columnHeaderData.Width = 115;
            // 
            // columnHeaderContractor
            // 
            this.columnHeaderContractor.Text = "Wystawca";
            this.columnHeaderContractor.Width = 300;
            // 
            // columnHeaderBuyer
            // 
            this.columnHeaderBuyer.Text = "Odbiorca";
            this.columnHeaderBuyer.Width = 300;
            // 
            // columnHeaderPlace
            // 
            this.columnHeaderPlace.Text = "Miejsce wystawienia";
            this.columnHeaderPlace.Width = 110;
            // 
            // columnHeaderValue
            // 
            this.columnHeaderValue.Tag = "Price";
            this.columnHeaderValue.Text = "Wartość Brutto";
            this.columnHeaderValue.Width = 91;
            // 
            // tabPageItems
            // 
            this.tabPageItems.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageItems.Controls.Add(this.groupBoxItems);
            this.tabPageItems.Location = new System.Drawing.Point(4, 22);
            this.tabPageItems.Name = "tabPageItems";
            this.tabPageItems.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageItems.Size = new System.Drawing.Size(1086, 564);
            this.tabPageItems.TabIndex = 1;
            this.tabPageItems.Text = "Produkty";
            // 
            // groupBoxItems
            // 
            this.groupBoxItems.Controls.Add(this.listViewItems);
            this.groupBoxItems.Controls.Add(this.buttonEditItem);
            this.groupBoxItems.Controls.Add(this.buttonDeleteItem);
            this.groupBoxItems.Controls.Add(this.buttonAddItem);
            this.groupBoxItems.Location = new System.Drawing.Point(6, 6);
            this.groupBoxItems.Name = "groupBoxItems";
            this.groupBoxItems.Size = new System.Drawing.Size(1070, 552);
            this.groupBoxItems.TabIndex = 9;
            this.groupBoxItems.TabStop = false;
            this.groupBoxItems.Text = "Produkty/Usługi";
            // 
            // listViewItems
            // 
            this.listViewItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderName,
            this.columnHeaderUnit,
            this.columnHeaderItemPrice,
            this.columnHeaderTax,
            this.columnHeaderTaxPrice,
            this.columnHeaderItemValeu});
            this.listViewItems.FullRowSelect = true;
            this.listViewItems.HideSelection = false;
            this.listViewItems.Location = new System.Drawing.Point(6, 19);
            this.listViewItems.MultiSelect = false;
            this.listViewItems.Name = "listViewItems";
            this.listViewItems.Size = new System.Drawing.Size(977, 534);
            this.listViewItems.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewItems.TabIndex = 5;
            this.listViewItems.UseCompatibleStateImageBehavior = false;
            this.listViewItems.View = System.Windows.Forms.View.Details;
            this.listViewItems.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewItems_ColumnClick);
            this.listViewItems.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listViewItems_KeyPress);
            this.listViewItems.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewItems_MouseDoubleClick);
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Tag = "Numeric";
            this.columnHeaderId.Text = "Id";
            this.columnHeaderId.Width = 30;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Nazwa";
            this.columnHeaderName.Width = 581;
            // 
            // columnHeaderUnit
            // 
            this.columnHeaderUnit.Text = "J.m";
            this.columnHeaderUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderUnit.Width = 32;
            // 
            // columnHeaderItemPrice
            // 
            this.columnHeaderItemPrice.Tag = "Numeric";
            this.columnHeaderItemPrice.Text = "Cena Netto";
            this.columnHeaderItemPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderItemPrice.Width = 67;
            // 
            // columnHeaderTax
            // 
            this.columnHeaderTax.Text = "Stawka VAT(%)";
            this.columnHeaderTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderTax.Width = 93;
            // 
            // columnHeaderTaxPrice
            // 
            this.columnHeaderTaxPrice.Tag = "Numeric";
            this.columnHeaderTaxPrice.Text = "Kwota VAT";
            this.columnHeaderTaxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderTaxPrice.Width = 84;
            // 
            // columnHeaderItemValeu
            // 
            this.columnHeaderItemValeu.Tag = "Price";
            this.columnHeaderItemValeu.Text = "Cena Brutto";
            this.columnHeaderItemValeu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderItemValeu.Width = 69;
            // 
            // buttonEditItem
            // 
            this.buttonEditItem.Location = new System.Drawing.Point(989, 47);
            this.buttonEditItem.Name = "buttonEditItem";
            this.buttonEditItem.Size = new System.Drawing.Size(75, 23);
            this.buttonEditItem.TabIndex = 6;
            this.buttonEditItem.Text = "Edytuj";
            this.buttonEditItem.UseVisualStyleBackColor = true;
            this.buttonEditItem.Click += new System.EventHandler(this.buttonEditItem_Click);
            // 
            // buttonDeleteItem
            // 
            this.buttonDeleteItem.Location = new System.Drawing.Point(989, 523);
            this.buttonDeleteItem.Name = "buttonDeleteItem";
            this.buttonDeleteItem.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteItem.TabIndex = 4;
            this.buttonDeleteItem.Text = "Usuń";
            this.buttonDeleteItem.UseVisualStyleBackColor = true;
            this.buttonDeleteItem.Click += new System.EventHandler(this.BDeleteItem_Click);
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Location = new System.Drawing.Point(989, 18);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(75, 23);
            this.buttonAddItem.TabIndex = 2;
            this.buttonAddItem.Text = "Dodaj";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Click += new System.EventHandler(this.BAddItem_Click_1);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.groupBoxContractors);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1086, 564);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Kontrahenci";
            // 
            // groupBoxContractors
            // 
            this.groupBoxContractors.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxContractors.Controls.Add(this.buttonDeleteContractors);
            this.groupBoxContractors.Controls.Add(this.buttonEditContractos);
            this.groupBoxContractors.Controls.Add(this.buttonAddContractor);
            this.groupBoxContractors.Controls.Add(this.listViewContractors);
            this.groupBoxContractors.Location = new System.Drawing.Point(3, 6);
            this.groupBoxContractors.Name = "groupBoxContractors";
            this.groupBoxContractors.Size = new System.Drawing.Size(1078, 552);
            this.groupBoxContractors.TabIndex = 10;
            this.groupBoxContractors.TabStop = false;
            this.groupBoxContractors.Text = "Kontrahenci";
            // 
            // buttonDeleteContractors
            // 
            this.buttonDeleteContractors.Location = new System.Drawing.Point(991, 523);
            this.buttonDeleteContractors.Name = "buttonDeleteContractors";
            this.buttonDeleteContractors.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteContractors.TabIndex = 3;
            this.buttonDeleteContractors.Text = "Usuń";
            this.buttonDeleteContractors.UseVisualStyleBackColor = true;
            this.buttonDeleteContractors.Click += new System.EventHandler(this.buttonDeleteContractors_Click);
            // 
            // buttonEditContractos
            // 
            this.buttonEditContractos.Location = new System.Drawing.Point(991, 49);
            this.buttonEditContractos.Name = "buttonEditContractos";
            this.buttonEditContractos.Size = new System.Drawing.Size(75, 23);
            this.buttonEditContractos.TabIndex = 2;
            this.buttonEditContractos.Text = "Edytuj";
            this.buttonEditContractos.UseVisualStyleBackColor = true;
            this.buttonEditContractos.Click += new System.EventHandler(this.buttonEditContractos_Click);
            // 
            // buttonAddContractor
            // 
            this.buttonAddContractor.Location = new System.Drawing.Point(991, 19);
            this.buttonAddContractor.Name = "buttonAddContractor";
            this.buttonAddContractor.Size = new System.Drawing.Size(75, 23);
            this.buttonAddContractor.TabIndex = 1;
            this.buttonAddContractor.Text = "Dodaj";
            this.buttonAddContractor.UseVisualStyleBackColor = true;
            this.buttonAddContractor.Click += new System.EventHandler(this.buttonAddContractor_Click_1);
            // 
            // listViewContractors
            // 
            this.listViewContractors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCoName,
            this.columnHeaderContName,
            this.columnHeaderType,
            this.columnHeaderCoPlace,
            this.columnHeaderStreett,
            this.columnHeaderPostal});
            this.listViewContractors.FullRowSelect = true;
            this.listViewContractors.HideSelection = false;
            this.listViewContractors.Location = new System.Drawing.Point(12, 19);
            this.listViewContractors.MultiSelect = false;
            this.listViewContractors.Name = "listViewContractors";
            this.listViewContractors.Size = new System.Drawing.Size(973, 527);
            this.listViewContractors.TabIndex = 0;
            this.listViewContractors.UseCompatibleStateImageBehavior = false;
            this.listViewContractors.View = System.Windows.Forms.View.Details;
            this.listViewContractors.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewContractors_ColumnClick);
            this.listViewContractors.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listViewContractors_KeyPress);
            this.listViewContractors.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewContractors_MouseDoubleClick);
            // 
            // columnHeaderCoName
            // 
            this.columnHeaderCoName.Text = "Nazwa firmy";
            this.columnHeaderCoName.Width = 280;
            // 
            // columnHeaderContName
            // 
            this.columnHeaderContName.Text = "Nazwa właściciela";
            this.columnHeaderContName.Width = 280;
            // 
            // columnHeaderType
            // 
            this.columnHeaderType.Text = "Typ";
            this.columnHeaderType.Width = 80;
            // 
            // columnHeaderCoPlace
            // 
            this.columnHeaderCoPlace.Text = "Miejscowość";
            this.columnHeaderCoPlace.Width = 100;
            // 
            // columnHeaderStreett
            // 
            this.columnHeaderStreett.Text = "Ulica";
            this.columnHeaderStreett.Width = 158;
            // 
            // columnHeaderPostal
            // 
            this.columnHeaderPostal.Text = "Kod";
            this.columnHeaderPostal.Width = 50;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 615);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inboisu";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageInvoice.ResumeLayout(false);
            this.groupBoxInvoice.ResumeLayout(false);
            this.groupBoxInvoice.PerformLayout();
            this.tabPageItems.ResumeLayout(false);
            this.groupBoxItems.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBoxContractors.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem opcjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyjścieToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageInvoice;
        private System.Windows.Forms.GroupBox groupBoxInvoice;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonCreateInvoice;
        private System.Windows.Forms.ListView listViewInvoice;
        private System.Windows.Forms.ColumnHeader columnHeaderNr;
        private System.Windows.Forms.ColumnHeader columnHeaderBuyer;
        private System.Windows.Forms.ColumnHeader columnHeaderPlace;
        private System.Windows.Forms.ColumnHeader columnHeaderData;
        private System.Windows.Forms.ColumnHeader columnHeaderValue;
        private System.Windows.Forms.ColumnHeader columnHeaderContractor;
        private System.Windows.Forms.TabPage tabPageItems;
        private System.Windows.Forms.GroupBox groupBoxItems;
        private System.Windows.Forms.ListView listViewItems;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderUnit;
        private System.Windows.Forms.ColumnHeader columnHeaderItemPrice;
        private System.Windows.Forms.ColumnHeader columnHeaderTax;
        private System.Windows.Forms.ColumnHeader columnHeaderTaxPrice;
        private System.Windows.Forms.ColumnHeader columnHeaderItemValeu;
        private System.Windows.Forms.Button buttonEditItem;
        private System.Windows.Forms.Button buttonDeleteItem;
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBoxContractors;
        private System.Windows.Forms.Button buttonDeleteContractors;
        private System.Windows.Forms.Button buttonEditContractos;
        private System.Windows.Forms.Button buttonAddContractor;
        private System.Windows.Forms.ListView listViewContractors;
        private System.Windows.Forms.ColumnHeader columnHeaderCoName;
        private System.Windows.Forms.ColumnHeader columnHeaderType;
        private System.Windows.Forms.ColumnHeader columnHeaderCoPlace;
        private System.Windows.Forms.ColumnHeader columnHeaderStreett;
        private System.Windows.Forms.ColumnHeader columnHeaderPostal;
        private System.Windows.Forms.ColumnHeader columnHeaderContName;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelValueSince;
        private System.Windows.Forms.Label labelValueFrom;
        private System.Windows.Forms.TextBox textBoxSince;
        private System.Windows.Forms.TextBox textBoxUntil;
        private System.Windows.Forms.Label labelSearchPlace;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.ComboBox comboBoxPayer;
        private System.Windows.Forms.Label labelSearchBuyer;
        private System.Windows.Forms.Label labelSearchContractor;
        private System.Windows.Forms.ComboBox comboBoxSeller;
        private System.Windows.Forms.Label labelDateSince;
        private System.Windows.Forms.Label labelDateFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerSince;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonCreateDefaultInvoice;
    }
}

