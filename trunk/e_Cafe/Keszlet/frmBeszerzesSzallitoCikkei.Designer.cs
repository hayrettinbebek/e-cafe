namespace e_Cafe.Keszlet
{
    partial class frmBeszerzesSzallitoCikkei
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
            this.szallitoCikkekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pCIKKNEVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pMENNYISEGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pEGYSEGARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szallitoCikkekBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pCIKKNEVDataGridViewTextBoxColumn,
            this.pMENNYISEGDataGridViewTextBoxColumn,
            this.pEGYSEGARDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.szallitoCikkekBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(586, 158);
            this.dataGridView1.TabIndex = 0;
            // 
            // szallitoCikkekBindingSource
            // 
            this.szallitoCikkekBindingSource.DataSource = typeof(BusinessLogic.SzallitoCikkek);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kilépés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(343, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Mentés";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pCIKKNEVDataGridViewTextBoxColumn
            // 
            this.pCIKKNEVDataGridViewTextBoxColumn.DataPropertyName = "P_CIKK_NEV";
            this.pCIKKNEVDataGridViewTextBoxColumn.HeaderText = "Cikk";
            this.pCIKKNEVDataGridViewTextBoxColumn.Name = "pCIKKNEVDataGridViewTextBoxColumn";
            this.pCIKKNEVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pMENNYISEGDataGridViewTextBoxColumn
            // 
            this.pMENNYISEGDataGridViewTextBoxColumn.DataPropertyName = "P_MENNYISEG";
            this.pMENNYISEGDataGridViewTextBoxColumn.HeaderText = "Mennyiség";
            this.pMENNYISEGDataGridViewTextBoxColumn.Name = "pMENNYISEGDataGridViewTextBoxColumn";
            // 
            // pEGYSEGARDataGridViewTextBoxColumn
            // 
            this.pEGYSEGARDataGridViewTextBoxColumn.DataPropertyName = "P_EGYSEGAR";
            this.pEGYSEGARDataGridViewTextBoxColumn.HeaderText = "Egységár";
            this.pEGYSEGARDataGridViewTextBoxColumn.Name = "pEGYSEGARDataGridViewTextBoxColumn";
            // 
            // frmBeszerzesSzallitoCikkei
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 237);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmBeszerzesSzallitoCikkei";
            this.Text = "Szállító termékeinek bevételezése";
            this.Load += new System.EventHandler(this.frmBeszerzesSzallitoCikkei_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szallitoCikkekBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource szallitoCikkekBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCIKKNEVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pMENNYISEGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pEGYSEGARDataGridViewTextBoxColumn;
    }
}