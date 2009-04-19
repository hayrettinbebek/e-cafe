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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAsztalSzam = new System.Windows.Forms.TextBox();
            this.txtAsztalTipus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbHelyek = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlAsztalHelyek = new System.Windows.Forms.Panel();
            this.rb0 = new System.Windows.Forms.RadioButton();
            this.rb90 = new System.Windows.Forms.RadioButton();
            this.rb270 = new System.Windows.Forms.RadioButton();
            this.rb180 = new System.Windows.Forms.RadioButton();
            this.nrRot = new System.Windows.Forms.NumericUpDown();
            this.lblAktAsztalId = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrRot)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nrRot);
            this.panel1.Controls.Add(this.rb180);
            this.panel1.Controls.Add(this.rb270);
            this.panel1.Controls.Add(this.rb90);
            this.panel1.Controls.Add(this.rb0);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblAktAsztalId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtAsztalSzam);
            this.panel1.Controls.Add(this.txtAsztalTipus);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbHelyek);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 87);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(806, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Forgatás";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(545, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Asztal szám:";
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
            this.txtAsztalSzam.Location = new System.Drawing.Point(614, 34);
            this.txtAsztalSzam.Name = "txtAsztalSzam";
            this.txtAsztalSzam.Size = new System.Drawing.Size(100, 20);
            this.txtAsztalSzam.TabIndex = 4;
            this.txtAsztalSzam.Text = "0";
            // 
            // txtAsztalTipus
            // 
            this.txtAsztalTipus.Location = new System.Drawing.Point(614, 12);
            this.txtAsztalTipus.Name = "txtAsztalTipus";
            this.txtAsztalTipus.Size = new System.Drawing.Size(100, 20);
            this.txtAsztalTipus.TabIndex = 4;
            this.txtAsztalTipus.Text = "0";
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
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button3.Location = new System.Drawing.Point(141, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 20);
            this.button3.TabIndex = 1;
            this.button3.Text = "Töröl";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(44, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "Új";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(220)))), ((int)(((byte)(141)))));
            this.button2.Location = new System.Drawing.Point(386, 52);
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
            this.pnlAsztalHelyek.Location = new System.Drawing.Point(0, 87);
            this.pnlAsztalHelyek.Name = "pnlAsztalHelyek";
            this.pnlAsztalHelyek.Size = new System.Drawing.Size(988, 493);
            this.pnlAsztalHelyek.TabIndex = 1;
            // 
            // rb0
            // 
            this.rb0.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb0.Location = new System.Drawing.Point(934, 27);
            this.rb0.Name = "rb0";
            this.rb0.Size = new System.Drawing.Size(42, 22);
            this.rb0.TabIndex = 7;
            this.rb0.TabStop = true;
            this.rb0.Tag = "2";
            this.rb0.Text = "0";
            this.rb0.UseVisualStyleBackColor = true;
            // 
            // rb90
            // 
            this.rb90.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb90.Location = new System.Drawing.Point(894, 9);
            this.rb90.Name = "rb90";
            this.rb90.Size = new System.Drawing.Size(40, 22);
            this.rb90.TabIndex = 7;
            this.rb90.TabStop = true;
            this.rb90.Tag = "2";
            this.rb90.Text = "90";
            this.rb90.UseVisualStyleBackColor = true;
            // 
            // rb270
            // 
            this.rb270.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb270.Location = new System.Drawing.Point(893, 44);
            this.rb270.Name = "rb270";
            this.rb270.Size = new System.Drawing.Size(40, 22);
            this.rb270.TabIndex = 7;
            this.rb270.TabStop = true;
            this.rb270.Tag = "2";
            this.rb270.Text = "270";
            this.rb270.UseVisualStyleBackColor = true;
            // 
            // rb180
            // 
            this.rb180.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb180.Location = new System.Drawing.Point(853, 27);
            this.rb180.Name = "rb180";
            this.rb180.Size = new System.Drawing.Size(40, 22);
            this.rb180.TabIndex = 7;
            this.rb180.TabStop = true;
            this.rb180.Tag = "2";
            this.rb180.Text = "180";
            this.rb180.UseVisualStyleBackColor = true;
            // 
            // nrRot
            // 
            this.nrRot.Location = new System.Drawing.Point(766, 34);
            this.nrRot.Name = "nrRot";
            this.nrRot.Size = new System.Drawing.Size(33, 20);
            this.nrRot.TabIndex = 8;
            // 
            // lblAktAsztalId
            // 
            this.lblAktAsztalId.AutoSize = true;
            this.lblAktAsztalId.Location = new System.Drawing.Point(23, 67);
            this.lblAktAsztalId.Name = "lblAktAsztalId";
            this.lblAktAsztalId.Size = new System.Drawing.Size(63, 13);
            this.lblAktAsztalId.TabIndex = 5;
            this.lblAktAsztalId.Text = "Asztal tipus:";
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton rb0;
        private System.Windows.Forms.RadioButton rb180;
        private System.Windows.Forms.RadioButton rb270;
        private System.Windows.Forms.RadioButton rb90;
        private System.Windows.Forms.NumericUpDown nrRot;
        private System.Windows.Forms.Label lblAktAsztalId;
    }
}