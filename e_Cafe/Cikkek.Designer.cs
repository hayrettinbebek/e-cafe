namespace e_Cafe
{
    partial class Cikkek
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
            System.Windows.Forms.TabPage tbAlap;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cikkek));
            this.chkOsszetett = new System.Windows.Forms.CheckBox();
            this.cikkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.raktarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCikkcsop = new System.Windows.Forms.ComboBox();
            this.cikkcsoportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.ertTipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.oTFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fKESZLETDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKESZLETALLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEGNEVEZESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIKKCSOPORTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbKiszereles = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lITKISZIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lITKISZCIKKIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lITKISZNEVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lITKISZMENNYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cikkKiszerelesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbKeszlet = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tbOsszetett = new System.Windows.Forms.TabPage();
            tbAlap = new System.Windows.Forms.TabPage();
            tbAlap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cikkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raktarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cikkcsoportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ertTipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oTFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbKiszereles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cikkKiszerelesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbAlap
            // 
            tbAlap.Controls.Add(this.chkOsszetett);
            tbAlap.Controls.Add(this.label1);
            tbAlap.Controls.Add(this.textBox1);
            tbAlap.Controls.Add(this.label5);
            tbAlap.Controls.Add(this.comboBox1);
            tbAlap.Controls.Add(this.label2);
            tbAlap.Controls.Add(this.cmbCikkcsop);
            tbAlap.Controls.Add(this.label4);
            tbAlap.Controls.Add(this.comboBox2);
            tbAlap.Controls.Add(this.comboBox3);
            tbAlap.Controls.Add(this.label3);
            tbAlap.Location = new System.Drawing.Point(4, 22);
            tbAlap.Name = "tbAlap";
            tbAlap.Padding = new System.Windows.Forms.Padding(3);
            tbAlap.Size = new System.Drawing.Size(1008, 356);
            tbAlap.TabIndex = 0;
            tbAlap.Text = "Alapadatok";
            tbAlap.UseVisualStyleBackColor = true;
            // 
            // chkOsszetett
            // 
            this.chkOsszetett.AutoSize = true;
            this.chkOsszetett.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.cikkBindingSource, "OSSZETETT", true));
            this.chkOsszetett.Location = new System.Drawing.Point(334, 11);
            this.chkOsszetett.Name = "chkOsszetett";
            this.chkOsszetett.Size = new System.Drawing.Size(93, 17);
            this.chkOsszetett.TabIndex = 17;
            this.chkOsszetett.Text = "Összetett cikk";
            this.chkOsszetett.UseVisualStyleBackColor = true;
            this.chkOsszetett.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cikkBindingSource
            // 
            this.cikkBindingSource.DataSource = typeof(BusinessLogic.Cikk);
            this.cikkBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.cikkBindingSource_AddingNew);
            this.cikkBindingSource.PositionChanged += new System.EventHandler(this.cikkBindingSource_PositionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Megnevezés";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cikkBindingSource, "MEGNEVEZES", true));
            this.textBox1.Location = new System.Drawing.Point(133, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Alapértelmezett raktár";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cikkBindingSource, "ALAP_RAKTAR", true));
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.raktarBindingSource, "KOD", true));
            this.comboBox1.DataSource = this.raktarBindingSource;
            this.comboBox1.DisplayMember = "KOD";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(133, 94);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.ValueMember = "ID";
            // 
            // raktarBindingSource
            // 
            this.raktarBindingSource.DataSource = typeof(BusinessLogic.Raktar);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cikkcsoport";
            // 
            // cmbCikkcsop
            // 
            this.cmbCikkcsop.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cikkBindingSource, "CIKKCSOPORT_ID", true));
            this.cmbCikkcsop.DataSource = this.cikkcsoportBindingSource;
            this.cmbCikkcsop.DisplayMember = "NEV";
            this.cmbCikkcsop.FormattingEnabled = true;
            this.cmbCikkcsop.Location = new System.Drawing.Point(133, 39);
            this.cmbCikkcsop.Name = "cmbCikkcsop";
            this.cmbCikkcsop.Size = new System.Drawing.Size(132, 21);
            this.cmbCikkcsop.TabIndex = 5;
            this.cmbCikkcsop.ValueMember = "ID";
            // 
            // cikkcsoportBindingSource
            // 
            this.cikkcsoportBindingSource.DataSource = typeof(BusinessLogic.Cikkcsoport);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Alcsoport";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cikkBindingSource, "ERTEKESITES_TIPUSA", true));
            this.comboBox2.DataSource = this.ertTipBindingSource;
            this.comboBox2.DisplayMember = "NEV";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(133, 66);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.ValueMember = "KOD";
            // 
            // ertTipBindingSource
            // 
            this.ertTipBindingSource.DataSource = typeof(BusinessLogic.ertTip);
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.oTFBindingSource, "OID", true));
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oTFBindingSource, "ONEV", true));
            this.comboBox3.DataSource = this.oTFBindingSource;
            this.comboBox3.DisplayMember = "ONEV";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(334, 39);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(84, 21);
            this.comboBox3.TabIndex = 10;
            this.comboBox3.ValueMember = "OID";
            // 
            // oTFBindingSource
            // 
            this.oTFBindingSource.DataSource = typeof(BusinessLogic.OTF);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Értékesítés típusa:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fKESZLETDataGridViewTextBoxColumn,
            this.fKESZLETALLDataGridViewTextBoxColumn,
            this.mEGNEVEZESDataGridViewTextBoxColumn,
            this.cIKKCSOPORTIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cikkBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1016, 334);
            this.dataGridView1.TabIndex = 0;
            // 
            // fKESZLETDataGridViewTextBoxColumn
            // 
            this.fKESZLETDataGridViewTextBoxColumn.DataPropertyName = "fKESZLET";
            this.fKESZLETDataGridViewTextBoxColumn.HeaderText = "fKESZLET";
            this.fKESZLETDataGridViewTextBoxColumn.Name = "fKESZLETDataGridViewTextBoxColumn";
            this.fKESZLETDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fKESZLETALLDataGridViewTextBoxColumn
            // 
            this.fKESZLETALLDataGridViewTextBoxColumn.DataPropertyName = "fKESZLET_ALL";
            this.fKESZLETALLDataGridViewTextBoxColumn.HeaderText = "fKESZLET_ALL";
            this.fKESZLETALLDataGridViewTextBoxColumn.Name = "fKESZLETALLDataGridViewTextBoxColumn";
            this.fKESZLETALLDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mEGNEVEZESDataGridViewTextBoxColumn
            // 
            this.mEGNEVEZESDataGridViewTextBoxColumn.DataPropertyName = "MEGNEVEZES";
            this.mEGNEVEZESDataGridViewTextBoxColumn.HeaderText = "MEGNEVEZES";
            this.mEGNEVEZESDataGridViewTextBoxColumn.Name = "mEGNEVEZESDataGridViewTextBoxColumn";
            // 
            // cIKKCSOPORTIDDataGridViewTextBoxColumn
            // 
            this.cIKKCSOPORTIDDataGridViewTextBoxColumn.DataPropertyName = "CIKKCSOPORT_ID";
            this.cIKKCSOPORTIDDataGridViewTextBoxColumn.HeaderText = "CIKKCSOPORT_ID";
            this.cIKKCSOPORTIDDataGridViewTextBoxColumn.Name = "cIKKCSOPORTIDDataGridViewTextBoxColumn";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1016, 25);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(46, 22);
            this.toolStripButton1.Text = "Mentés";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(tbAlap);
            this.tabControl1.Controls.Add(this.tbKiszereles);
            this.tabControl1.Controls.Add(this.tbKeszlet);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tbOsszetett);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 359);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1016, 382);
            this.tabControl1.TabIndex = 15;
            // 
            // tbKiszereles
            // 
            this.tbKiszereles.Controls.Add(this.dataGridView2);
            this.tbKiszereles.Location = new System.Drawing.Point(4, 22);
            this.tbKiszereles.Name = "tbKiszereles";
            this.tbKiszereles.Padding = new System.Windows.Forms.Padding(3);
            this.tbKiszereles.Size = new System.Drawing.Size(1008, 356);
            this.tbKiszereles.TabIndex = 2;
            this.tbKiszereles.Text = "Kiszerelések";
            this.tbKiszereles.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lITKISZIDDataGridViewTextBoxColumn,
            this.lITKISZCIKKIDDataGridViewTextBoxColumn,
            this.lITKISZNEVDataGridViewTextBoxColumn,
            this.lITKISZMENNYDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.cikkKiszerelesBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1002, 350);
            this.dataGridView2.TabIndex = 0;
            // 
            // lITKISZIDDataGridViewTextBoxColumn
            // 
            this.lITKISZIDDataGridViewTextBoxColumn.DataPropertyName = "LIT_KISZ_ID";
            this.lITKISZIDDataGridViewTextBoxColumn.HeaderText = "LIT_KISZ_ID";
            this.lITKISZIDDataGridViewTextBoxColumn.Name = "lITKISZIDDataGridViewTextBoxColumn";
            this.lITKISZIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // lITKISZCIKKIDDataGridViewTextBoxColumn
            // 
            this.lITKISZCIKKIDDataGridViewTextBoxColumn.DataPropertyName = "LIT_KISZ_CIKK_ID";
            this.lITKISZCIKKIDDataGridViewTextBoxColumn.HeaderText = "LIT_KISZ_CIKK_ID";
            this.lITKISZCIKKIDDataGridViewTextBoxColumn.Name = "lITKISZCIKKIDDataGridViewTextBoxColumn";
            this.lITKISZCIKKIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // lITKISZNEVDataGridViewTextBoxColumn
            // 
            this.lITKISZNEVDataGridViewTextBoxColumn.DataPropertyName = "LIT_KISZ_NEV";
            this.lITKISZNEVDataGridViewTextBoxColumn.HeaderText = "Megnevezés";
            this.lITKISZNEVDataGridViewTextBoxColumn.Name = "lITKISZNEVDataGridViewTextBoxColumn";
            this.lITKISZNEVDataGridViewTextBoxColumn.Width = 200;
            // 
            // lITKISZMENNYDataGridViewTextBoxColumn
            // 
            this.lITKISZMENNYDataGridViewTextBoxColumn.DataPropertyName = "LIT_KISZ_MENNY";
            this.lITKISZMENNYDataGridViewTextBoxColumn.HeaderText = "Mennyisége (literben)";
            this.lITKISZMENNYDataGridViewTextBoxColumn.Name = "lITKISZMENNYDataGridViewTextBoxColumn";
            this.lITKISZMENNYDataGridViewTextBoxColumn.Width = 160;
            // 
            // cikkKiszerelesBindingSource
            // 
            this.cikkKiszerelesBindingSource.AllowNew = true;
            this.cikkKiszerelesBindingSource.DataSource = typeof(BusinessLogic.CikkKiszereles);
            this.cikkKiszerelesBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.cikkKiszerelesBindingSource_AddingNew);
            // 
            // tbKeszlet
            // 
            this.tbKeszlet.Location = new System.Drawing.Point(4, 22);
            this.tbKeszlet.Name = "tbKeszlet";
            this.tbKeszlet.Padding = new System.Windows.Forms.Padding(3);
            this.tbKeszlet.Size = new System.Drawing.Size(1008, 356);
            this.tbKeszlet.TabIndex = 3;
            this.tbKeszlet.Text = "Készletek";
            this.tbKeszlet.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1008, 356);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tbOsszetett
            // 
            this.tbOsszetett.Location = new System.Drawing.Point(4, 22);
            this.tbOsszetett.Name = "tbOsszetett";
            this.tbOsszetett.Padding = new System.Windows.Forms.Padding(3);
            this.tbOsszetett.Size = new System.Drawing.Size(1008, 356);
            this.tbOsszetett.TabIndex = 1;
            this.tbOsszetett.Text = "Összetett cikk";
            this.tbOsszetett.UseVisualStyleBackColor = true;
            this.tbOsszetett.Click += new System.EventHandler(this.tbOsszetett_Click);
            // 
            // Cikkek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 741);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Cikkek";
            this.Text = "Cikkek";
            this.Load += new System.EventHandler(this.Cikkek_Load);
            tbAlap.ResumeLayout(false);
            tbAlap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cikkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raktarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cikkcsoportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ertTipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oTFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbKiszereles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cikkKiszerelesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCikkcsop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource cikkBindingSource;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKESZLETDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKESZLETALLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEGNEVEZESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIKKCSOPORTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cikkcsoportBindingSource;
        private System.Windows.Forms.BindingSource oTFBindingSource;
        private System.Windows.Forms.BindingSource ertTipBindingSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource raktarBindingSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbOsszetett;
        private System.Windows.Forms.CheckBox chkOsszetett;
        private System.Windows.Forms.TabPage tbKiszereles;
        private System.Windows.Forms.TabPage tbKeszlet;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource cikkKiszerelesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn lITKISZIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lITKISZCIKKIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lITKISZNEVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lITKISZMENNYDataGridViewTextBoxColumn;
    }
}