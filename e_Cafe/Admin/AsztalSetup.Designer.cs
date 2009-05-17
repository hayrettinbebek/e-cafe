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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbTipus = new System.Windows.Forms.ComboBox();
            this.dynComboBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nrRot = new System.Windows.Forms.NumericUpDown();
            this.rb180 = new System.Windows.Forms.RadioButton();
            this.rb270 = new System.Windows.Forms.RadioButton();
            this.rb90 = new System.Windows.Forms.RadioButton();
            this.rb0 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAsztalSzam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbHelyek = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlAsztalHelyek = new System.Windows.Forms.Panel();
            this.lblAktAsztalId = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dynComboBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrRot)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblAktAsztalId);
            this.panel1.Controls.Add(this.cmbTipus);
            this.panel1.Controls.Add(this.nrRot);
            this.panel1.Controls.Add(this.rb180);
            this.panel1.Controls.Add(this.rb270);
            this.panel1.Controls.Add(this.rb90);
            this.panel1.Controls.Add(this.rb0);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtAsztalSzam);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbHelyek);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(858, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 580);
            this.panel1.TabIndex = 0;
            // 
            // cmbTipus
            // 
            this.cmbTipus.DataSource = this.dynComboBindingSource;
            this.cmbTipus.DisplayMember = "DISPLAY_MEMBER";
            this.cmbTipus.FormattingEnabled = true;
            this.cmbTipus.Location = new System.Drawing.Point(6, 143);
            this.cmbTipus.Name = "cmbTipus";
            this.cmbTipus.Size = new System.Drawing.Size(100, 21);
            this.cmbTipus.TabIndex = 9;
            this.cmbTipus.ValueMember = "VALUE_MEMBER";
            // 
            // dynComboBindingSource
            // 
            this.dynComboBindingSource.DataSource = typeof(BusinessLogic.DynCombo);
            // 
            // nrRot
            // 
            this.nrRot.Location = new System.Drawing.Point(83, 120);
            this.nrRot.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nrRot.Name = "nrRot";
            this.nrRot.Size = new System.Drawing.Size(33, 20);
            this.nrRot.TabIndex = 8;
            this.nrRot.Visible = false;
            // 
            // rb180
            // 
            this.rb180.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb180.Location = new System.Drawing.Point(2, 279);
            this.rb180.Name = "rb180";
            this.rb180.Size = new System.Drawing.Size(40, 22);
            this.rb180.TabIndex = 7;
            this.rb180.TabStop = true;
            this.rb180.Tag = "2";
            this.rb180.Text = "180";
            this.rb180.UseVisualStyleBackColor = true;
            // 
            // rb270
            // 
            this.rb270.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb270.Location = new System.Drawing.Point(42, 296);
            this.rb270.Name = "rb270";
            this.rb270.Size = new System.Drawing.Size(40, 22);
            this.rb270.TabIndex = 7;
            this.rb270.TabStop = true;
            this.rb270.Tag = "2";
            this.rb270.Text = "270";
            this.rb270.UseVisualStyleBackColor = true;
            // 
            // rb90
            // 
            this.rb90.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb90.Location = new System.Drawing.Point(43, 261);
            this.rb90.Name = "rb90";
            this.rb90.Size = new System.Drawing.Size(40, 22);
            this.rb90.TabIndex = 7;
            this.rb90.TabStop = true;
            this.rb90.Tag = "2";
            this.rb90.Text = "90";
            this.rb90.UseVisualStyleBackColor = true;
            // 
            // rb0
            // 
            this.rb0.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb0.Location = new System.Drawing.Point(83, 279);
            this.rb0.Name = "rb0";
            this.rb0.Size = new System.Drawing.Size(42, 22);
            this.rb0.TabIndex = 7;
            this.rb0.TabStop = true;
            this.rb0.Tag = "2";
            this.rb0.Text = "0";
            this.rb0.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Forgatás";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Asztal szám:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Asztal tipus:";
            // 
            // txtAsztalSzam
            // 
            this.txtAsztalSzam.Location = new System.Drawing.Point(3, 197);
            this.txtAsztalSzam.Name = "txtAsztalSzam";
            this.txtAsztalSzam.Size = new System.Drawing.Size(100, 20);
            this.txtAsztalSzam.TabIndex = 4;
            this.txtAsztalSzam.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Szerkesztendő helyek:";
            // 
            // cmbHelyek
            // 
            this.cmbHelyek.FormattingEnabled = true;
            this.cmbHelyek.Location = new System.Drawing.Point(6, 25);
            this.cmbHelyek.Name = "cmbHelyek";
            this.cmbHelyek.Size = new System.Drawing.Size(111, 21);
            this.cmbHelyek.TabIndex = 2;
            this.cmbHelyek.SelectedIndexChanged += new System.EventHandler(this.cmbHelyek_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button3.Location = new System.Drawing.Point(67, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 20);
            this.button3.TabIndex = 1;
            this.button3.Text = "Töröl";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(10, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "Új";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(220)))), ((int)(((byte)(141)))));
            this.button2.Location = new System.Drawing.Point(10, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 20);
            this.button2.TabIndex = 1;
            this.button2.Text = "Mentés";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pnlAsztalHelyek
            // 
            this.pnlAsztalHelyek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAsztalHelyek.Location = new System.Drawing.Point(0, 0);
            this.pnlAsztalHelyek.Name = "pnlAsztalHelyek";
            this.pnlAsztalHelyek.Size = new System.Drawing.Size(858, 580);
            this.pnlAsztalHelyek.TabIndex = 1;
            // 
            // lblAktAsztalId
            // 
            this.lblAktAsztalId.AutoSize = true;
            this.lblAktAsztalId.Location = new System.Drawing.Point(6, 49);
            this.lblAktAsztalId.Name = "lblAktAsztalId";
            this.lblAktAsztalId.Size = new System.Drawing.Size(35, 13);
            this.lblAktAsztalId.TabIndex = 10;
            this.lblAktAsztalId.Text = "label5";
            this.lblAktAsztalId.Visible = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button4.Location = new System.Drawing.Point(75, 343);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 20);
            this.button4.TabIndex = 1;
            this.button4.Text = "Kilépés";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AsztalSetup_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dynComboBindingSource)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbTipus;
        private System.Windows.Forms.BindingSource dynComboBindingSource;
        private System.Windows.Forms.Label lblAktAsztalId;
        private System.Windows.Forms.Button button4;
    }
}