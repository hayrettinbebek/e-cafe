namespace e_Cafe
{
    partial class Bevetelezes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bevetelezes));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tPSorok = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BIZONYLATSZAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SZAMLASZAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SZAMLA_OSSZESEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SZAMLA_OSSZ_BRUTTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bevetelfejBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cikkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raktarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bevetelSorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dATUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sZALLITOLEVELSZAMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bEVETELFEJIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pARTNERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sORIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bEVETELFEJIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcCIKK = new System.Windows.Forms.DataGridViewButtonColumn();
            this.mENNYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bESZARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nETTOERTEKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aFAERTEKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bRUTTOERTEKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAKTARIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.fELADVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mEGJEGYZESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tPSorok.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bevetelfejBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cikkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raktarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bevetelSorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(914, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(82, 22);
            this.toolStripButton1.Text = "Új bevételezés";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(46, 22);
            this.toolStripButton2.Text = "Mentés";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BIZONYLATSZAM,
            this.dATUMDataGridViewTextBoxColumn,
            this.sZALLITOLEVELSZAMDataGridViewTextBoxColumn,
            this.SZAMLASZAM,
            this.SZAMLA_OSSZESEN,
            this.SZAMLA_OSSZ_BRUTTO,
            this.bEVETELFEJIDDataGridViewTextBoxColumn,
            this.pARTNERIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bevetelfejBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(914, 191);
            this.dataGridView1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tPSorok);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 216);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(914, 339);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            // 
            // tPSorok
            // 
            this.tPSorok.Controls.Add(this.label3);
            this.tPSorok.Controls.Add(this.label2);
            this.tPSorok.Controls.Add(this.label1);
            this.tPSorok.Controls.Add(this.textBox2);
            this.tPSorok.Controls.Add(this.textBox1);
            this.tPSorok.Controls.Add(this.dateTimePicker1);
            this.tPSorok.Location = new System.Drawing.Point(4, 22);
            this.tPSorok.Name = "tPSorok";
            this.tPSorok.Padding = new System.Windows.Forms.Padding(3);
            this.tPSorok.Size = new System.Drawing.Size(906, 313);
            this.tPSorok.TabIndex = 0;
            this.tPSorok.Text = "Alapadatok";
            this.tPSorok.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bevetelfejBindingSource, "BIZONYLATSZAM", true));
            this.textBox2.Location = new System.Drawing.Point(92, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(263, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bevetelfejBindingSource, "SZALLITOLEVEL_SZAM", true));
            this.textBox1.Location = new System.Drawing.Point(92, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 20);
            this.textBox1.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bevetelfejBindingSource, "DATUM", true));
            this.dateTimePicker1.Location = new System.Drawing.Point(66, 11);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(141, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(906, 313);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sorok";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BIZONYLATSZAM
            // 
            this.BIZONYLATSZAM.DataPropertyName = "BIZONYLATSZAM";
            this.BIZONYLATSZAM.HeaderText = "Bizonylatszám";
            this.BIZONYLATSZAM.Name = "BIZONYLATSZAM";
            // 
            // SZAMLASZAM
            // 
            this.SZAMLASZAM.DataPropertyName = "SZAMLASZAM";
            this.SZAMLASZAM.HeaderText = "Számlaszám";
            this.SZAMLASZAM.Name = "SZAMLASZAM";
            // 
            // SZAMLA_OSSZESEN
            // 
            this.SZAMLA_OSSZESEN.DataPropertyName = "SZAMLA_OSSZESEN";
            this.SZAMLA_OSSZESEN.HeaderText = "Összesen";
            this.SZAMLA_OSSZESEN.Name = "SZAMLA_OSSZESEN";
            // 
            // SZAMLA_OSSZ_BRUTTO
            // 
            this.SZAMLA_OSSZ_BRUTTO.DataPropertyName = "SZAMLA_OSSZ_BRUTTO";
            this.SZAMLA_OSSZ_BRUTTO.HeaderText = "Bruttó összesen";
            this.SZAMLA_OSSZ_BRUTTO.Name = "SZAMLA_OSSZ_BRUTTO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dátum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Szállítólevél";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Számlaszám";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sORIDDataGridViewTextBoxColumn,
            this.bEVETELFEJIDDataGridViewTextBoxColumn1,
            this.dgvcCIKK,
            this.mENNYDataGridViewTextBoxColumn,
            this.bESZARDataGridViewTextBoxColumn,
            this.nETTOERTEKDataGridViewTextBoxColumn,
            this.aFAERTEKDataGridViewTextBoxColumn,
            this.bRUTTOERTEKDataGridViewTextBoxColumn,
            this.rAKTARIDDataGridViewTextBoxColumn,
            this.fELADVADataGridViewTextBoxColumn,
            this.mEGJEGYZESDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bevetelSorBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(900, 243);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // bevetelfejBindingSource
            // 
            this.bevetelfejBindingSource.DataSource = typeof(BusinessLogic.Bevetel_fej);
            this.bevetelfejBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.bevetelfejBindingSource_AddingNew);
            this.bevetelfejBindingSource.PositionChanged += new System.EventHandler(this.bevetelfejBindingSource_PositionChanged);
            this.bevetelfejBindingSource.DataSourceChanged += new System.EventHandler(this.bevetelfejBindingSource_DataSourceChanged);
            this.bevetelfejBindingSource.CurrentItemChanged += new System.EventHandler(this.bevetelfejBindingSource_CurrentItemChanged);
            // 
            // cikkBindingSource
            // 
            this.cikkBindingSource.AllowNew = false;
            this.cikkBindingSource.DataSource = typeof(BusinessLogic.Cikk);
            // 
            // raktarBindingSource
            // 
            this.raktarBindingSource.DataSource = typeof(BusinessLogic.Raktar);
            // 
            // bevetelSorBindingSource
            // 
            this.bevetelSorBindingSource.DataSource = typeof(BusinessLogic.BevetelSor);
            this.bevetelSorBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.bevetelSorBindingSource_AddingNew);
            // 
            // dATUMDataGridViewTextBoxColumn
            // 
            this.dATUMDataGridViewTextBoxColumn.DataPropertyName = "DATUM";
            this.dATUMDataGridViewTextBoxColumn.HeaderText = "Dátum";
            this.dATUMDataGridViewTextBoxColumn.Name = "dATUMDataGridViewTextBoxColumn";
            // 
            // sZALLITOLEVELSZAMDataGridViewTextBoxColumn
            // 
            this.sZALLITOLEVELSZAMDataGridViewTextBoxColumn.DataPropertyName = "SZALLITOLEVEL_SZAM";
            this.sZALLITOLEVELSZAMDataGridViewTextBoxColumn.HeaderText = "Szállítólevél szám";
            this.sZALLITOLEVELSZAMDataGridViewTextBoxColumn.Name = "sZALLITOLEVELSZAMDataGridViewTextBoxColumn";
            // 
            // bEVETELFEJIDDataGridViewTextBoxColumn
            // 
            this.bEVETELFEJIDDataGridViewTextBoxColumn.DataPropertyName = "BEVETEL_FEJ_ID";
            this.bEVETELFEJIDDataGridViewTextBoxColumn.HeaderText = "BEVETEL_FEJ_ID";
            this.bEVETELFEJIDDataGridViewTextBoxColumn.Name = "bEVETELFEJIDDataGridViewTextBoxColumn";
            this.bEVETELFEJIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pARTNERIDDataGridViewTextBoxColumn
            // 
            this.pARTNERIDDataGridViewTextBoxColumn.DataPropertyName = "PARTNER_ID";
            this.pARTNERIDDataGridViewTextBoxColumn.HeaderText = "PARTNER_ID";
            this.pARTNERIDDataGridViewTextBoxColumn.Name = "pARTNERIDDataGridViewTextBoxColumn";
            this.pARTNERIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pARTNERIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // sORIDDataGridViewTextBoxColumn
            // 
            this.sORIDDataGridViewTextBoxColumn.DataPropertyName = "SOR_ID";
            this.sORIDDataGridViewTextBoxColumn.HeaderText = "SOR_ID";
            this.sORIDDataGridViewTextBoxColumn.Name = "sORIDDataGridViewTextBoxColumn";
            this.sORIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // bEVETELFEJIDDataGridViewTextBoxColumn1
            // 
            this.bEVETELFEJIDDataGridViewTextBoxColumn1.DataPropertyName = "BEVETEL_FEJ_ID";
            this.bEVETELFEJIDDataGridViewTextBoxColumn1.HeaderText = "BEVETEL_FEJ_ID";
            this.bEVETELFEJIDDataGridViewTextBoxColumn1.Name = "bEVETELFEJIDDataGridViewTextBoxColumn1";
            this.bEVETELFEJIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // dgvcCIKK
            // 
            this.dgvcCIKK.DataPropertyName = "CIKK_ID";
            this.dgvcCIKK.HeaderText = "Cikk";
            this.dgvcCIKK.Name = "dgvcCIKK";
            this.dgvcCIKK.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcCIKK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvcCIKK.Text = "Cikkek";
            // 
            // mENNYDataGridViewTextBoxColumn
            // 
            this.mENNYDataGridViewTextBoxColumn.DataPropertyName = "MENNY";
            this.mENNYDataGridViewTextBoxColumn.HeaderText = "Mennyiség";
            this.mENNYDataGridViewTextBoxColumn.Name = "mENNYDataGridViewTextBoxColumn";
            // 
            // bESZARDataGridViewTextBoxColumn
            // 
            this.bESZARDataGridViewTextBoxColumn.DataPropertyName = "BESZ_AR";
            this.bESZARDataGridViewTextBoxColumn.HeaderText = "Beszerzési ár";
            this.bESZARDataGridViewTextBoxColumn.Name = "bESZARDataGridViewTextBoxColumn";
            // 
            // nETTOERTEKDataGridViewTextBoxColumn
            // 
            this.nETTOERTEKDataGridViewTextBoxColumn.DataPropertyName = "NETTO_ERTEK";
            this.nETTOERTEKDataGridViewTextBoxColumn.HeaderText = "Nettó érték";
            this.nETTOERTEKDataGridViewTextBoxColumn.Name = "nETTOERTEKDataGridViewTextBoxColumn";
            // 
            // aFAERTEKDataGridViewTextBoxColumn
            // 
            this.aFAERTEKDataGridViewTextBoxColumn.DataPropertyName = "AFA_ERTEK";
            this.aFAERTEKDataGridViewTextBoxColumn.HeaderText = "Áfa érték";
            this.aFAERTEKDataGridViewTextBoxColumn.Name = "aFAERTEKDataGridViewTextBoxColumn";
            // 
            // bRUTTOERTEKDataGridViewTextBoxColumn
            // 
            this.bRUTTOERTEKDataGridViewTextBoxColumn.DataPropertyName = "BRUTTO_ERTEK";
            this.bRUTTOERTEKDataGridViewTextBoxColumn.HeaderText = "Bruttó érték";
            this.bRUTTOERTEKDataGridViewTextBoxColumn.Name = "bRUTTOERTEKDataGridViewTextBoxColumn";
            // 
            // rAKTARIDDataGridViewTextBoxColumn
            // 
            this.rAKTARIDDataGridViewTextBoxColumn.DataPropertyName = "RAKTAR_ID";
            this.rAKTARIDDataGridViewTextBoxColumn.HeaderText = "Raktár";
            this.rAKTARIDDataGridViewTextBoxColumn.Name = "rAKTARIDDataGridViewTextBoxColumn";
            this.rAKTARIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.rAKTARIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.rAKTARIDDataGridViewTextBoxColumn.Text = "<válasszon>";
            // 
            // fELADVADataGridViewTextBoxColumn
            // 
            this.fELADVADataGridViewTextBoxColumn.DataPropertyName = "FELADVA";
            this.fELADVADataGridViewTextBoxColumn.FalseValue = "0";
            this.fELADVADataGridViewTextBoxColumn.HeaderText = "Feladva";
            this.fELADVADataGridViewTextBoxColumn.Name = "fELADVADataGridViewTextBoxColumn";
            this.fELADVADataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fELADVADataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.fELADVADataGridViewTextBoxColumn.TrueValue = "1";
            // 
            // mEGJEGYZESDataGridViewTextBoxColumn
            // 
            this.mEGJEGYZESDataGridViewTextBoxColumn.DataPropertyName = "MEGJEGYZES";
            this.mEGJEGYZESDataGridViewTextBoxColumn.HeaderText = "Megjegyzés";
            this.mEGJEGYZESDataGridViewTextBoxColumn.Name = "mEGJEGYZESDataGridViewTextBoxColumn";
            // 
            // Bevetelezes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 555);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Bevetelezes";
            this.Text = "Bevetelezes";
            this.Load += new System.EventHandler(this.Bevetelezes_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tPSorok.ResumeLayout(false);
            this.tPSorok.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bevetelfejBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cikkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raktarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bevetelSorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tPSorok;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource bevetelfejBindingSource;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn BIZONYLATSZAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sZALLITOLEVELSZAMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SZAMLASZAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn SZAMLA_OSSZESEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SZAMLA_OSSZ_BRUTTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn bEVETELFEJIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pARTNERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource bevetelSorBindingSource;
        private System.Windows.Forms.BindingSource cikkBindingSource;
        private System.Windows.Forms.BindingSource raktarBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn sORIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bEVETELFEJIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dgvcCIKK;
        private System.Windows.Forms.DataGridViewTextBoxColumn mENNYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bESZARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nETTOERTEKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aFAERTEKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bRUTTOERTEKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn rAKTARIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fELADVADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEGJEGYZESDataGridViewTextBoxColumn;
    }
}