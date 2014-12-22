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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.buttonDeleteContractors = new System.Windows.Forms.Button();
            this.buttonEditContractos = new System.Windows.Forms.Button();
            this.buttonAddContractor = new System.Windows.Forms.Button();
            this.listViewContractors = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonChoose);
            this.groupBox2.Controls.Add(this.buttonDeleteContractors);
            this.groupBox2.Controls.Add(this.buttonEditContractos);
            this.groupBox2.Controls.Add(this.buttonAddContractor);
            this.groupBox2.Controls.Add(this.listViewContractors);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1078, 414);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kontrahenci";
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
            this.columnHeader8,
            this.columnHeader15,
            this.columnHeader9,
            this.columnHeader13,
            this.columnHeader10,
            this.columnHeader11});
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
            // columnHeader8
            // 
            this.columnHeader8.Text = "Nazwa firmy";
            this.columnHeader8.Width = 280;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Nazwa właściciela";
            this.columnHeader15.Width = 280;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Typ";
            this.columnHeader9.Width = 80;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Miejscowość";
            this.columnHeader13.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Ulica";
            this.columnHeader10.Width = 158;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Kod";
            this.columnHeader11.Width = 50;
            // 
            // ContractorChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 438);
            this.Controls.Add(this.groupBox2);
            this.Name = "ContractorChoose";
            this.Text = "ContractorChoose";
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonDeleteContractors;
        private System.Windows.Forms.Button buttonEditContractos;
        private System.Windows.Forms.Button buttonAddContractor;
        private System.Windows.Forms.ListView listViewContractors;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.Button buttonChoose;
    }
}