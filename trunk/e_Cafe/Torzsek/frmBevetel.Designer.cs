namespace e_Cafe
{
    partial class frmBevetel
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSzallitolevel = new System.Windows.Forms.TextBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSzallito = new System.Windows.Forms.Label();
            this.txtSzamlaszam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sORIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bEVETELFEJIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIKKIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIKK_NEV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mENNYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bESZARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nETTOERTEKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aFAERTEKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bRUTTOERTEKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAKTARIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fELADVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAKTAR_NEV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEGJEGYZESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bevetelSorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVegBrutto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVegAfa = new System.Windows.Forms.TextBox();
            this.txtVegNet = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bevetelSorBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(426, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Szállítólevél";
            // 
            // txtSzallitolevel
            // 
            this.txtSzallitolevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSzallitolevel.Location = new System.Drawing.Point(496, 5);
            this.txtSzallitolevel.Name = "txtSzallitolevel";
            this.txtSzallitolevel.Size = new System.Drawing.Size(100, 20);
            this.txtSzallitolevel.TabIndex = 1;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(79, 5);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(120, 20);
            this.dtpDatum.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dátum";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Szállító";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSzallito
            // 
            this.lblSzallito.AutoSize = true;
            this.lblSzallito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSzallito.Location = new System.Drawing.Point(81, 34);
            this.lblSzallito.Name = "lblSzallito";
            this.lblSzallito.Size = new System.Drawing.Size(218, 17);
            this.lblSzallito.TabIndex = 5;
            this.lblSzallito.Text = "Kérem válassza ki a szállítót!";
            // 
            // txtSzamlaszam
            // 
            this.txtSzamlaszam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSzamlaszam.Location = new System.Drawing.Point(307, 6);
            this.txtSzamlaszam.Name = "txtSzamlaszam";
            this.txtSzamlaszam.Size = new System.Drawing.Size(100, 20);
            this.txtSzamlaszam.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Számlaszám";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sORIDDataGridViewTextBoxColumn,
            this.bEVETELFEJIDDataGridViewTextBoxColumn,
            this.cIKKIDDataGridViewTextBoxColumn,
            this.CIKK_NEV,
            this.mENNYDataGridViewTextBoxColumn,
            this.bESZARDataGridViewTextBoxColumn,
            this.nETTOERTEKDataGridViewTextBoxColumn,
            this.aFAERTEKDataGridViewTextBoxColumn,
            this.bRUTTOERTEKDataGridViewTextBoxColumn,
            this.rAKTARIDDataGridViewTextBoxColumn,
            this.fELADVADataGridViewTextBoxColumn,
            this.RAKTAR_NEV,
            this.mEGJEGYZESDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bevetelSorBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.Size = new System.Drawing.Size(890, 143);
            this.dataGridView1.TabIndex = 6;
            // 
            // sORIDDataGridViewTextBoxColumn
            // 
            this.sORIDDataGridViewTextBoxColumn.DataPropertyName = "SOR_ID";
            this.sORIDDataGridViewTextBoxColumn.HeaderText = "SOR_ID";
            this.sORIDDataGridViewTextBoxColumn.Name = "sORIDDataGridViewTextBoxColumn";
            this.sORIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sORIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // bEVETELFEJIDDataGridViewTextBoxColumn
            // 
            this.bEVETELFEJIDDataGridViewTextBoxColumn.DataPropertyName = "BEVETEL_FEJ_ID";
            this.bEVETELFEJIDDataGridViewTextBoxColumn.HeaderText = "BEVETEL_FEJ_ID";
            this.bEVETELFEJIDDataGridViewTextBoxColumn.Name = "bEVETELFEJIDDataGridViewTextBoxColumn";
            this.bEVETELFEJIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bEVETELFEJIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cIKKIDDataGridViewTextBoxColumn
            // 
            this.cIKKIDDataGridViewTextBoxColumn.DataPropertyName = "CIKK_ID";
            this.cIKKIDDataGridViewTextBoxColumn.HeaderText = "CIKK_ID";
            this.cIKKIDDataGridViewTextBoxColumn.Name = "cIKKIDDataGridViewTextBoxColumn";
            this.cIKKIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cIKKIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // CIKK_NEV
            // 
            this.CIKK_NEV.DataPropertyName = "CIKK_NEV";
            this.CIKK_NEV.HeaderText = "Cikk";
            this.CIKK_NEV.Name = "CIKK_NEV";
            this.CIKK_NEV.ReadOnly = true;
            this.CIKK_NEV.Width = 65;
            // 
            // mENNYDataGridViewTextBoxColumn
            // 
            this.mENNYDataGridViewTextBoxColumn.DataPropertyName = "MENNY";
            this.mENNYDataGridViewTextBoxColumn.HeaderText = "Mennyiség";
            this.mENNYDataGridViewTextBoxColumn.Name = "mENNYDataGridViewTextBoxColumn";
            this.mENNYDataGridViewTextBoxColumn.ReadOnly = true;
            this.mENNYDataGridViewTextBoxColumn.Width = 70;
            // 
            // bESZARDataGridViewTextBoxColumn
            // 
            this.bESZARDataGridViewTextBoxColumn.DataPropertyName = "BESZ_AR";
            this.bESZARDataGridViewTextBoxColumn.HeaderText = "Besz. egys. ár";
            this.bESZARDataGridViewTextBoxColumn.Name = "bESZARDataGridViewTextBoxColumn";
            this.bESZARDataGridViewTextBoxColumn.ReadOnly = true;
            this.bESZARDataGridViewTextBoxColumn.Width = 80;
            // 
            // nETTOERTEKDataGridViewTextBoxColumn
            // 
            this.nETTOERTEKDataGridViewTextBoxColumn.DataPropertyName = "NETTO_ERTEK";
            this.nETTOERTEKDataGridViewTextBoxColumn.HeaderText = "Nettó érték";
            this.nETTOERTEKDataGridViewTextBoxColumn.Name = "nETTOERTEKDataGridViewTextBoxColumn";
            this.nETTOERTEKDataGridViewTextBoxColumn.ReadOnly = true;
            this.nETTOERTEKDataGridViewTextBoxColumn.Width = 90;
            // 
            // aFAERTEKDataGridViewTextBoxColumn
            // 
            this.aFAERTEKDataGridViewTextBoxColumn.DataPropertyName = "AFA_ERTEK";
            this.aFAERTEKDataGridViewTextBoxColumn.HeaderText = "Áfa érték";
            this.aFAERTEKDataGridViewTextBoxColumn.Name = "aFAERTEKDataGridViewTextBoxColumn";
            this.aFAERTEKDataGridViewTextBoxColumn.ReadOnly = true;
            this.aFAERTEKDataGridViewTextBoxColumn.Width = 80;
            // 
            // bRUTTOERTEKDataGridViewTextBoxColumn
            // 
            this.bRUTTOERTEKDataGridViewTextBoxColumn.DataPropertyName = "BRUTTO_ERTEK";
            this.bRUTTOERTEKDataGridViewTextBoxColumn.HeaderText = "Bruttó érték";
            this.bRUTTOERTEKDataGridViewTextBoxColumn.Name = "bRUTTOERTEKDataGridViewTextBoxColumn";
            this.bRUTTOERTEKDataGridViewTextBoxColumn.ReadOnly = true;
            this.bRUTTOERTEKDataGridViewTextBoxColumn.Width = 90;
            // 
            // rAKTARIDDataGridViewTextBoxColumn
            // 
            this.rAKTARIDDataGridViewTextBoxColumn.DataPropertyName = "RAKTAR_ID";
            this.rAKTARIDDataGridViewTextBoxColumn.HeaderText = "RAKTAR_ID";
            this.rAKTARIDDataGridViewTextBoxColumn.Name = "rAKTARIDDataGridViewTextBoxColumn";
            this.rAKTARIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.rAKTARIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // fELADVADataGridViewTextBoxColumn
            // 
            this.fELADVADataGridViewTextBoxColumn.DataPropertyName = "FELADVA";
            this.fELADVADataGridViewTextBoxColumn.HeaderText = "FELADVA";
            this.fELADVADataGridViewTextBoxColumn.Name = "fELADVADataGridViewTextBoxColumn";
            this.fELADVADataGridViewTextBoxColumn.ReadOnly = true;
            this.fELADVADataGridViewTextBoxColumn.Visible = false;
            // 
            // RAKTAR_NEV
            // 
            this.RAKTAR_NEV.DataPropertyName = "RAKTAR_NEV";
            this.RAKTAR_NEV.HeaderText = "Raktár";
            this.RAKTAR_NEV.Name = "RAKTAR_NEV";
            this.RAKTAR_NEV.ReadOnly = true;
            // 
            // mEGJEGYZESDataGridViewTextBoxColumn
            // 
            this.mEGJEGYZESDataGridViewTextBoxColumn.DataPropertyName = "MEGJEGYZES";
            this.mEGJEGYZESDataGridViewTextBoxColumn.HeaderText = "Megjegyzés";
            this.mEGJEGYZESDataGridViewTextBoxColumn.Name = "mEGJEGYZESDataGridViewTextBoxColumn";
            this.mEGJEGYZESDataGridViewTextBoxColumn.ReadOnly = true;
            this.mEGJEGYZESDataGridViewTextBoxColumn.Width = 120;
            // 
            // bevetelSorBindingSource
            // 
            this.bevetelSorBindingSource.DataSource = typeof(BusinessLogic.BevetelSor);
            this.bevetelSorBindingSource.CurrentChanged += new System.EventHandler(this.bevetelSorBindingSource_CurrentChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(255)))), ((int)(((byte)(189)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(0, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 25);
            this.button2.TabIndex = 7;
            this.button2.Text = "+ Új sor felvitele";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::e_Cafe.Properties.Resources.floppy_icon;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(584, 64);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 40);
            this.button3.TabIndex = 8;
            this.button3.Text = "Mentés";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(496, 64);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 40);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Mégse";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Végösszeg:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtVegBrutto);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtVegAfa);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtVegNet);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 253);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 82);
            this.panel1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Összesen Bruttó";
            // 
            // txtVegBrutto
            // 
            this.txtVegBrutto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtVegBrutto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVegBrutto.Location = new System.Drawing.Point(259, 52);
            this.txtVegBrutto.Name = "txtVegBrutto";
            this.txtVegBrutto.Size = new System.Drawing.Size(100, 13);
            this.txtVegBrutto.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Öszsesen Áfa:";
            // 
            // txtVegAfa
            // 
            this.txtVegAfa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtVegAfa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVegAfa.Location = new System.Drawing.Point(259, 29);
            this.txtVegAfa.Name = "txtVegAfa";
            this.txtVegAfa.Size = new System.Drawing.Size(100, 13);
            this.txtVegAfa.TabIndex = 1;
            // 
            // txtVegNet
            // 
            this.txtVegNet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtVegNet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVegNet.Location = new System.Drawing.Point(259, 6);
            this.txtVegNet.Name = "txtVegNet";
            this.txtVegNet.Size = new System.Drawing.Size(100, 13);
            this.txtVegNet.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(194, 74);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(182, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Szállító cikkeinek hozzáadása";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // frmBevetel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 335);
            this.ControlBox = false;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblSzallito);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSzamlaszam);
            this.Controls.Add(this.txtSzallitolevel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "frmBevetel";
            this.ShowInTaskbar = false;
            this.Text = "Bevételezés";
            this.Load += new System.EventHandler(this.frmBevetel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bevetelSorBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSzallitolevel;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSzallito;
        private System.Windows.Forms.TextBox txtSzamlaszam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bevetelSorBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVegBrutto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVegAfa;
        private System.Windows.Forms.TextBox txtVegNet;
        private System.Windows.Forms.DataGridViewTextBoxColumn sORIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bEVETELFEJIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIKKIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIKK_NEV;
        private System.Windows.Forms.DataGridViewTextBoxColumn mENNYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bESZARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nETTOERTEKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aFAERTEKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bRUTTOERTEKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAKTARIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fELADVADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAKTAR_NEV;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEGJEGYZESDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
    }
}