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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fKESZLETDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKESZLETALLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEGNEVEZESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIKKCSOPORTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cikkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCikkcsop = new System.Windows.Forms.ComboBox();
            this.cikkcsoportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.oTFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.e_TextBox1 = new GUI.e_TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cikkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cikkcsoportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oTFBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(908, 200);
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
            // cikkBindingSource
            // 
            this.cikkBindingSource.DataSource = typeof(BusinessLogic.Cikk);
            this.cikkBindingSource.PositionChanged += new System.EventHandler(this.cikkBindingSource_PositionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Megnevezés";
            // 
            // cmbCikkcsop
            // 
            this.cmbCikkcsop.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cikkBindingSource, "CIKKCSOPORT_ID", true));
            this.cmbCikkcsop.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.cikkBindingSource, "CIKKCSOPORT_ID", true));
            this.cmbCikkcsop.DataSource = this.cikkcsoportBindingSource;
            this.cmbCikkcsop.DisplayMember = "NEV";
            this.cmbCikkcsop.FormattingEnabled = true;
            this.cmbCikkcsop.Location = new System.Drawing.Point(301, 243);
            this.cmbCikkcsop.Name = "cmbCikkcsop";
            this.cmbCikkcsop.Size = new System.Drawing.Size(132, 21);
            this.cmbCikkcsop.TabIndex = 5;
            this.cmbCikkcsop.ValueMember = "ID";
            // 
            // cikkcsoportBindingSource
            // 
            this.cikkcsoportBindingSource.DataSource = typeof(BusinessLogic.Cikkcsoport);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cikkcsoport";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cikkBindingSource, "MEGNEVEZES", true));
            this.textBox1.Location = new System.Drawing.Point(100, 290);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Értékesítés típusa:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "L",
            "D"});
            this.comboBox2.Location = new System.Drawing.Point(115, 330);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 9;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.oTFBindingSource, "OID", true));
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oTFBindingSource, "ONEV", true));
            this.comboBox3.DataSource = this.oTFBindingSource;
            this.comboBox3.DisplayMember = "ONEV";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(515, 243);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(84, 21);
            this.comboBox3.TabIndex = 10;
            this.comboBox3.ValueMember = "OID";
            // 
            // oTFBindingSource
            // 
            this.oTFBindingSource.DataSource = typeof(BusinessLogic.OTF);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Alcsoport";
            // 
            // e_TextBox1
            // 
            this.e_TextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cikkBindingSource, "MEGNEVEZES", true));
            this.e_TextBox1.eFieldName = null;
            this.e_TextBox1.Location = new System.Drawing.Point(81, 244);
            this.e_TextBox1.Name = "e_TextBox1";
            this.e_TextBox1.Size = new System.Drawing.Size(132, 20);
            this.e_TextBox1.TabIndex = 3;
            // 
            // Cikkek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 495);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCikkcsop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.e_TextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Cikkek";
            this.Text = "Cikkek";
            this.Load += new System.EventHandler(this.Cikkek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cikkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cikkcsoportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oTFBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GUI.e_TextBox e_TextBox1;
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
    }
}