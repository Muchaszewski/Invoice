namespace Faktury.DialogBox
{
    partial class ItemChoose
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.listViewItems = new System.Windows.Forms.ListView();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTaxValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonEditItem = new System.Windows.Forms.Button();
            this.buttonDeleteItem = new System.Windows.Forms.Button();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.buttonChoose);
            this.groupBox.Controls.Add(this.listViewItems);
            this.groupBox.Controls.Add(this.buttonEditItem);
            this.groupBox.Controls.Add(this.buttonDeleteItem);
            this.groupBox.Controls.Add(this.buttonAddItem);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(771, 368);
            this.groupBox.TabIndex = 8;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Produkty/Usługi";
            // 
            // buttonChoose
            // 
            this.buttonChoose.Location = new System.Drawing.Point(689, 77);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(75, 58);
            this.buttonChoose.TabIndex = 7;
            this.buttonChoose.Text = "Wybierz";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewItems
            // 
            this.listViewItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderName,
            this.columnHeaderUnit,
            this.columnHeaderPrice,
            this.columnHeaderTax,
            this.columnHeaderTaxValue,
            this.columnHeaderValue});
            this.listViewItems.FullRowSelect = true;
            this.listViewItems.HideSelection = false;
            this.listViewItems.Location = new System.Drawing.Point(6, 19);
            this.listViewItems.MultiSelect = false;
            this.listViewItems.Name = "listViewItems";
            this.listViewItems.Size = new System.Drawing.Size(677, 343);
            this.listViewItems.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewItems.TabIndex = 5;
            this.listViewItems.UseCompatibleStateImageBehavior = false;
            this.listViewItems.View = System.Windows.Forms.View.Details;
            this.listViewItems.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.listViewItems.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listView1_KeyPress);
            this.listViewItems.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MousedecimalClick);
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "Id";
            this.columnHeaderId.Width = 30;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Nazwa";
            this.columnHeaderName.Width = 280;
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
            // columnHeaderTaxValue
            // 
            this.columnHeaderTaxValue.Text = "Kwota VAT(zł)";
            this.columnHeaderTaxValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderTaxValue.Width = 84;
            // 
            // columnHeaderValue
            // 
            this.columnHeaderValue.Text = "Cena Brutto";
            this.columnHeaderValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderValue.Width = 69;
            // 
            // buttonEditItem
            // 
            this.buttonEditItem.Location = new System.Drawing.Point(689, 48);
            this.buttonEditItem.Name = "buttonEditItem";
            this.buttonEditItem.Size = new System.Drawing.Size(75, 23);
            this.buttonEditItem.TabIndex = 6;
            this.buttonEditItem.Text = "Edytuj";
            this.buttonEditItem.UseVisualStyleBackColor = true;
            this.buttonEditItem.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDeleteItem
            // 
            this.buttonDeleteItem.Location = new System.Drawing.Point(689, 339);
            this.buttonDeleteItem.Name = "buttonDeleteItem";
            this.buttonDeleteItem.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteItem.TabIndex = 4;
            this.buttonDeleteItem.Text = "Usuń";
            this.buttonDeleteItem.UseVisualStyleBackColor = true;
            this.buttonDeleteItem.Click += new System.EventHandler(this.BDeleteItem_Click);
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Location = new System.Drawing.Point(689, 19);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(75, 23);
            this.buttonAddItem.TabIndex = 2;
            this.buttonAddItem.Text = "Dodaj";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Click += new System.EventHandler(this.BAddItem_Click);
            // 
            // ItemChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 392);
            this.Controls.Add(this.groupBox);
            this.Name = "ItemChoose";
            this.Text = "ItemChoose";
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.ListView listViewItems;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderUnit;
        private System.Windows.Forms.ColumnHeader columnHeaderPrice;
        private System.Windows.Forms.ColumnHeader columnHeaderTax;
        private System.Windows.Forms.ColumnHeader columnHeaderTaxValue;
        private System.Windows.Forms.ColumnHeader columnHeaderValue;
        private System.Windows.Forms.Button buttonEditItem;
        private System.Windows.Forms.Button buttonDeleteItem;
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
    }
}