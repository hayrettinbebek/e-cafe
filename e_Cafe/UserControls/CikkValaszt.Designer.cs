namespace e_Cafe
{
    partial class CikkValaszt
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstCikkcsoport = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstCikkcsoport
            // 
            this.lstCikkcsoport.FormattingEnabled = true;
            this.lstCikkcsoport.Location = new System.Drawing.Point(30, 19);
            this.lstCikkcsoport.Name = "lstCikkcsoport";
            this.lstCikkcsoport.Size = new System.Drawing.Size(434, 69);
            this.lstCikkcsoport.TabIndex = 0;
            // 
            // CikkValaszt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.lstCikkcsoport);
            this.Name = "CikkValaszt";
            this.Size = new System.Drawing.Size(575, 356);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCikkcsoport;
    }
}
