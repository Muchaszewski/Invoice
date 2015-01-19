namespace Faktury.Options
{
    partial class BackupMenu
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonRestoreGoogle = new System.Windows.Forms.Button();
            this.buttonNewGoogle = new System.Windows.Forms.Button();
            this.gropubox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRestoreLocal = new System.Windows.Forms.Button();
            this.buttonNewLocal = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.gropubox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader6,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 12);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(608, 425);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Lokalizacja";
            this.columnHeader7.Width = 71;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Data";
            this.columnHeader1.Width = 122;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Faktury";
            this.columnHeader2.Width = 51;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ostatni numer";
            this.columnHeader6.Width = 81;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Data modyfikacji";
            this.columnHeader3.Width = 116;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kontrahenci";
            this.columnHeader4.Width = 74;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Produkty";
            // 
            // buttonRestoreGoogle
            // 
            this.buttonRestoreGoogle.Location = new System.Drawing.Point(6, 19);
            this.buttonRestoreGoogle.Name = "buttonRestoreGoogle";
            this.buttonRestoreGoogle.Size = new System.Drawing.Size(156, 23);
            this.buttonRestoreGoogle.TabIndex = 1;
            this.buttonRestoreGoogle.Text = "Przywróć";
            this.buttonRestoreGoogle.UseVisualStyleBackColor = true;
            this.buttonRestoreGoogle.Click += new System.EventHandler(this.buttonRestoreGoogle_Click);
            // 
            // buttonNewGoogle
            // 
            this.buttonNewGoogle.Location = new System.Drawing.Point(6, 48);
            this.buttonNewGoogle.Name = "buttonNewGoogle";
            this.buttonNewGoogle.Size = new System.Drawing.Size(156, 63);
            this.buttonNewGoogle.TabIndex = 2;
            this.buttonNewGoogle.Text = "Utwórz nowy punkt przywracania";
            this.buttonNewGoogle.UseVisualStyleBackColor = true;
            this.buttonNewGoogle.Click += new System.EventHandler(this.buttonNewGoogle_Click);
            // 
            // gropubox
            // 
            this.gropubox.Controls.Add(this.buttonRestoreGoogle);
            this.gropubox.Controls.Add(this.buttonNewGoogle);
            this.gropubox.Location = new System.Drawing.Point(627, 12);
            this.gropubox.Name = "gropubox";
            this.gropubox.Size = new System.Drawing.Size(169, 119);
            this.gropubox.TabIndex = 3;
            this.gropubox.TabStop = false;
            this.gropubox.Text = "GoogleDrive";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonRestoreLocal);
            this.groupBox1.Controls.Add(this.buttonNewLocal);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(627, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 119);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lokalnie";
            // 
            // buttonRestoreLocal
            // 
            this.buttonRestoreLocal.Location = new System.Drawing.Point(6, 19);
            this.buttonRestoreLocal.Name = "buttonRestoreLocal";
            this.buttonRestoreLocal.Size = new System.Drawing.Size(156, 23);
            this.buttonRestoreLocal.TabIndex = 1;
            this.buttonRestoreLocal.Text = "Przywróć";
            this.buttonRestoreLocal.UseVisualStyleBackColor = true;
            // 
            // buttonNewLocal
            // 
            this.buttonNewLocal.Location = new System.Drawing.Point(6, 48);
            this.buttonNewLocal.Name = "buttonNewLocal";
            this.buttonNewLocal.Size = new System.Drawing.Size(156, 63);
            this.buttonNewLocal.TabIndex = 2;
            this.buttonNewLocal.Text = "Utwórz nowy punkt przywracania";
            this.buttonNewLocal.UseVisualStyleBackColor = true;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(633, 414);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 5;
            this.buttonRefresh.Text = "Odświerz";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonBack.Location = new System.Drawing.Point(714, 414);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "Wróć";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // BackupMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonBack;
            this.ClientSize = new System.Drawing.Size(808, 449);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gropubox);
            this.Controls.Add(this.listView1);
            this.Name = "BackupMenu";
            this.Text = "GoogleBackup";
            this.gropubox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button buttonRestoreGoogle;
        private System.Windows.Forms.Button buttonNewGoogle;
        private System.Windows.Forms.GroupBox gropubox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonRestoreLocal;
        private System.Windows.Forms.Button buttonNewLocal;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonBack;
    }
}