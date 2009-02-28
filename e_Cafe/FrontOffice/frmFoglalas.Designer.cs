namespace e_Cafe.FrontOffice
{
    partial class frmFoglalas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFoglalas));
            this.panel5 = new System.Windows.Forms.Panel();
            this.mcDatum = new System.Windows.Forms.MonthCalendar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.txtMegj = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtNev = new System.Windows.Forms.TextBox();
            this.txtTolM = new System.Windows.Forms.TextBox();
            this.txtIgM = new System.Windows.Forms.TextBox();
            this.txtIgH = new System.Windows.Forms.TextBox();
            this.txtTolH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAsztal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel3 = new System.Windows.Forms.Panel();
            this.keyb21 = new GUI.billentyu.keyb2();
            this.ctMinSelector = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fOGLALASIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.fOGLALFROMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fOGLALTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NEV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEGJEGYZESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aSZTALIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pARTNERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fOGLALASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsFOGLALAS = new e_Cafe.SQL.dsFOGLALAS();
            this.fOGLALASTableAdapter = new e_Cafe.SQL.dsFOGLALASTableAdapters.FOGLALASTableAdapter();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.ctMinSelector.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOGLALASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFOGLALAS)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.mcDatum);
            this.panel5.Location = new System.Drawing.Point(30, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(369, 252);
            this.panel5.TabIndex = 3;
            // 
            // mcDatum
            // 
            this.mcDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mcDatum.Location = new System.Drawing.Point(26, 9);
            this.mcDatum.MaxSelectionCount = 1;
            this.mcDatum.Name = "mcDatum";
            this.mcDatum.ShowToday = false;
            this.mcDatum.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.txtMegj);
            this.panel1.Controls.Add(this.txtTel);
            this.panel1.Controls.Add(this.txtNev);
            this.panel1.Controls.Add(this.txtTolM);
            this.panel1.Controls.Add(this.txtIgM);
            this.panel1.Controls.Add(this.txtIgH);
            this.panel1.Controls.Add(this.txtTolH);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblAsztal);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Location = new System.Drawing.Point(497, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 365);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(245, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Foglal";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtMegj
            // 
            this.txtMegj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMegj.Location = new System.Drawing.Point(111, 257);
            this.txtMegj.Multiline = true;
            this.txtMegj.Name = "txtMegj";
            this.txtMegj.Size = new System.Drawing.Size(249, 54);
            this.txtMegj.TabIndex = 7;
            this.txtMegj.Enter += new System.EventHandler(this.txtKeyb_Enter);
            // 
            // txtTel
            // 
            this.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTel.Location = new System.Drawing.Point(111, 220);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(249, 20);
            this.txtTel.TabIndex = 6;
            this.txtTel.Enter += new System.EventHandler(this.txtKeyb_Enter);
            // 
            // txtNev
            // 
            this.txtNev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNev.Location = new System.Drawing.Point(111, 194);
            this.txtNev.Name = "txtNev";
            this.txtNev.Size = new System.Drawing.Size(249, 20);
            this.txtNev.TabIndex = 5;
            this.txtNev.Enter += new System.EventHandler(this.txtKeyb_Enter);
            // 
            // txtTolM
            // 
            this.txtTolM.BackColor = System.Drawing.Color.White;
            this.txtTolM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTolM.Location = new System.Drawing.Point(151, 137);
            this.txtTolM.Name = "txtTolM";
            this.txtTolM.ReadOnly = true;
            this.txtTolM.Size = new System.Drawing.Size(32, 20);
            this.txtTolM.TabIndex = 2;
            this.txtTolM.TextChanged += new System.EventHandler(this.txtTolM_TextChanged);
            this.txtTolM.Click += new System.EventHandler(this.txtTolM_Click);
            // 
            // txtIgM
            // 
            this.txtIgM.BackColor = System.Drawing.Color.White;
            this.txtIgM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIgM.Location = new System.Drawing.Point(151, 166);
            this.txtIgM.Name = "txtIgM";
            this.txtIgM.ReadOnly = true;
            this.txtIgM.Size = new System.Drawing.Size(32, 20);
            this.txtIgM.TabIndex = 4;
            this.txtIgM.Click += new System.EventHandler(this.txtIgM_Click);
            // 
            // txtIgH
            // 
            this.txtIgH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIgH.Location = new System.Drawing.Point(111, 166);
            this.txtIgH.Name = "txtIgH";
            this.txtIgH.Size = new System.Drawing.Size(34, 20);
            this.txtIgH.TabIndex = 3;
            // 
            // txtTolH
            // 
            this.txtTolH.BackColor = System.Drawing.Color.White;
            this.txtTolH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTolH.Location = new System.Drawing.Point(111, 137);
            this.txtTolH.Name = "txtTolH";
            this.txtTolH.Size = new System.Drawing.Size(34, 20);
            this.txtTolH.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(29, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "megjegyzes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(43, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "értesítés:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(66, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(50, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "meddig:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(56, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "mettől:";
            // 
            // lblAsztal
            // 
            this.lblAsztal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblAsztal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAsztal.Location = new System.Drawing.Point(117, 40);
            this.lblAsztal.Name = "lblAsztal";
            this.lblAsztal.Size = new System.Drawing.Size(262, 77);
            this.lblAsztal.TabIndex = 2;
            this.lblAsztal.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(12, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(99, 77);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(347, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 34);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(390, 365);
            this.shapeContainer1.TabIndex = 4;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 101;
            this.lineShape1.X2 = 101;
            this.lineShape1.Y1 = 140;
            this.lineShape1.Y2 = 333;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.keyb21);
            this.panel3.Location = new System.Drawing.Point(30, 361);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(619, 266);
            this.panel3.TabIndex = 4;
            // 
            // keyb21
            // 
            this.keyb21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.keyb21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("keyb21.BackgroundImage")));
            this.keyb21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.keyb21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keyb21.Location = new System.Drawing.Point(0, 0);
            this.keyb21.Name = "keyb21";
            this.keyb21.Size = new System.Drawing.Size(619, 266);
            this.keyb21.TabIndex = 0;
            // 
            // ctMinSelector
            // 
            this.ctMinSelector.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.ctMinSelector.Name = "ctMinSelector";
            this.ctMinSelector.Size = new System.Drawing.Size(108, 100);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(107, 24);
            this.toolStripMenuItem1.Text = "00";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(107, 24);
            this.toolStripMenuItem3.Text = "15";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(107, 24);
            this.toolStripMenuItem4.Text = "30";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(107, 24);
            this.toolStripMenuItem5.Text = "45";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(1, 260);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(499, 107);
            this.panel4.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fOGLALASIDDataGridViewTextBoxColumn,
            this.clDelete,
            this.fOGLALFROMDataGridViewTextBoxColumn,
            this.fOGLALTODataGridViewTextBoxColumn,
            this.NEV,
            this.TELEFON,
            this.mEGJEGYZESDataGridViewTextBoxColumn,
            this.aSZTALIDDataGridViewTextBoxColumn,
            this.pARTNERIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fOGLALASBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(499, 87);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // fOGLALASIDDataGridViewTextBoxColumn
            // 
            this.fOGLALASIDDataGridViewTextBoxColumn.DataPropertyName = "FOGLALAS_ID";
            this.fOGLALASIDDataGridViewTextBoxColumn.HeaderText = "FOGLALAS_ID";
            this.fOGLALASIDDataGridViewTextBoxColumn.Name = "fOGLALASIDDataGridViewTextBoxColumn";
            this.fOGLALASIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // clDelete
            // 
            this.clDelete.HeaderText = "";
            this.clDelete.Image = ((System.Drawing.Image)(resources.GetObject("clDelete.Image")));
            this.clDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.clDelete.Name = "clDelete";
            this.clDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clDelete.Width = 20;
            // 
            // fOGLALFROMDataGridViewTextBoxColumn
            // 
            this.fOGLALFROMDataGridViewTextBoxColumn.DataPropertyName = "FOGLAL_FROM";
            this.fOGLALFROMDataGridViewTextBoxColumn.HeaderText = "Mettől";
            this.fOGLALFROMDataGridViewTextBoxColumn.Name = "fOGLALFROMDataGridViewTextBoxColumn";
            this.fOGLALFROMDataGridViewTextBoxColumn.Width = 85;
            // 
            // fOGLALTODataGridViewTextBoxColumn
            // 
            this.fOGLALTODataGridViewTextBoxColumn.DataPropertyName = "FOGLAL_TO";
            this.fOGLALTODataGridViewTextBoxColumn.HeaderText = "meddig";
            this.fOGLALTODataGridViewTextBoxColumn.Name = "fOGLALTODataGridViewTextBoxColumn";
            this.fOGLALTODataGridViewTextBoxColumn.Width = 60;
            // 
            // NEV
            // 
            this.NEV.DataPropertyName = "NEV";
            this.NEV.HeaderText = "Név";
            this.NEV.Name = "NEV";
            // 
            // TELEFON
            // 
            this.TELEFON.DataPropertyName = "TELEFON";
            this.TELEFON.HeaderText = "Elérhetőség";
            this.TELEFON.Name = "TELEFON";
            this.TELEFON.Width = 90;
            // 
            // mEGJEGYZESDataGridViewTextBoxColumn
            // 
            this.mEGJEGYZESDataGridViewTextBoxColumn.DataPropertyName = "MEGJEGYZES";
            this.mEGJEGYZESDataGridViewTextBoxColumn.HeaderText = "Megjegyzes";
            this.mEGJEGYZESDataGridViewTextBoxColumn.Name = "mEGJEGYZESDataGridViewTextBoxColumn";
            // 
            // aSZTALIDDataGridViewTextBoxColumn
            // 
            this.aSZTALIDDataGridViewTextBoxColumn.DataPropertyName = "ASZTAL_ID";
            this.aSZTALIDDataGridViewTextBoxColumn.HeaderText = "ASZTAL_ID";
            this.aSZTALIDDataGridViewTextBoxColumn.Name = "aSZTALIDDataGridViewTextBoxColumn";
            this.aSZTALIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pARTNERIDDataGridViewTextBoxColumn
            // 
            this.pARTNERIDDataGridViewTextBoxColumn.DataPropertyName = "PARTNER_ID";
            this.pARTNERIDDataGridViewTextBoxColumn.HeaderText = "PARTNER_ID";
            this.pARTNERIDDataGridViewTextBoxColumn.Name = "pARTNERIDDataGridViewTextBoxColumn";
            this.pARTNERIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // fOGLALASBindingSource
            // 
            this.fOGLALASBindingSource.DataMember = "FOGLALAS";
            this.fOGLALASBindingSource.DataSource = this.dsFOGLALAS;
            // 
            // dsFOGLALAS
            // 
            this.dsFOGLALAS.DataSetName = "dsFOGLALAS";
            this.dsFOGLALAS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fOGLALASTableAdapter
            // 
            this.fOGLALASTableAdapter.ClearBeforeFill = true;
            // 
            // frmFoglalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(939, 625);
            this.ControlBox = false;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "frmFoglalas";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Yellow;
            this.Load += new System.EventHandler(this.frmFoglalas_Load);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ctMinSelector.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOGLALASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFOGLALAS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.MonthCalendar mcDatum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblAsztal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private GUI.billentyu.keyb2 keyb21;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox txtTolM;
        private System.Windows.Forms.TextBox txtIgM;
        private System.Windows.Forms.TextBox txtIgH;
        private System.Windows.Forms.TextBox txtTolH;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtNev;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtMegj;
        private System.Windows.Forms.ContextMenuStrip ctMinSelector;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private e_Cafe.SQL.dsFOGLALAS dsFOGLALAS;
        private System.Windows.Forms.BindingSource fOGLALASBindingSource;
        private e_Cafe.SQL.dsFOGLALASTableAdapters.FOGLALASTableAdapter fOGLALASTableAdapter;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fOGLALASIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn clDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn fOGLALFROMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fOGLALTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NEV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFON;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEGJEGYZESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aSZTALIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pARTNERIDDataGridViewTextBoxColumn;

    }
}