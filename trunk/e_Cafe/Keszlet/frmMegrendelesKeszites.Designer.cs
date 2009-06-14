namespace e_Cafe.Keszlet
{
    partial class frmMegrendelesKeszites
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpFej = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSzallito = new System.Windows.Forms.ComboBox();
            this.pARTNERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPartnerek = new e_Cafe.SQL.dsPartnerek();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dATUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_NEV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sORSZAMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEGRENDELESFEJIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sZALLITOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lEZARTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEGRENDELESFEJBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMegrendeles = new e_Cafe.SQL.dsMegrendeles();
            this.tpTetelek = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.chkMind = new System.Windows.Forms.RadioButton();
            this.chkSzallito = new System.Windows.Forms.RadioButton();
            this.lbCikkek = new System.Windows.Forms.ListBox();
            this.cikkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cIKKNEVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mENNYISEGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIKK_MEGYS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bESZARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sORIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fEJIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIKKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.megrendelesSorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tsKilep = new System.Windows.Forms.ToolStripButton();
            this.mEGRENDELES_FEJTableAdapter = new e_Cafe.SQL.dsMegrendelesTableAdapters.MEGRENDELES_FEJTableAdapter();
            this.pARTNERTableAdapter = new e_Cafe.SQL.dsPartnerekTableAdapters.PARTNERTableAdapter();
            this.btnKilep = new System.Windows.Forms.Button();
            this.pnlLezart = new System.Windows.Forms.Panel();
            this.pnlLezart2 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tpFej.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pARTNERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPartnerek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEGRENDELESFEJBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMegrendeles)).BeginInit();
            this.tpTetelek.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cikkBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.megrendelesSorBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpFej);
            this.tabControl1.Controls.Add(this.tpTetelek);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(736, 390);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tpFej
            // 
            this.tpFej.Controls.Add(this.pnlLezart);
            this.tpFej.Controls.Add(this.groupBox1);
            this.tpFej.Controls.Add(this.button1);
            this.tpFej.Controls.Add(this.label1);
            this.tpFej.Controls.Add(this.dataGridView1);
            this.tpFej.Location = new System.Drawing.Point(4, 22);
            this.tpFej.Name = "tpFej";
            this.tpFej.Padding = new System.Windows.Forms.Padding(3);
            this.tpFej.Size = new System.Drawing.Size(728, 364);
            this.tpFej.TabIndex = 0;
            this.tpFej.Text = "Megrendelés adatok";
            this.tpFej.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKilep);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbSzallito);
            this.groupBox1.Location = new System.Drawing.Point(387, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 351);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Új megrendelés készítése";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(95, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "Új megrendelés rögzítése";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Szállító";
            // 
            // cmbSzallito
            // 
            this.cmbSzallito.DataSource = this.pARTNERBindingSource;
            this.cmbSzallito.DisplayMember = "P_NEV";
            this.cmbSzallito.FormattingEnabled = true;
            this.cmbSzallito.Location = new System.Drawing.Point(75, 27);
            this.cmbSzallito.Name = "cmbSzallito";
            this.cmbSzallito.Size = new System.Drawing.Size(199, 21);
            this.cmbSzallito.TabIndex = 0;
            this.cmbSzallito.ValueMember = "PARTNER_ID";
            // 
            // pARTNERBindingSource
            // 
            this.pARTNERBindingSource.DataMember = "PARTNER";
            this.pARTNERBindingSource.DataSource = this.dsPartnerek;
            // 
            // dsPartnerek
            // 
            this.dsPartnerek.DataSetName = "dsPartnerek";
            this.dsPartnerek.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Folytatás...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nyitott megrendelések:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dATUMDataGridViewTextBoxColumn,
            this.P_NEV,
            this.sORSZAMDataGridViewTextBoxColumn,
            this.mEGRENDELESFEJIDDataGridViewTextBoxColumn,
            this.sZALLITOIDDataGridViewTextBoxColumn,
            this.lEZARTDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mEGRENDELESFEJBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(370, 324);
            this.dataGridView1.TabIndex = 0;
            // 
            // dATUMDataGridViewTextBoxColumn
            // 
            this.dATUMDataGridViewTextBoxColumn.DataPropertyName = "DATUM";
            this.dATUMDataGridViewTextBoxColumn.HeaderText = "Dátum";
            this.dATUMDataGridViewTextBoxColumn.Name = "dATUMDataGridViewTextBoxColumn";
            this.dATUMDataGridViewTextBoxColumn.ReadOnly = true;
            this.dATUMDataGridViewTextBoxColumn.Width = 65;
            // 
            // P_NEV
            // 
            this.P_NEV.DataPropertyName = "P_NEV";
            this.P_NEV.HeaderText = "Szállító";
            this.P_NEV.Name = "P_NEV";
            this.P_NEV.ReadOnly = true;
            this.P_NEV.Width = 160;
            // 
            // sORSZAMDataGridViewTextBoxColumn
            // 
            this.sORSZAMDataGridViewTextBoxColumn.DataPropertyName = "SORSZAM";
            this.sORSZAMDataGridViewTextBoxColumn.HeaderText = "Sorszám";
            this.sORSZAMDataGridViewTextBoxColumn.Name = "sORSZAMDataGridViewTextBoxColumn";
            this.sORSZAMDataGridViewTextBoxColumn.ReadOnly = true;
            this.sORSZAMDataGridViewTextBoxColumn.Width = 70;
            // 
            // mEGRENDELESFEJIDDataGridViewTextBoxColumn
            // 
            this.mEGRENDELESFEJIDDataGridViewTextBoxColumn.DataPropertyName = "MEGRENDELES_FEJ_ID";
            this.mEGRENDELESFEJIDDataGridViewTextBoxColumn.HeaderText = "MEGRENDELES_FEJ_ID";
            this.mEGRENDELESFEJIDDataGridViewTextBoxColumn.Name = "mEGRENDELESFEJIDDataGridViewTextBoxColumn";
            this.mEGRENDELESFEJIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.mEGRENDELESFEJIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // sZALLITOIDDataGridViewTextBoxColumn
            // 
            this.sZALLITOIDDataGridViewTextBoxColumn.DataPropertyName = "SZALLITO_ID";
            this.sZALLITOIDDataGridViewTextBoxColumn.HeaderText = "SZALLITO_ID";
            this.sZALLITOIDDataGridViewTextBoxColumn.Name = "sZALLITOIDDataGridViewTextBoxColumn";
            this.sZALLITOIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sZALLITOIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // lEZARTDataGridViewTextBoxColumn
            // 
            this.lEZARTDataGridViewTextBoxColumn.DataPropertyName = "LEZART";
            this.lEZARTDataGridViewTextBoxColumn.HeaderText = "LEZART";
            this.lEZARTDataGridViewTextBoxColumn.Name = "lEZARTDataGridViewTextBoxColumn";
            this.lEZARTDataGridViewTextBoxColumn.ReadOnly = true;
            this.lEZARTDataGridViewTextBoxColumn.Visible = false;
            // 
            // mEGRENDELESFEJBindingSource
            // 
            this.mEGRENDELESFEJBindingSource.DataMember = "MEGRENDELES_FEJ";
            this.mEGRENDELESFEJBindingSource.DataSource = this.dsMegrendeles;
            this.mEGRENDELESFEJBindingSource.CurrentChanged += new System.EventHandler(this.mEGRENDELESFEJBindingSource_CurrentChanged);
            // 
            // dsMegrendeles
            // 
            this.dsMegrendeles.DataSetName = "dsMegrendeles";
            this.dsMegrendeles.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tpTetelek
            // 
            this.tpTetelek.Controls.Add(this.panel2);
            this.tpTetelek.Controls.Add(this.panel1);
            this.tpTetelek.Controls.Add(this.toolStrip1);
            this.tpTetelek.Location = new System.Drawing.Point(4, 22);
            this.tpTetelek.Name = "tpTetelek";
            this.tpTetelek.Padding = new System.Windows.Forms.Padding(3);
            this.tpTetelek.Size = new System.Drawing.Size(728, 364);
            this.tpTetelek.TabIndex = 1;
            this.tpTetelek.Text = "Termékek";
            this.tpTetelek.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlLezart2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.chkMind);
            this.panel2.Controls.Add(this.chkSzallito);
            this.panel2.Controls.Add(this.lbCikkek);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 333);
            this.panel2.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(290, 117);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(34, 76);
            this.button3.TabIndex = 3;
            this.button3.Text = "-->";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // chkMind
            // 
            this.chkMind.AutoSize = true;
            this.chkMind.Location = new System.Drawing.Point(124, 3);
            this.chkMind.Name = "chkMind";
            this.chkMind.Size = new System.Drawing.Size(95, 17);
            this.chkMind.TabIndex = 2;
            this.chkMind.Tag = "1";
            this.chkMind.Text = "Minden termék";
            this.chkMind.UseVisualStyleBackColor = true;
            this.chkMind.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // chkSzallito
            // 
            this.chkSzallito.AutoSize = true;
            this.chkSzallito.Checked = true;
            this.chkSzallito.Location = new System.Drawing.Point(15, 3);
            this.chkSzallito.Name = "chkSzallito";
            this.chkSzallito.Size = new System.Drawing.Size(103, 17);
            this.chkSzallito.TabIndex = 1;
            this.chkSzallito.TabStop = true;
            this.chkSzallito.Tag = "1";
            this.chkSzallito.Text = "Szállító termékei";
            this.chkSzallito.UseVisualStyleBackColor = true;
            this.chkSzallito.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lbCikkek
            // 
            this.lbCikkek.DataSource = this.cikkBindingSource;
            this.lbCikkek.DisplayMember = "MEGNEVEZES";
            this.lbCikkek.FormattingEnabled = true;
            this.lbCikkek.Location = new System.Drawing.Point(5, 25);
            this.lbCikkek.Name = "lbCikkek";
            this.lbCikkek.Size = new System.Drawing.Size(264, 303);
            this.lbCikkek.TabIndex = 0;
            this.lbCikkek.ValueMember = "CIKK_ID";
            // 
            // cikkBindingSource
            // 
            this.cikkBindingSource.DataSource = typeof(BusinessLogic.Cikk);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(345, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 333);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIKKNEVDataGridViewTextBoxColumn,
            this.mENNYISEGDataGridViewTextBoxColumn,
            this.CIKK_MEGYS,
            this.bESZARDataGridViewTextBoxColumn,
            this.sORIDDataGridViewTextBoxColumn,
            this.fEJIDDataGridViewTextBoxColumn,
            this.cIKKDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.megrendelesSorBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(380, 333);
            this.dataGridView2.TabIndex = 0;
            // 
            // cIKKNEVDataGridViewTextBoxColumn
            // 
            this.cIKKNEVDataGridViewTextBoxColumn.DataPropertyName = "CIKK_NEV";
            this.cIKKNEVDataGridViewTextBoxColumn.HeaderText = "Cikk";
            this.cIKKNEVDataGridViewTextBoxColumn.Name = "cIKKNEVDataGridViewTextBoxColumn";
            this.cIKKNEVDataGridViewTextBoxColumn.ReadOnly = true;
            this.cIKKNEVDataGridViewTextBoxColumn.Width = 120;
            // 
            // mENNYISEGDataGridViewTextBoxColumn
            // 
            this.mENNYISEGDataGridViewTextBoxColumn.DataPropertyName = "MENNYISEG";
            this.mENNYISEGDataGridViewTextBoxColumn.HeaderText = "Mennyiség";
            this.mENNYISEGDataGridViewTextBoxColumn.Name = "mENNYISEGDataGridViewTextBoxColumn";
            this.mENNYISEGDataGridViewTextBoxColumn.Width = 60;
            // 
            // CIKK_MEGYS
            // 
            this.CIKK_MEGYS.DataPropertyName = "CIKK_MEGYS";
            this.CIKK_MEGYS.HeaderText = "Me.";
            this.CIKK_MEGYS.Name = "CIKK_MEGYS";
            this.CIKK_MEGYS.ReadOnly = true;
            this.CIKK_MEGYS.Width = 40;
            // 
            // bESZARDataGridViewTextBoxColumn
            // 
            this.bESZARDataGridViewTextBoxColumn.DataPropertyName = "BESZ_AR";
            this.bESZARDataGridViewTextBoxColumn.HeaderText = "Utolsó besz. ár";
            this.bESZARDataGridViewTextBoxColumn.Name = "bESZARDataGridViewTextBoxColumn";
            this.bESZARDataGridViewTextBoxColumn.Width = 70;
            // 
            // sORIDDataGridViewTextBoxColumn
            // 
            this.sORIDDataGridViewTextBoxColumn.DataPropertyName = "SOR_ID";
            this.sORIDDataGridViewTextBoxColumn.HeaderText = "SOR_ID";
            this.sORIDDataGridViewTextBoxColumn.Name = "sORIDDataGridViewTextBoxColumn";
            this.sORIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // fEJIDDataGridViewTextBoxColumn
            // 
            this.fEJIDDataGridViewTextBoxColumn.DataPropertyName = "FEJ_ID";
            this.fEJIDDataGridViewTextBoxColumn.HeaderText = "FEJ_ID";
            this.fEJIDDataGridViewTextBoxColumn.Name = "fEJIDDataGridViewTextBoxColumn";
            this.fEJIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cIKKDataGridViewTextBoxColumn
            // 
            this.cIKKDataGridViewTextBoxColumn.DataPropertyName = "CIKK";
            this.cIKKDataGridViewTextBoxColumn.HeaderText = "CIKK";
            this.cIKKDataGridViewTextBoxColumn.Name = "cIKKDataGridViewTextBoxColumn";
            this.cIKKDataGridViewTextBoxColumn.Visible = false;
            // 
            // megrendelesSorBindingSource
            // 
            this.megrendelesSorBindingSource.DataSource = typeof(BusinessLogic.MegrendelesSor);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.tsKilep});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(722, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.Image = global::e_Cafe.Properties.Resources.floppy_icon;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(62, 22);
            this.toolStripButton1.Text = "Mentés";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.Image = global::e_Cafe.Properties.Resources.Printer_24x24;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(68, 22);
            this.toolStripButton2.Text = "Nyomtat";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // tsKilep
            // 
            this.tsKilep.Image = global::e_Cafe.Properties.Resources.ERROR_ICON;
            this.tsKilep.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsKilep.Name = "tsKilep";
            this.tsKilep.Size = new System.Drawing.Size(60, 22);
            this.tsKilep.Text = "Kilépés";
            this.tsKilep.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // mEGRENDELES_FEJTableAdapter
            // 
            this.mEGRENDELES_FEJTableAdapter.ClearBeforeFill = true;
            // 
            // pARTNERTableAdapter
            // 
            this.pARTNERTableAdapter.ClearBeforeFill = true;
            // 
            // btnKilep
            // 
            this.btnKilep.Location = new System.Drawing.Point(251, 322);
            this.btnKilep.Name = "btnKilep";
            this.btnKilep.Size = new System.Drawing.Size(75, 23);
            this.btnKilep.TabIndex = 3;
            this.btnKilep.Text = "Kilépés";
            this.btnKilep.UseVisualStyleBackColor = true;
            // 
            // pnlLezart
            // 
            this.pnlLezart.Location = new System.Drawing.Point(151, 3);
            this.pnlLezart.Name = "pnlLezart";
            this.pnlLezart.Size = new System.Drawing.Size(29, 27);
            this.pnlLezart.TabIndex = 4;
            // 
            // pnlLezart2
            // 
            this.pnlLezart2.Location = new System.Drawing.Point(283, 13);
            this.pnlLezart2.Name = "pnlLezart2";
            this.pnlLezart2.Size = new System.Drawing.Size(49, 49);
            this.pnlLezart2.TabIndex = 5;
            // 
            // frmMegrendelesKeszites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 390);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMegrendelesKeszites";
            this.Text = "Megrendelés felvitele";
            this.Load += new System.EventHandler(this.frmMegrendelesKeszites_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpFej.ResumeLayout(false);
            this.tpFej.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pARTNERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPartnerek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEGRENDELESFEJBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMegrendeles)).EndInit();
            this.tpTetelek.ResumeLayout(false);
            this.tpTetelek.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cikkBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.megrendelesSorBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpFej;
        private System.Windows.Forms.TabPage tpTetelek;
        private System.Windows.Forms.DataGridView dataGridView1;
        private e_Cafe.SQL.dsMegrendeles dsMegrendeles;
        private System.Windows.Forms.BindingSource mEGRENDELESFEJBindingSource;
        private e_Cafe.SQL.dsMegrendelesTableAdapters.MEGRENDELES_FEJTableAdapter mEGRENDELES_FEJTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_NEV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sORSZAMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEGRENDELESFEJIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sZALLITOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lEZARTDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSzallito;
        private System.Windows.Forms.BindingSource pARTNERBindingSource;
        private e_Cafe.SQL.dsPartnerek dsPartnerek;
        private e_Cafe.SQL.dsPartnerekTableAdapters.PARTNERTableAdapter pARTNERTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource megrendelesSorBindingSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIKKNEVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mENNYISEGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIKK_MEGYS;
        private System.Windows.Forms.DataGridViewTextBoxColumn bESZARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sORIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fEJIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIKKDataGridViewTextBoxColumn;
        private System.Windows.Forms.ListBox lbCikkek;
        private System.Windows.Forms.BindingSource cikkBindingSource;
        private System.Windows.Forms.RadioButton chkMind;
        private System.Windows.Forms.RadioButton chkSzallito;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton tsKilep;
        private System.Windows.Forms.Button btnKilep;
        private System.Windows.Forms.Panel pnlLezart;
        private System.Windows.Forms.Panel pnlLezart2;
    }
}