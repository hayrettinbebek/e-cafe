namespace e_Cafe.Keszlet
{
    partial class frmLeltarozas
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
            this.cmbCikkcsop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRaktar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.eCAFEDataSet = new e_Cafe.SQL.DataSets.ECAFEDataSet();
            this.cIKKCSOPORTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cIKKCSOPORTTableAdapter = new e_Cafe.SQL.DataSets.ECAFEDataSetTableAdapters.CIKKCSOPORTTableAdapter();
            this.eCAFEDataSetRAKTAR = new e_Cafe.SQL.DataSets.ECAFEDataSetRAKTAR();
            this.rAKTARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rAKTARTableAdapter = new e_Cafe.SQL.DataSets.ECAFEDataSetRAKTARTableAdapters.RAKTARTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eCAFEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIKKCSOPORTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCAFEDataSetRAKTAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAKTARBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCikkcsop
            // 
            this.cmbCikkcsop.DataSource = this.cIKKCSOPORTBindingSource;
            this.cmbCikkcsop.DisplayMember = "CIKKCSOPORT_NEV";
            this.cmbCikkcsop.FormattingEnabled = true;
            this.cmbCikkcsop.Location = new System.Drawing.Point(81, 9);
            this.cmbCikkcsop.Name = "cmbCikkcsop";
            this.cmbCikkcsop.Size = new System.Drawing.Size(162, 21);
            this.cmbCikkcsop.TabIndex = 0;
            this.cmbCikkcsop.ValueMember = "CIKKCSOPORT_ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Raktár";
            // 
            // cmbRaktar
            // 
            this.cmbRaktar.DataSource = this.rAKTARBindingSource;
            this.cmbRaktar.DisplayMember = "RAKTAR_KOD";
            this.cmbRaktar.FormattingEnabled = true;
            this.cmbRaktar.Location = new System.Drawing.Point(81, 42);
            this.cmbRaktar.Name = "cmbRaktar";
            this.cmbRaktar.Size = new System.Drawing.Size(162, 21);
            this.cmbRaktar.TabIndex = 0;
            this.cmbRaktar.ValueMember = "RAKTAR_ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cikkcsoport";
            // 
            // eCAFEDataSet
            // 
            this.eCAFEDataSet.DataSetName = "ECAFEDataSet";
            this.eCAFEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cIKKCSOPORTBindingSource
            // 
            this.cIKKCSOPORTBindingSource.DataMember = "CIKKCSOPORT";
            this.cIKKCSOPORTBindingSource.DataSource = this.eCAFEDataSet;
            // 
            // cIKKCSOPORTTableAdapter
            // 
            this.cIKKCSOPORTTableAdapter.ClearBeforeFill = true;
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(255)))), ((int)(((byte)(189)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(158, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Felvisz";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(50, 133);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Mégse";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmLeltarozas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 168);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbRaktar);
            this.Controls.Add(this.cmbCikkcsop);
            this.Name = "frmLeltarozas";
            this.Text = "Új leltárív rögzítése";
            this.Load += new System.EventHandler(this.frmLeltarozas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eCAFEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIKKCSOPORTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCAFEDataSetRAKTAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAKTARBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCikkcsop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRaktar;
        private System.Windows.Forms.Label label3;
        private e_Cafe.SQL.DataSets.ECAFEDataSet eCAFEDataSet;
        private System.Windows.Forms.BindingSource cIKKCSOPORTBindingSource;
        private e_Cafe.SQL.DataSets.ECAFEDataSetTableAdapters.CIKKCSOPORTTableAdapter cIKKCSOPORTTableAdapter;
        private e_Cafe.SQL.DataSets.ECAFEDataSetRAKTAR eCAFEDataSetRAKTAR;
        private System.Windows.Forms.BindingSource rAKTARBindingSource;
        private e_Cafe.SQL.DataSets.ECAFEDataSetRAKTARTableAdapters.RAKTARTableAdapter rAKTARTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;

    }
}