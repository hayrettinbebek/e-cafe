namespace e_Cafe
{
    partial class AsztalSetup
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAktAsztalId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAsztalSzam = new System.Windows.Forms.TextBox();
            this.txtAsztalTipus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbHelyek = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlAsztalHelyek = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.nrRot = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrRot)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nrRot);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblAktAsztalId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtAsztalSzam);
            this.panel1.Controls.Add(this.txtAsztalTipus);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbHelyek);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 70);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(735, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Asztal szám:";
            // 
            // lblAktAsztalId
            // 
            this.lblAktAsztalId.AutoSize = true;
            this.lblAktAsztalId.Location = new System.Drawing.Point(395, 34);
            this.lblAktAsztalId.Name = "lblAktAsztalId";
            this.lblAktAsztalId.Size = new System.Drawing.Size(63, 13);
            this.lblAktAsztalId.TabIndex = 5;
            this.lblAktAsztalId.Text = "Asztal tipus:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(545, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Asztal tipus:";
            // 
            // txtAsztalSzam
            // 
            this.txtAsztalSzam.Location = new System.Drawing.Point(804, 12);
            this.txtAsztalSzam.Name = "txtAsztalSzam";
            this.txtAsztalSzam.Size = new System.Drawing.Size(100, 20);
            this.txtAsztalSzam.TabIndex = 4;
            // 
            // txtAsztalTipus
            // 
            this.txtAsztalTipus.Location = new System.Drawing.Point(614, 12);
            this.txtAsztalTipus.Name = "txtAsztalTipus";
            this.txtAsztalTipus.Size = new System.Drawing.Size(100, 20);
            this.txtAsztalTipus.TabIndex = 4;
            this.txtAsztalTipus.TextChanged += new System.EventHandler(this.txtAsztalTipus_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Szerkesztendő helyek:";
            // 
            // cmbHelyek
            // 
            this.cmbHelyek.FormattingEnabled = true;
            this.cmbHelyek.Location = new System.Drawing.Point(132, 11);
            this.cmbHelyek.Name = "cmbHelyek";
            this.cmbHelyek.Size = new System.Drawing.Size(199, 21);
            this.cmbHelyek.TabIndex = 2;
            this.cmbHelyek.SelectedIndexChanged += new System.EventHandler(this.cmbHelyek_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button2.Location = new System.Drawing.Point(358, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 20);
            this.button2.TabIndex = 1;
            this.button2.Text = "Mentés";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pnlAsztalHelyek
            // 
            this.pnlAsztalHelyek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAsztalHelyek.Location = new System.Drawing.Point(0, 70);
            this.pnlAsztalHelyek.Name = "pnlAsztalHelyek";
            this.pnlAsztalHelyek.Size = new System.Drawing.Size(988, 510);
            this.pnlAsztalHelyek.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(675, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Forgatás (0,90,180, 270)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // nrRot
            // 
            this.nrRot.Location = new System.Drawing.Point(804, 34);
            this.nrRot.Name = "nrRot";
            this.nrRot.Size = new System.Drawing.Size(65, 20);
            this.nrRot.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(67, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "Új";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button2_Click);
            // 
            // AsztalSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 580);
            this.Controls.Add(this.pnlAsztalHelyek);
            this.Controls.Add(this.panel1);
            this.Name = "AsztalSetup";
            this.Text = "Asztalok elrendezése";
            this.Load += new System.EventHandler(this.AsztalSetup_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrRot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnlAsztalHelyek;
        private System.Windows.Forms.ComboBox cmbHelyek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAsztalTipus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAsztalSzam;
        private System.Windows.Forms.Label lblAktAsztalId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nrRot;
        private System.Windows.Forms.Button button1;
    }
}