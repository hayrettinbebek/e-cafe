namespace e_Cafe
{
    partial class frmBevetelSor
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblCikk = new System.Windows.Forms.Label();
            this.txtMenny = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEgys = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMegj = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cikk választás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCikk
            // 
            this.lblCikk.AutoSize = true;
            this.lblCikk.Location = new System.Drawing.Point(112, 8);
            this.lblCikk.Name = "lblCikk";
            this.lblCikk.Size = new System.Drawing.Size(35, 13);
            this.lblCikk.TabIndex = 1;
            this.lblCikk.Text = "label1";
            // 
            // txtMenny
            // 
            this.txtMenny.Location = new System.Drawing.Point(76, 35);
            this.txtMenny.Name = "txtMenny";
            this.txtMenny.Size = new System.Drawing.Size(59, 20);
            this.txtMenny.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mennyiség";
            // 
            // txtEgys
            // 
            this.txtEgys.Location = new System.Drawing.Point(205, 38);
            this.txtEgys.Name = "txtEgys";
            this.txtEgys.Size = new System.Drawing.Size(72, 20);
            this.txtEgys.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Egységár";
            // 
            // txtMegj
            // 
            this.txtMegj.Location = new System.Drawing.Point(12, 86);
            this.txtMegj.Name = "txtMegj";
            this.txtMegj.Size = new System.Drawing.Size(265, 20);
            this.txtMegj.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Megjegyzés";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Felvisz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmBevetelSor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 172);
            this.Controls.Add(this.txtMegj);
            this.Controls.Add(this.txtEgys);
            this.Controls.Add(this.txtMenny);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCikk);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frmBevetelSor";
            this.Text = "frmBevetelSor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCikk;
        private System.Windows.Forms.TextBox txtMenny;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEgys;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMegj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}