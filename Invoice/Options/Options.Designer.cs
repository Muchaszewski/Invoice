namespace Faktury
{
    partial class FormOptions
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.labelNaxtInvoiceNr = new System.Windows.Forms.Label();
            this.groupBoxInvoice = new System.Windows.Forms.GroupBox();
            this.labelCommand = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelVersionOnline = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.buttonDefaultInvoice = new System.Windows.Forms.Button();
            this.comboBoxPayment = new System.Windows.Forms.ComboBox();
            this.labelPayment = new System.Windows.Forms.Label();
            this.comboBoxCurrencyDefault = new System.Windows.Forms.ComboBox();
            this.label7BuyerCurrency = new System.Windows.Forms.Label();
            this.comboBoxCurrency = new System.Windows.Forms.ComboBox();
            this.labelCurrency = new System.Windows.Forms.Label();
            this.textBoxNextInvoiceNr = new System.Windows.Forms.TextBox();
            this.labelMakeGoogle = new System.Windows.Forms.Label();
            this.buttonNewGoogle = new System.Windows.Forms.Button();
            this.groupBoxBakcup = new System.Windows.Forms.GroupBox();
            this.labelLoadBackup = new System.Windows.Forms.Label();
            this.buttonRestoreLoad = new System.Windows.Forms.Button();
            this.buttonNewLocal = new System.Windows.Forms.Button();
            this.labelMakeLocal = new System.Windows.Forms.Label();
            this.groupBoxInvoice.SuspendLayout();
            this.groupBoxBakcup.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(685, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // labelNaxtInvoiceNr
            // 
            this.labelNaxtInvoiceNr.AutoSize = true;
            this.labelNaxtInvoiceNr.Location = new System.Drawing.Point(6, 25);
            this.labelNaxtInvoiceNr.Name = "labelNaxtInvoiceNr";
            this.labelNaxtInvoiceNr.Size = new System.Drawing.Size(112, 13);
            this.labelNaxtInvoiceNr.TabIndex = 2;
            this.labelNaxtInvoiceNr.Text = "Numer kolejnej faktury";
            // 
            // groupBoxInvoice
            // 
            this.groupBoxInvoice.Controls.Add(this.labelCommand);
            this.groupBoxInvoice.Controls.Add(this.textBox2);
            this.groupBoxInvoice.Controls.Add(this.labelVersionOnline);
            this.groupBoxInvoice.Controls.Add(this.labelVersion);
            this.groupBoxInvoice.Controls.Add(this.buttonDefaultInvoice);
            this.groupBoxInvoice.Controls.Add(this.comboBoxPayment);
            this.groupBoxInvoice.Controls.Add(this.labelPayment);
            this.groupBoxInvoice.Controls.Add(this.comboBoxCurrencyDefault);
            this.groupBoxInvoice.Controls.Add(this.label7BuyerCurrency);
            this.groupBoxInvoice.Controls.Add(this.comboBoxCurrency);
            this.groupBoxInvoice.Controls.Add(this.labelCurrency);
            this.groupBoxInvoice.Controls.Add(this.textBoxNextInvoiceNr);
            this.groupBoxInvoice.Controls.Add(this.labelNaxtInvoiceNr);
            this.groupBoxInvoice.Location = new System.Drawing.Point(0, 27);
            this.groupBoxInvoice.Name = "groupBoxInvoice";
            this.groupBoxInvoice.Size = new System.Drawing.Size(685, 398);
            this.groupBoxInvoice.TabIndex = 3;
            this.groupBoxInvoice.TabStop = false;
            this.groupBoxInvoice.Text = "Opcje Fakturowania";
            // 
            // labelCommand
            // 
            this.labelCommand.AutoSize = true;
            this.labelCommand.Location = new System.Drawing.Point(12, 331);
            this.labelCommand.Name = "labelCommand";
            this.labelCommand.Size = new System.Drawing.Size(74, 13);
            this.labelCommand.TabIndex = 16;
            this.labelCommand.Text = "Command box";
            this.labelCommand.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(92, 328);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 20);
            this.textBox2.TabIndex = 15;
            this.textBox2.Visible = false;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelVersionOnline
            // 
            this.labelVersionOnline.AutoSize = true;
            this.labelVersionOnline.Enabled = false;
            this.labelVersionOnline.Location = new System.Drawing.Point(12, 350);
            this.labelVersionOnline.Name = "labelVersionOnline";
            this.labelVersionOnline.Size = new System.Drawing.Size(42, 13);
            this.labelVersionOnline.TabIndex = 14;
            this.labelVersionOnline.Text = "Version";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Enabled = false;
            this.labelVersion.Location = new System.Drawing.Point(12, 372);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(42, 13);
            this.labelVersion.TabIndex = 13;
            this.labelVersion.Text = "Version";
            // 
            // buttonDefaultInvoice
            // 
            this.buttonDefaultInvoice.Location = new System.Drawing.Point(420, 147);
            this.buttonDefaultInvoice.Name = "buttonDefaultInvoice";
            this.buttonDefaultInvoice.Size = new System.Drawing.Size(259, 23);
            this.buttonDefaultInvoice.TabIndex = 12;
            this.buttonDefaultInvoice.Text = "Wypełnij fakturę domyślną";
            this.buttonDefaultInvoice.UseVisualStyleBackColor = true;
            this.buttonDefaultInvoice.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxPayment
            // 
            this.comboBoxPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPayment.FormattingEnabled = true;
            this.comboBoxPayment.Items.AddRange(new object[] {
            "gotówką",
            "przelewem"});
            this.comboBoxPayment.Location = new System.Drawing.Point(552, 19);
            this.comboBoxPayment.Name = "comboBoxPayment";
            this.comboBoxPayment.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPayment.TabIndex = 11;
            this.comboBoxPayment.SelectedIndexChanged += new System.EventHandler(this.comboBoxPayment_SelectedIndexChanged);
            // 
            // labelPayment
            // 
            this.labelPayment.AutoSize = true;
            this.labelPayment.Location = new System.Drawing.Point(417, 22);
            this.labelPayment.Name = "labelPayment";
            this.labelPayment.Size = new System.Drawing.Size(129, 13);
            this.labelPayment.TabIndex = 10;
            this.labelPayment.Text = "Domyślna forma płatności";
            // 
            // comboBoxCurrencyDefault
            // 
            this.comboBoxCurrencyDefault.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCurrencyDefault.FormattingEnabled = true;
            this.comboBoxCurrencyDefault.Location = new System.Drawing.Point(565, 75);
            this.comboBoxCurrencyDefault.Name = "comboBoxCurrencyDefault";
            this.comboBoxCurrencyDefault.Size = new System.Drawing.Size(108, 21);
            this.comboBoxCurrencyDefault.TabIndex = 9;
            this.comboBoxCurrencyDefault.SelectedIndexChanged += new System.EventHandler(this.comboBoxCurrencyDefault_SelectedIndexChanged);
            // 
            // label7BuyerCurrency
            // 
            this.label7BuyerCurrency.AutoSize = true;
            this.label7BuyerCurrency.Location = new System.Drawing.Point(417, 78);
            this.label7BuyerCurrency.Name = "label7BuyerCurrency";
            this.label7BuyerCurrency.Size = new System.Drawing.Size(113, 13);
            this.label7BuyerCurrency.TabIndex = 8;
            this.label7BuyerCurrency.Text = "Waluta sprzedającego";
            // 
            // comboBoxCurrency
            // 
            this.comboBoxCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCurrency.FormattingEnabled = true;
            this.comboBoxCurrency.Location = new System.Drawing.Point(565, 48);
            this.comboBoxCurrency.Name = "comboBoxCurrency";
            this.comboBoxCurrency.Size = new System.Drawing.Size(108, 21);
            this.comboBoxCurrency.TabIndex = 7;
            this.comboBoxCurrency.SelectedIndexChanged += new System.EventHandler(this.comboBoxCurrency_SelectedIndexChanged);
            // 
            // labelCurrency
            // 
            this.labelCurrency.AutoSize = true;
            this.labelCurrency.Location = new System.Drawing.Point(417, 51);
            this.labelCurrency.Name = "labelCurrency";
            this.labelCurrency.Size = new System.Drawing.Size(146, 13);
            this.labelCurrency.TabIndex = 6;
            this.labelCurrency.Text = "Domyślna waluta kupującego";
            // 
            // textBoxNextInvoiceNr
            // 
            this.textBoxNextInvoiceNr.Location = new System.Drawing.Point(124, 22);
            this.textBoxNextInvoiceNr.Name = "textBoxNextInvoiceNr";
            this.textBoxNextInvoiceNr.Size = new System.Drawing.Size(100, 20);
            this.textBoxNextInvoiceNr.TabIndex = 3;
            this.textBoxNextInvoiceNr.Text = "1";
            this.textBoxNextInvoiceNr.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelMakeGoogle
            // 
            this.labelMakeGoogle.AutoSize = true;
            this.labelMakeGoogle.Location = new System.Drawing.Point(12, 24);
            this.labelMakeGoogle.Name = "labelMakeGoogle";
            this.labelMakeGoogle.Size = new System.Drawing.Size(200, 13);
            this.labelMakeGoogle.TabIndex = 6;
            this.labelMakeGoogle.Text = "Utwórz kopię zapasową na Google Drive";
            // 
            // buttonNewGoogle
            // 
            this.buttonNewGoogle.Location = new System.Drawing.Point(218, 19);
            this.buttonNewGoogle.Name = "buttonNewGoogle";
            this.buttonNewGoogle.Size = new System.Drawing.Size(75, 23);
            this.buttonNewGoogle.TabIndex = 7;
            this.buttonNewGoogle.Text = "Utwórz";
            this.buttonNewGoogle.UseVisualStyleBackColor = true;
            this.buttonNewGoogle.Click += new System.EventHandler(this.buttonNewGoogle_Click);
            // 
            // groupBoxBakcup
            // 
            this.groupBoxBakcup.Controls.Add(this.labelLoadBackup);
            this.groupBoxBakcup.Controls.Add(this.buttonRestoreLoad);
            this.groupBoxBakcup.Controls.Add(this.buttonNewLocal);
            this.groupBoxBakcup.Controls.Add(this.labelMakeLocal);
            this.groupBoxBakcup.Controls.Add(this.buttonNewGoogle);
            this.groupBoxBakcup.Controls.Add(this.labelMakeGoogle);
            this.groupBoxBakcup.Location = new System.Drawing.Point(0, 431);
            this.groupBoxBakcup.Name = "groupBoxBakcup";
            this.groupBoxBakcup.Size = new System.Drawing.Size(685, 83);
            this.groupBoxBakcup.TabIndex = 4;
            this.groupBoxBakcup.TabStop = false;
            this.groupBoxBakcup.Text = "Kopie zapasowe";
            // 
            // labelLoadBackup
            // 
            this.labelLoadBackup.AutoSize = true;
            this.labelLoadBackup.Location = new System.Drawing.Point(420, 24);
            this.labelLoadBackup.Name = "labelLoadBackup";
            this.labelLoadBackup.Size = new System.Drawing.Size(178, 13);
            this.labelLoadBackup.TabIndex = 13;
            this.labelLoadBackup.Text = "Wybierz punkt przywracania danych";
            // 
            // buttonRestoreLoad
            // 
            this.buttonRestoreLoad.Location = new System.Drawing.Point(604, 19);
            this.buttonRestoreLoad.Name = "buttonRestoreLoad";
            this.buttonRestoreLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonRestoreLoad.TabIndex = 12;
            this.buttonRestoreLoad.Text = "Wczytaj";
            this.buttonRestoreLoad.UseVisualStyleBackColor = true;
            this.buttonRestoreLoad.Click += new System.EventHandler(this.buttonRestoreLoad_Click);
            // 
            // buttonNewLocal
            // 
            this.buttonNewLocal.Enabled = false;
            this.buttonNewLocal.Location = new System.Drawing.Point(218, 48);
            this.buttonNewLocal.Name = "buttonNewLocal";
            this.buttonNewLocal.Size = new System.Drawing.Size(75, 23);
            this.buttonNewLocal.TabIndex = 9;
            this.buttonNewLocal.Text = "Utwórz";
            this.buttonNewLocal.UseVisualStyleBackColor = true;
            // 
            // labelMakeLocal
            // 
            this.labelMakeLocal.AutoSize = true;
            this.labelMakeLocal.Location = new System.Drawing.Point(12, 53);
            this.labelMakeLocal.Name = "labelMakeLocal";
            this.labelMakeLocal.Size = new System.Drawing.Size(159, 13);
            this.labelMakeLocal.TabIndex = 8;
            this.labelMakeLocal.Text = "Utwórz kopię zapasową lokalnie";
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 526);
            this.Controls.Add(this.groupBoxBakcup);
            this.Controls.Add(this.groupBoxInvoice);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOptions";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FOptions_KeyDown);
            this.groupBoxInvoice.ResumeLayout(false);
            this.groupBoxInvoice.PerformLayout();
            this.groupBoxBakcup.ResumeLayout(false);
            this.groupBoxBakcup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label labelNaxtInvoiceNr;
        private System.Windows.Forms.GroupBox groupBoxInvoice;
        private System.Windows.Forms.TextBox textBoxNextInvoiceNr;
        private System.Windows.Forms.Label labelMakeGoogle;
        private System.Windows.Forms.Button buttonNewGoogle;
        private System.Windows.Forms.GroupBox groupBoxBakcup;
        private System.Windows.Forms.Button buttonRestoreLoad;
        private System.Windows.Forms.Button buttonNewLocal;
        private System.Windows.Forms.Label labelMakeLocal;
        private System.Windows.Forms.Label labelLoadBackup;
        private System.Windows.Forms.ComboBox comboBoxCurrencyDefault;
        private System.Windows.Forms.Label label7BuyerCurrency;
        private System.Windows.Forms.ComboBox comboBoxCurrency;
        private System.Windows.Forms.Label labelCurrency;
        private System.Windows.Forms.ComboBox comboBoxPayment;
        private System.Windows.Forms.Label labelPayment;
        private System.Windows.Forms.Button buttonDefaultInvoice;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelVersionOnline;
        private System.Windows.Forms.Label labelCommand;
        private System.Windows.Forms.TextBox textBox2;
    }
}