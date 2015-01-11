namespace Faktury.DialogBox
{
    partial class ContractorChoose
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
            this.groupBoxContractors = new System.Windows.Forms.GroupBox();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.buttonDeleteContractors = new System.Windows.Forms.Button();
            this.buttonEditContractos = new System.Windows.Forms.Button();
            this.buttonAddContractor = new System.Windows.Forms.Button();
            this.listViewContractors = new System.Windows.Forms.ListView();
            this.columnHeaderCoName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStreet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPostal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxContractors.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxContractors
            // 
            this.groupBoxContractors.Controls.Add(this.buttonChoose);
            this.groupBoxContractors.Controls.Add(this.buttonDeleteContractors);
            this.groupBoxContractors.Controls.Add(this.buttonEditContractos);
            this.groupBoxContractors.Controls.Add(this.buttonAddContractor);
            this.groupBoxContractors.Controls.Add(this.listViewContractors);
            this.groupBoxContractors.Location = new System.Drawing.Point(12, 12);
            this.groupBoxContractors.Name = "groupBoxContractors";
            this.groupBoxContractors.Size = new System.Drawing.Size(1078, 414);
            this.groupBoxContractors.TabIndex = 9;
            this.groupBoxContractors.TabStop = false;
            this.groupBoxContractors.Text = "Kontrahenci";
            // 
            // buttonChoose
            // 
            this.buttonChoose.Location = new System.Drawing.Point(991, 78);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(75, 58);
            this.buttonChoose.TabIndex = 4;
            this.buttonChoose.Text = "Wybierz";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // buttonDeleteContractors
            // 
            this.buttonDeleteContractors.Location = new System.Drawing.Point(991, 385);
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
            this.buttonAddContractor.Click += new System.EventHandler(this.buttonAddContractor_Click);
            // 
            // listViewContractors
            // 
            this.listViewContractors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCoName,
            this.columnHeaderName,
            this.columnHeaderType,
            this.columnHeaderCity,
            this.columnHeaderStreet,
            this.columnHeaderPostal});
            this.listViewContractors.FullRowSelect = true;
            this.listViewContractors.HideSelection = false;
            this.listViewContractors.Location = new System.Drawing.Point(12, 19);
            this.listViewContractors.MultiSelect = false;
            this.listViewContractors.Name = "listViewContractors";
            this.listViewContractors.Size = new System.Drawing.Size(973, 389);
            this.listViewContractors.TabIndex = 0;
            this.listViewContractors.UseCompatibleStateImageBehavior = false;
            this.listViewContractors.View = System.Windows.Forms.View.Details;
            this.listViewContractors.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.listViewContractors.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listViewContractors_KeyPress);
            this.listViewContractors.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeaderCoName
            // 
            this.columnHeaderCoName.Text = "Nazwa firmy";
            this.columnHeaderCoName.Width = 280;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Nazwa właściciela";
            this.columnHeaderName.Width = 280;
            // 
            // columnHeaderType
            // 
            this.columnHeaderType.Text = "Typ";
            this.columnHeaderType.Width = 80;
            // 
            // columnHeaderCity
            // 
            this.columnHeaderCity.Text = "Miejscowość";
            this.columnHeaderCity.Width = 100;
            // 
            // columnHeaderStreet
            // 
            this.columnHeaderStreet.Text = "Ulica";
            this.columnHeaderStreet.Width = 158;
            // 
            // columnHeaderPostal
            // 
            this.columnHeaderPostal.Text = "Kod";
            this.columnHeaderPostal.Width = 50;
            // 
            // ContractorChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 438);
            this.Controls.Add(this.groupBoxContractors);
            this.Name = "ContractorChoose";
            this.Text = "ContractorChoose";
            this.groupBoxContractors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxContractors;
        private System.Windows.Forms.Button buttonDeleteContractors;
        private System.Windows.Forms.Button buttonEditContractos;
        private System.Windows.Forms.Button buttonAddContractor;
        private System.Windows.Forms.ListView listViewContractors;
        private System.Windows.Forms.ColumnHeader columnHeaderCoName;
        private System.Windows.Forms.ColumnHeader columnHeaderCity;
        private System.Windows.Forms.ColumnHeader columnHeaderType;
        private System.Windows.Forms.ColumnHeader columnHeaderStreet;
        private System.Windows.Forms.ColumnHeader columnHeaderPostal;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.Button buttonChoose;
    }
}