namespace e_Cafe
{
    partial class frmUjCikk
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtCikkszam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMegnevezes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdCikkcsop = new System.Windows.Forms.ComboBox();
            this.cIKKCSOPORTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eCAFEDataSet = new e_Cafe.SQL.ECAFEDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGyorskod = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEAN = new System.Windows.Forms.TextBox();
            this.txtSZJ = new System.Windows.Forms.TextBox();
            this.cmbDefRakt = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbOTF = new System.Windows.Forms.ComboBox();
            this.cIKCSOPOTHERFILTERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eCAFEDataSetOTHER_FILTER = new e_Cafe.SQL.ECAFEDataSetOTHER_FILTER();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMegjegyzes = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtOptKeszl = new System.Windows.Forms.TextBox();
            this.txtMinKeszl = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEladAr = new System.Windows.Forms.TextBox();
            this.cmdMe = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cIKKCSOPORTTableAdapter = new e_Cafe.SQL.ECAFEDataSetTableAdapters.CIKKCSOPORTTableAdapter();
            this.cIKCSOP_OTHER_FILTERTableAdapter = new e_Cafe.SQL.ECAFEDataSetOTHER_FILTERTableAdapters.CIKCSOP_OTHER_FILTERTableAdapter();
            this.cmbErtTip = new System.Windows.Forms.ComboBox();
            this.dynComboBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkOsszetett = new System.Windows.Forms.CheckBox();
            this.eCAFEDataSetMEGYS = new e_Cafe.SQL.ECAFEDataSetMEGYS();
            this.mEGYSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mEGYSTableAdapter = new e_Cafe.SQL.ECAFEDataSetMEGYSTableAdapters.MEGYSTableAdapter();
            this.eCAFEDataSetRAKTAR = new e_Cafe.SQL.ECAFEDataSetRAKTAR();
            this.rAKTARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rAKTARTableAdapter = new e_Cafe.SQL.ECAFEDataSetRAKTARTableAdapters.RAKTARTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cIKKCSOPORTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCAFEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIKCSOPOTHERFILTERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCAFEDataSetOTHER_FILTER)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dynComboBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCAFEDataSetMEGYS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEGYSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCAFEDataSetRAKTAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAKTARBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cikkszám";
            // 
            // txtCikkszam
            // 
            this.txtCikkszam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCikkszam.Location = new System.Drawing.Point(86, 32);
            this.txtCikkszam.Name = "txtCikkszam";
            this.txtCikkszam.Size = new System.Drawing.Size(123, 20);
            this.txtCikkszam.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 12;
            this.label1.Tag = "";
            this.label1.Text = "Megnevezés";
            // 
            // txtMegnevezes
            // 
            this.txtMegnevezes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMegnevezes.Location = new System.Drawing.Point(86, 6);
            this.txtMegnevezes.Name = "txtMegnevezes";
            this.txtMegnevezes.Size = new System.Drawing.Size(254, 20);
            this.txtMegnevezes.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 16;
            this.label2.Tag = "";
            this.label2.Text = "Cikkcsoport";
            // 
            // cmdCikkcsop
            // 
            this.cmdCikkcsop.DataSource = this.cIKKCSOPORTBindingSource;
            this.cmdCikkcsop.DisplayMember = "CIKKCSOPORT_NEV";
            this.cmdCikkcsop.FormattingEnabled = true;
            this.cmdCikkcsop.Location = new System.Drawing.Point(86, 58);
            this.cmdCikkcsop.Name = "cmdCikkcsop";
            this.cmdCikkcsop.Size = new System.Drawing.Size(123, 21);
            this.cmdCikkcsop.TabIndex = 15;
            this.cmdCikkcsop.ValueMember = "CIKKCSOPORT_ID";
            // 
            // cIKKCSOPORTBindingSource
            // 
            this.cIKKCSOPORTBindingSource.DataMember = "CIKKCSOPORT";
            this.cIKKCSOPORTBindingSource.DataSource = this.eCAFEDataSet;
            // 
            // eCAFEDataSet
            // 
            this.eCAFEDataSet.DataSetName = "ECAFEDataSet";
            this.eCAFEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Gyorskód";
            // 
            // txtGyorskod
            // 
            this.txtGyorskod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGyorskod.Location = new System.Drawing.Point(298, 33);
            this.txtGyorskod.Name = "txtGyorskod";
            this.txtGyorskod.Size = new System.Drawing.Size(123, 20);
            this.txtGyorskod.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "EAN kód";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "SZJ szám";
            // 
            // txtEAN
            // 
            this.txtEAN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEAN.Location = new System.Drawing.Point(298, 88);
            this.txtEAN.Name = "txtEAN";
            this.txtEAN.Size = new System.Drawing.Size(151, 20);
            this.txtEAN.TabIndex = 23;
            // 
            // txtSZJ
            // 
            this.txtSZJ.AcceptsReturn = true;
            this.txtSZJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSZJ.Location = new System.Drawing.Point(298, 59);
            this.txtSZJ.Name = "txtSZJ";
            this.txtSZJ.Size = new System.Drawing.Size(151, 20);
            this.txtSZJ.TabIndex = 24;
            // 
            // cmbDefRakt
            // 
            this.cmbDefRakt.DataSource = this.rAKTARBindingSource;
            this.cmbDefRakt.DisplayMember = "RAKTAR_KOD";
            this.cmbDefRakt.FormattingEnabled = true;
            this.cmbDefRakt.Location = new System.Drawing.Point(123, 19);
            this.cmbDefRakt.Name = "cmbDefRakt";
            this.cmbDefRakt.Size = new System.Drawing.Size(123, 21);
            this.cmbDefRakt.TabIndex = 22;
            this.cmbDefRakt.ValueMember = "RAKTAR_ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Alapértelmezett raktár";
            // 
            // cmbOTF
            // 
            this.cmbOTF.DataSource = this.cIKCSOPOTHERFILTERBindingSource;
            this.cmbOTF.DisplayMember = "OTHER_NAME";
            this.cmbOTF.FormattingEnabled = true;
            this.cmbOTF.Location = new System.Drawing.Point(86, 85);
            this.cmbOTF.Name = "cmbOTF";
            this.cmbOTF.Size = new System.Drawing.Size(123, 21);
            this.cmbOTF.TabIndex = 20;
            this.cmbOTF.ValueMember = "OTHER_FILTER_ID";
            // 
            // cIKCSOPOTHERFILTERBindingSource
            // 
            this.cIKCSOPOTHERFILTERBindingSource.DataMember = "CIKCSOP_OTHER_FILTER";
            this.cIKCSOPOTHERFILTERBindingSource.DataSource = this.eCAFEDataSetOTHER_FILTER;
            // 
            // eCAFEDataSetOTHER_FILTER
            // 
            this.eCAFEDataSetOTHER_FILTER.DataSetName = "ECAFEDataSetOTHER_FILTER";
            this.eCAFEDataSetOTHER_FILTER.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Alcsoport";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Megjegyzés";
            // 
            // txtMegjegyzes
            // 
            this.txtMegjegyzes.AcceptsReturn = true;
            this.txtMegjegyzes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMegjegyzes.Location = new System.Drawing.Point(86, 279);
            this.txtMegjegyzes.Multiline = true;
            this.txtMegjegyzes.Name = "txtMegjegyzes";
            this.txtMegjegyzes.Size = new System.Drawing.Size(363, 54);
            this.txtMegjegyzes.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtOptKeszl);
            this.groupBox1.Controls.Add(this.txtMinKeszl);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbDefRakt);
            this.groupBox1.Location = new System.Drawing.Point(10, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 86);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Készlet adatok";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Minimum készlet";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(245, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Optimális készlet";
            // 
            // txtOptKeszl
            // 
            this.txtOptKeszl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOptKeszl.Location = new System.Drawing.Point(335, 47);
            this.txtOptKeszl.Name = "txtOptKeszl";
            this.txtOptKeszl.Size = new System.Drawing.Size(92, 20);
            this.txtOptKeszl.TabIndex = 11;
            // 
            // txtMinKeszl
            // 
            this.txtMinKeszl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMinKeszl.Location = new System.Drawing.Point(123, 46);
            this.txtMinKeszl.Name = "txtMinKeszl";
            this.txtMinKeszl.Size = new System.Drawing.Size(92, 20);
            this.txtMinKeszl.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 247);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Eladási ár";
            // 
            // txtEladAr
            // 
            this.txtEladAr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEladAr.Location = new System.Drawing.Point(88, 244);
            this.txtEladAr.Name = "txtEladAr";
            this.txtEladAr.Size = new System.Drawing.Size(86, 20);
            this.txtEladAr.TabIndex = 30;
            // 
            // cmdMe
            // 
            this.cmdMe.DataSource = this.mEGYSBindingSource;
            this.cmdMe.DisplayMember = "MEGYS_MEGNEVEZES";
            this.cmdMe.FormattingEnabled = true;
            this.cmdMe.Location = new System.Drawing.Point(86, 112);
            this.cmdMe.Name = "cmdMe";
            this.cmdMe.Size = new System.Drawing.Size(76, 21);
            this.cmdMe.TabIndex = 20;
            this.cmdMe.ValueMember = "MEGYS_ID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Menny. egység";
            // 
            // cIKKCSOPORTTableAdapter
            // 
            this.cIKKCSOPORTTableAdapter.ClearBeforeFill = true;
            // 
            // cIKCSOP_OTHER_FILTERTableAdapter
            // 
            this.cIKCSOP_OTHER_FILTERTableAdapter.ClearBeforeFill = true;
            // 
            // cmbErtTip
            // 
            this.cmbErtTip.DataSource = this.dynComboBindingSource;
            this.cmbErtTip.DisplayMember = "DISPLAY_MEMBER";
            this.cmbErtTip.FormattingEnabled = true;
            this.cmbErtTip.Location = new System.Drawing.Point(326, 243);
            this.cmbErtTip.Name = "cmbErtTip";
            this.cmbErtTip.Size = new System.Drawing.Size(123, 21);
            this.cmbErtTip.TabIndex = 22;
            this.cmbErtTip.ValueMember = "VALUE_MEMBER";
            // 
            // dynComboBindingSource
            // 
            this.dynComboBindingSource.DataSource = typeof(BusinessLogic.DynCombo);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(228, 247);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Értékesítés módja";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(243, 339);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 33;
            this.button3.Text = "Mentés";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(162, 339);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Mégse";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkOsszetett
            // 
            this.chkOsszetett.AutoSize = true;
            this.chkOsszetett.Location = new System.Drawing.Point(346, 8);
            this.chkOsszetett.Name = "chkOsszetett";
            this.chkOsszetett.Size = new System.Drawing.Size(90, 17);
            this.chkOsszetett.TabIndex = 34;
            this.chkOsszetett.Text = "Összetet cikk";
            this.chkOsszetett.UseVisualStyleBackColor = true;
            // 
            // eCAFEDataSetMEGYS
            // 
            this.eCAFEDataSetMEGYS.DataSetName = "ECAFEDataSetMEGYS";
            this.eCAFEDataSetMEGYS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mEGYSBindingSource
            // 
            this.mEGYSBindingSource.DataMember = "MEGYS";
            this.mEGYSBindingSource.DataSource = this.eCAFEDataSetMEGYS;
            // 
            // mEGYSTableAdapter
            // 
            this.mEGYSTableAdapter.ClearBeforeFill = true;
            // 
            // eCAFEDataSetRAKTAR
            // 
            this.eCAFEDataSetRAKTAR.DataSetName = "ECAFEDataSetRAKTAR";
            this.eCAFEDataSetRAKTAR.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rAKTARBindingSource
            // 
            this.rAKTARBindingSource.DataMember = "RAKTAR";
            this.rAKTARBindingSource.DataSource = this.eCAFEDataSetRAKTAR;
            // 
            // rAKTARTableAdapter
            // 
            this.rAKTARTableAdapter.ClearBeforeFill = true;
            // 
            // frmUjCikk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 368);
            this.ControlBox = false;
            this.Controls.Add(this.chkOsszetett);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtEladAr);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMegjegyzes);
            this.Controls.Add(this.cmbErtTip);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEAN);
            this.Controls.Add(this.txtSZJ);
            this.Controls.Add(this.cmdMe);
            this.Controls.Add(this.cmbOTF);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGyorskod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdCikkcsop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCikkszam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMegnevezes);
            this.Name = "frmUjCikk";
            this.ShowInTaskbar = false;
            this.Text = "Új cikk rögzítése";
            this.Load += new System.EventHandler(this.frmUjCikk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cIKKCSOPORTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCAFEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIKCSOPOTHERFILTERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCAFEDataSetOTHER_FILTER)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dynComboBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCAFEDataSetMEGYS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEGYSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCAFEDataSetRAKTAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAKTARBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCikkszam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMegnevezes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmdCikkcsop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGyorskod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEAN;
        private System.Windows.Forms.TextBox txtSZJ;
        private System.Windows.Forms.ComboBox cmbDefRakt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbOTF;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMegjegyzes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtOptKeszl;
        private System.Windows.Forms.TextBox txtMinKeszl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEladAr;
        private System.Windows.Forms.ComboBox cmdMe;
        private System.Windows.Forms.Label label13;
        private e_Cafe.SQL.ECAFEDataSet eCAFEDataSet;
        private System.Windows.Forms.BindingSource cIKKCSOPORTBindingSource;
        private e_Cafe.SQL.ECAFEDataSetTableAdapters.CIKKCSOPORTTableAdapter cIKKCSOPORTTableAdapter;
        private e_Cafe.SQL.ECAFEDataSetOTHER_FILTER eCAFEDataSetOTHER_FILTER;
        private System.Windows.Forms.BindingSource cIKCSOPOTHERFILTERBindingSource;
        private e_Cafe.SQL.ECAFEDataSetOTHER_FILTERTableAdapters.CIKCSOP_OTHER_FILTERTableAdapter cIKCSOP_OTHER_FILTERTableAdapter;
        private System.Windows.Forms.ComboBox cmbErtTip;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkOsszetett;
        private System.Windows.Forms.BindingSource dynComboBindingSource;
        private e_Cafe.SQL.ECAFEDataSetMEGYS eCAFEDataSetMEGYS;
        private System.Windows.Forms.BindingSource mEGYSBindingSource;
        private e_Cafe.SQL.ECAFEDataSetMEGYSTableAdapters.MEGYSTableAdapter mEGYSTableAdapter;
        private e_Cafe.SQL.ECAFEDataSetRAKTAR eCAFEDataSetRAKTAR;
        private System.Windows.Forms.BindingSource rAKTARBindingSource;
        private e_Cafe.SQL.ECAFEDataSetRAKTARTableAdapters.RAKTARTableAdapter rAKTARTableAdapter;
    }
}