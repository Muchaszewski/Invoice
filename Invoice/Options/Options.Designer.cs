namespace Faktury
{
    partial class FOptions
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelVersionOnline = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxPayment = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxCurrencyDefault = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxCurrency = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDecimal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonNewGoogle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRestoreLoad = new System.Windows.Forms.Button();
            this.buttonNewLocal = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numer kolejnej faktury";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.labelVersionOnline);
            this.groupBox1.Controls.Add(this.labelVersion);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBoxPayment);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.comboBoxCurrencyDefault);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBoxCurrency);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxDecimal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 398);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcje Fakturowania";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Command box";
            this.label9.Visible = false;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Wypełnij fakturę domyślną";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(417, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Domyślna forma płatności";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(417, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Waluta sprzedającego";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(417, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Domyślna waluta kupującego";
            // 
            // textBoxDecimal
            // 
            this.textBoxDecimal.Enabled = false;
            this.textBoxDecimal.Location = new System.Drawing.Point(137, 48);
            this.textBoxDecimal.MaxLength = 2;
            this.textBoxDecimal.Name = "textBoxDecimal";
            this.textBoxDecimal.Size = new System.Drawing.Size(87, 20);
            this.textBoxDecimal.TabIndex = 5;
            this.textBoxDecimal.Text = "4";
            this.textBoxDecimal.TextChanged += new System.EventHandler(this.textBoxDecimal_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ilość miejsc po przecinku";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Utwórz kopię zapasową na Google Drive";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.buttonRestoreLoad);
            this.groupBox2.Controls.Add(this.buttonNewLocal);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.buttonNewGoogle);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(0, 431);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(685, 83);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kopie zapasowe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Wybierz punkt przywracania danych";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Utwórz kopię zapasową lokalnie";
            // 
            // FOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 526);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FOptions";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FOptions_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonNewGoogle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonRestoreLoad;
        private System.Windows.Forms.Button buttonNewLocal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDecimal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxCurrencyDefault;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxCurrency;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxPayment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelVersionOnline;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
    }
}