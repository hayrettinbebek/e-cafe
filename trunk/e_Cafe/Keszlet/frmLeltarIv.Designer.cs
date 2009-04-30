namespace e_Cafe.Keszlet
{
    partial class frmLeltarIv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLeltarIv));
            this.gvLeltarIv = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.P_CIKK_NEV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.aKTKESZLETMENNYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sZAMOLTMENNYISEG1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sZAMOLTMENNYISEG2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leltarSorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.gvLeltarIv)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leltarSorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gvLeltarIv
            // 
            this.gvLeltarIv.AllowUserToAddRows = false;
            this.gvLeltarIv.AllowUserToDeleteRows = false;
            this.gvLeltarIv.AutoGenerateColumns = false;
            this.gvLeltarIv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLeltarIv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.P_CIKK_NEV,
            this.aKTKESZLETMENNYDataGridViewTextBoxColumn,
            this.sZAMOLTMENNYISEG1DataGridViewTextBoxColumn,
            this.sZAMOLTMENNYISEG2DataGridViewTextBoxColumn});
            this.gvLeltarIv.DataSource = this.leltarSorBindingSource;
            this.gvLeltarIv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvLeltarIv.Location = new System.Drawing.Point(0, 25);
            this.gvLeltarIv.Name = "gvLeltarIv";
            this.gvLeltarIv.Size = new System.Drawing.Size(751, 274);
            this.gvLeltarIv.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(751, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // P_CIKK_NEV
            // 
            this.P_CIKK_NEV.DataPropertyName = "P_CIKK_NEV";
            this.P_CIKK_NEV.HeaderText = "Cikk";
            this.P_CIKK_NEV.Name = "P_CIKK_NEV";
            this.P_CIKK_NEV.ReadOnly = true;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(62, 22);
            this.toolStripButton1.Text = "Mentés";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // aKTKESZLETMENNYDataGridViewTextBoxColumn
            // 
            this.aKTKESZLETMENNYDataGridViewTextBoxColumn.DataPropertyName = "AKT_KESZLET_MENNY";
            this.aKTKESZLETMENNYDataGridViewTextBoxColumn.HeaderText = "Készleten mennyiség";
            this.aKTKESZLETMENNYDataGridViewTextBoxColumn.Name = "aKTKESZLETMENNYDataGridViewTextBoxColumn";
            // 
            // sZAMOLTMENNYISEG1DataGridViewTextBoxColumn
            // 
            this.sZAMOLTMENNYISEG1DataGridViewTextBoxColumn.DataPropertyName = "SZAMOLT_MENNYISEG1";
            this.sZAMOLTMENNYISEG1DataGridViewTextBoxColumn.HeaderText = "Számolt mennyiség";
            this.sZAMOLTMENNYISEG1DataGridViewTextBoxColumn.Name = "sZAMOLTMENNYISEG1DataGridViewTextBoxColumn";
            // 
            // sZAMOLTMENNYISEG2DataGridViewTextBoxColumn
            // 
            this.sZAMOLTMENNYISEG2DataGridViewTextBoxColumn.DataPropertyName = "SZAMOLT_MENNYISEG2";
            this.sZAMOLTMENNYISEG2DataGridViewTextBoxColumn.HeaderText = "Ellenőrző számolás";
            this.sZAMOLTMENNYISEG2DataGridViewTextBoxColumn.Name = "sZAMOLTMENNYISEG2DataGridViewTextBoxColumn";
            // 
            // leltarSorBindingSource
            // 
            this.leltarSorBindingSource.DataSource = typeof(BusinessLogic.LeltarSor);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(95, 22);
            this.toolStripButton2.Text = "ív nyomtatása";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // frmLeltarIv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 299);
            this.Controls.Add(this.gvLeltarIv);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmLeltarIv";
            this.Text = "Leltár ív rögzítése";
            ((System.ComponentModel.ISupportInitialize)(this.gvLeltarIv)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leltarSorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvLeltarIv;
        private System.Windows.Forms.BindingSource leltarSorBindingSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_CIKK_NEV;
        private System.Windows.Forms.DataGridViewTextBoxColumn aKTKESZLETMENNYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sZAMOLTMENNYISEG1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sZAMOLTMENNYISEG2DataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}