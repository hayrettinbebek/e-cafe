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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.dsMegrendeles = new e_Cafe.dsMegrendeles();
            this.tpTetelek = new System.Windows.Forms.TabPage();
            this.mEGRENDELES_FEJTableAdapter = new e_Cafe.dsMegrendelesTableAdapters.MEGRENDELES_FEJTableAdapter();
            this.pARTNERTableAdapter = new e_Cafe.SQL.dsPartnerekTableAdapters.PARTNERTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tpFej.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pARTNERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPartnerek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEGRENDELESFEJBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMegrendeles)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(735, 391);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tpFej
            // 
            this.tpFej.Controls.Add(this.groupBox1);
            this.tpFej.Controls.Add(this.button1);
            this.tpFej.Controls.Add(this.label1);
            this.tpFej.Controls.Add(this.dataGridView1);
            this.tpFej.Location = new System.Drawing.Point(4, 22);
            this.tpFej.Name = "tpFej";
            this.tpFej.Padding = new System.Windows.Forms.Padding(3);
            this.tpFej.Size = new System.Drawing.Size(727, 365);
            this.tpFej.TabIndex = 0;
            this.tpFej.Text = "tabPage1";
            this.tpFej.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(387, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 351);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Új megrendelés készítése";
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
            // comboBox1
            // 
            this.comboBox1.DataSource = this.pARTNERBindingSource;
            this.comboBox1.DisplayMember = "P_NEV";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(75, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "PARTNER_ID";
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
            // 
            // dsMegrendeles
            // 
            this.dsMegrendeles.DataSetName = "dsMegrendeles";
            this.dsMegrendeles.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tpTetelek
            // 
            this.tpTetelek.Location = new System.Drawing.Point(4, 22);
            this.tpTetelek.Name = "tpTetelek";
            this.tpTetelek.Padding = new System.Windows.Forms.Padding(3);
            this.tpTetelek.Size = new System.Drawing.Size(727, 365);
            this.tpTetelek.TabIndex = 1;
            this.tpTetelek.Text = "tabPage2";
            this.tpTetelek.UseVisualStyleBackColor = true;
            // 
            // mEGRENDELES_FEJTableAdapter
            // 
            this.mEGRENDELES_FEJTableAdapter.ClearBeforeFill = true;
            // 
            // pARTNERTableAdapter
            // 
            this.pARTNERTableAdapter.ClearBeforeFill = true;
            // 
            // frmMegrendelesKeszites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 391);
            this.Controls.Add(this.tabControl1);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpFej;
        private System.Windows.Forms.TabPage tpTetelek;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dsMegrendeles dsMegrendeles;
        private System.Windows.Forms.BindingSource mEGRENDELESFEJBindingSource;
        private e_Cafe.dsMegrendelesTableAdapters.MEGRENDELES_FEJTableAdapter mEGRENDELES_FEJTableAdapter;
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource pARTNERBindingSource;
        private e_Cafe.SQL.dsPartnerek dsPartnerek;
        private e_Cafe.SQL.dsPartnerekTableAdapters.PARTNERTableAdapter pARTNERTableAdapter;
    }
}