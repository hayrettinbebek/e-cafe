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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsztalSetup));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb270 = new System.Windows.Forms.RadioButton();
            this.rb0 = new System.Windows.Forms.RadioButton();
            this.rb90 = new System.Windows.Forms.RadioButton();
            this.rb180 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.chkRendelFel = new System.Windows.Forms.CheckBox();
            this.chkNameVis = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblAktAsztalId = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dynComboBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbHelyek = new System.Windows.Forms.ComboBox();
            this.nrRot = new System.Windows.Forms.NumericUpDown();
            this.txtAsztalSzam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlAsztalHelyek = new System.Windows.Forms.Panel();
            this.icmbTipus = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.ilLogin = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dynComboBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrRot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icmbTipus.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(852, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 580);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb270);
            this.groupBox1.Controls.Add(this.rb0);
            this.groupBox1.Controls.Add(this.rb90);
            this.groupBox1.Controls.Add(this.rb180);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forgatás";
            // 
            // rb270
            // 
            this.rb270.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb270.Location = new System.Drawing.Point(41, 56);
            this.rb270.Name = "rb270";
            this.rb270.Size = new System.Drawing.Size(40, 22);
            this.rb270.TabIndex = 7;
            this.rb270.TabStop = true;
            this.rb270.Tag = "2";
            this.rb270.Text = "270";
            this.rb270.UseVisualStyleBackColor = true;
            // 
            // rb0
            // 
            this.rb0.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb0.Location = new System.Drawing.Point(82, 39);
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
            this.rb90.Location = new System.Drawing.Point(42, 21);
            this.rb90.Name = "rb90";
            this.rb90.Size = new System.Drawing.Size(40, 22);
            this.rb90.TabIndex = 7;
            this.rb90.TabStop = true;
            this.rb90.Tag = "2";
            this.rb90.Text = "90";
            this.rb90.UseVisualStyleBackColor = true;
            // 
            // rb180
            // 
            this.rb180.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb180.Location = new System.Drawing.Point(1, 39);
            this.rb180.Name = "rb180";
            this.rb180.Size = new System.Drawing.Size(40, 22);
            this.rb180.TabIndex = 7;
            this.rb180.TabStop = true;
            this.rb180.Tag = "2";
            this.rb180.Text = "180";
            this.rb180.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.icmbTipus);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.chkRendelFel);
            this.panel2.Controls.Add(this.chkNameVis);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.lblAktAsztalId);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.cmbHelyek);
            this.panel2.Controls.Add(this.nrRot);
            this.panel2.Controls.Add(this.txtAsztalSzam);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(136, 325);
            this.panel2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Szerkesztendő helyek:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(220)))), ((int)(((byte)(141)))));
            this.button2.Location = new System.Drawing.Point(5, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 20);
            this.button2.TabIndex = 1;
            this.button2.Text = "Mentés / Frissítés";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button4.Location = new System.Drawing.Point(74, 279);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 20);
            this.button4.TabIndex = 1;
            this.button4.Text = "Kilépés";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // chkRendelFel
            // 
            this.chkRendelFel.AutoSize = true;
            this.chkRendelFel.Location = new System.Drawing.Point(5, 256);
            this.chkRendelFel.Name = "chkRendelFel";
            this.chkRendelFel.Size = new System.Drawing.Size(114, 17);
            this.chkRendelFel.TabIndex = 11;
            this.chkRendelFel.Text = "Rendelés felvihető";
            this.chkRendelFel.UseVisualStyleBackColor = true;
            // 
            // chkNameVis
            // 
            this.chkNameVis.AutoSize = true;
            this.chkNameVis.Location = new System.Drawing.Point(6, 233);
            this.chkNameVis.Name = "chkNameVis";
            this.chkNameVis.Size = new System.Drawing.Size(78, 17);
            this.chkNameVis.TabIndex = 11;
            this.chkNameVis.Text = "Név látszik";
            this.chkNameVis.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(5, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "Új";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAktAsztalId
            // 
            this.lblAktAsztalId.AutoSize = true;
            this.lblAktAsztalId.Location = new System.Drawing.Point(5, 49);
            this.lblAktAsztalId.Name = "lblAktAsztalId";
            this.lblAktAsztalId.Size = new System.Drawing.Size(35, 13);
            this.lblAktAsztalId.TabIndex = 10;
            this.lblAktAsztalId.Text = "label5";
            this.lblAktAsztalId.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button3.Location = new System.Drawing.Point(62, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 20);
            this.button3.TabIndex = 1;
            this.button3.Text = "Töröl";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dynComboBindingSource
            // 
            this.dynComboBindingSource.DataSource = typeof(BusinessLogic.DynCombo);
            // 
            // cmbHelyek
            // 
            this.cmbHelyek.FormattingEnabled = true;
            this.cmbHelyek.Location = new System.Drawing.Point(5, 25);
            this.cmbHelyek.Name = "cmbHelyek";
            this.cmbHelyek.Size = new System.Drawing.Size(111, 21);
            this.cmbHelyek.TabIndex = 2;
            this.cmbHelyek.SelectedIndexChanged += new System.EventHandler(this.cmbHelyek_SelectedIndexChanged);
            // 
            // nrRot
            // 
            this.nrRot.Location = new System.Drawing.Point(86, 120);
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
            // txtAsztalSzam
            // 
            this.txtAsztalSzam.Location = new System.Drawing.Point(5, 207);
            this.txtAsztalSzam.Name = "txtAsztalSzam";
            this.txtAsztalSzam.Size = new System.Drawing.Size(100, 20);
            this.txtAsztalSzam.TabIndex = 4;
            this.txtAsztalSzam.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Asztal szám:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Asztal tipus:";
            // 
            // pnlAsztalHelyek
            // 
            this.pnlAsztalHelyek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAsztalHelyek.Location = new System.Drawing.Point(0, 0);
            this.pnlAsztalHelyek.Name = "pnlAsztalHelyek";
            this.pnlAsztalHelyek.Size = new System.Drawing.Size(852, 580);
            this.pnlAsztalHelyek.TabIndex = 1;
            // 
            // icmbTipus
            // 
            this.icmbTipus.Location = new System.Drawing.Point(6, 143);
            this.icmbTipus.Name = "icmbTipus";
            this.icmbTipus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icmbTipus.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 11, 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 12, 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 13, 2),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 14, 3),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 15, 4),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 16, 5),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 17, 6),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 18, 7),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 19, 8),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 20, 9),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 21, 10),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 97, 11),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 98, 12),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 99, 13)});
            this.icmbTipus.Properties.SmallImages = this.ilLogin;
            this.icmbTipus.Size = new System.Drawing.Size(94, 47);
            this.icmbTipus.TabIndex = 12;
            // 
            // ilLogin
            // 
            this.ilLogin.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilLogin.ImageStream")));
            this.ilLogin.TransparentColor = System.Drawing.Color.Transparent;
            this.ilLogin.Images.SetKeyName(0, "11");
            this.ilLogin.Images.SetKeyName(1, "12");
            this.ilLogin.Images.SetKeyName(2, "13");
            this.ilLogin.Images.SetKeyName(3, "14");
            this.ilLogin.Images.SetKeyName(4, "15");
            this.ilLogin.Images.SetKeyName(5, "16");
            this.ilLogin.Images.SetKeyName(6, "17");
            this.ilLogin.Images.SetKeyName(7, "18");
            this.ilLogin.Images.SetKeyName(8, "19");
            this.ilLogin.Images.SetKeyName(9, "20");
            this.ilLogin.Images.SetKeyName(10, "21");
            this.ilLogin.Images.SetKeyName(11, "97");
            this.ilLogin.Images.SetKeyName(12, "98");
            this.ilLogin.Images.SetKeyName(13, "99");
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
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dynComboBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrRot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icmbTipus.Properties)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton rb0;
        private System.Windows.Forms.RadioButton rb180;
        private System.Windows.Forms.RadioButton rb270;
        private System.Windows.Forms.RadioButton rb90;
        private System.Windows.Forms.NumericUpDown nrRot;
        private System.Windows.Forms.BindingSource dynComboBindingSource;
        private System.Windows.Forms.Label lblAktAsztalId;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox chkNameVis;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkRendelFel;
        private DevExpress.XtraEditors.ImageComboBoxEdit icmbTipus;
        private System.Windows.Forms.ImageList ilLogin;
    }
}