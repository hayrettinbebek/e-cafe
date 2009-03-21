namespace e_Cafe.Admin
{
    partial class frmKimentBlokkok
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
            this.cbEv = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbHonap = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNap = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbEv
            // 
            this.cbEv.FormattingEnabled = true;
            this.cbEv.Location = new System.Drawing.Point(38, 25);
            this.cbEv.Name = "cbEv";
            this.cbEv.Size = new System.Drawing.Size(63, 21);
            this.cbEv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Év";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lekérdezés adott könyvelési napra";
            // 
            // cbHonap
            // 
            this.cbHonap.FormattingEnabled = true;
            this.cbHonap.Location = new System.Drawing.Point(156, 25);
            this.cbHonap.Name = "cbHonap";
            this.cbHonap.Size = new System.Drawing.Size(63, 21);
            this.cbHonap.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hónap";
            // 
            // cbNap
            // 
            this.cbNap.FormattingEnabled = true;
            this.cbNap.Location = new System.Drawing.Point(270, 25);
            this.cbNap.Name = "cbNap";
            this.cbNap.Size = new System.Drawing.Size(63, 21);
            this.cbNap.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nap";
            // 
            // frmKimentBlokkok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 313);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbNap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbHonap);
            this.Controls.Add(this.cbEv);
            this.Name = "frmKimentBlokkok";
            this.Text = "Értékseítések listája";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbHonap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbNap;
        private System.Windows.Forms.Label label4;
    }
}