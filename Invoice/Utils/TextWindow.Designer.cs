namespace Faktury.Utils
{
    partial class TextWindow
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
            this.DialogText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DialogText
            // 
            this.DialogText.AutoSize = true;
            this.DialogText.Location = new System.Drawing.Point(12, 9);
            this.DialogText.Name = "DialogText";
            this.DialogText.Size = new System.Drawing.Size(78, 13);
            this.DialogText.TabIndex = 0;
            this.DialogText.Text = "Text undefined";
            // 
            // TextWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 42);
            this.ControlBox = false;
            this.Controls.Add(this.DialogText);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TextWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TextWindow";
            this.Load += new System.EventHandler(this.TextWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label DialogText;

    }
}