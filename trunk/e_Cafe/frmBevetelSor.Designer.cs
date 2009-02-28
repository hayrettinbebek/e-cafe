namespace e_Cafe
{
    partial class frmBevetelSor
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
            this.btnCikk = new System.Windows.Forms.Button();
            this.lblCikk = new System.Windows.Forms.Label();
            this.txtMenny = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEgys = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMegj = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblMert = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lblPenz = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbRaktar = new System.Windows.Forms.ComboBox();
            this.rAKTARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eCAFEDataSetRAKTAR = new e_Cafe.SQL.ECAFEDataSetRAKTAR();
            this.rAKTARTableAdapter = new e_Cafe.SQL.ECAFEDataSetRAKTARTableAdapters.RAKTARTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rAKTARBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCAFEDataSetRAKTAR)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCikk
            // 
            this.btnCikk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCikk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikk.Location = new System.Drawing.Point(1, 3);
            this.btnCikk.Name = "btnCikk";
            this.btnCikk.Size = new System.Drawing.Size(42, 23);
            this.btnCikk.TabIndex = 0;
            this.btnCikk.Text = "Cikk";
            this.btnCikk.UseVisualStyleBackColor = false;
            this.btnCikk.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCikk
            // 
            this.lblCikk.AutoSize = true;
            this.lblCikk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCikk.Location = new System.Drawing.Point(49, 6);
            this.lblCikk.Name = "lblCikk";
            this.lblCikk.Size = new System.Drawing.Size(182, 17);
            this.lblCikk.TabIndex = 1;
            this.lblCikk.Text = "Kérem válasszon cikket!";
            this.lblCikk.Click += new System.EventHandler(this.lblCikk_Click);
            // 
            // txtMenny
            // 
            this.txtMenny.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMenny.Location = new System.Drawing.Point(144, 29);
            this.txtMenny.Name = "txtMenny";
            this.txtMenny.Size = new System.Drawing.Size(59, 20);
            this.txtMenny.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mennyiség";
            // 
            // txtEgys
            // 
            this.txtEgys.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEgys.Location = new System.Drawing.Point(144, 55);
            this.txtEgys.Name = "txtEgys";
            this.txtEgys.Size = new System.Drawing.Size(59, 20);
            this.txtEgys.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Egységár";
            // 
            // txtMegj
            // 
            this.txtMegj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMegj.Location = new System.Drawing.Point(12, 139);
            this.txtMegj.Name = "txtMegj";
            this.txtMegj.Size = new System.Drawing.Size(265, 20);
            this.txtMegj.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Megjegyzés";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(255)))), ((int)(((byte)(189)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(177, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Felvisz";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblMert
            // 
            this.lblMert.AutoSize = true;
            this.lblMert.Location = new System.Drawing.Point(209, 31);
            this.lblMert.Name = "lblMert";
            this.lblMert.Size = new System.Drawing.Size(0, 13);
            this.lblMert.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(69, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Mégse";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblPenz
            // 
            this.lblPenz.AutoSize = true;
            this.lblPenz.Location = new System.Drawing.Point(209, 58);
            this.lblPenz.Name = "lblPenz";
            this.lblPenz.Size = new System.Drawing.Size(0, 13);
            this.lblPenz.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Raktár";
            // 
            // cmbRaktar
            // 
            this.cmbRaktar.DataSource = this.rAKTARBindingSource;
            this.cmbRaktar.DisplayMember = "RAKTAR_KOD";
            this.cmbRaktar.FormattingEnabled = true;
            this.cmbRaktar.Location = new System.Drawing.Point(144, 81);
            this.cmbRaktar.Name = "cmbRaktar";
            this.cmbRaktar.Size = new System.Drawing.Size(90, 21);
            this.cmbRaktar.TabIndex = 5;
            this.cmbRaktar.ValueMember = "RAKTAR_ID";
            // 
            // rAKTARBindingSource
            // 
            this.rAKTARBindingSource.DataMember = "RAKTAR";
            this.rAKTARBindingSource.DataSource = this.eCAFEDataSetRAKTAR;
            // 
            // eCAFEDataSetRAKTAR
            // 
            this.eCAFEDataSetRAKTAR.DataSetName = "ECAFEDataSetRAKTAR";
            this.eCAFEDataSetRAKTAR.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rAKTARTableAdapter
            // 
            this.rAKTARTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "+ új cikk";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmBevetelSor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 207);
            this.ControlBox = false;
            this.Controls.Add(this.cmbRaktar);
            this.Controls.Add(this.lblPenz);
            this.Controls.Add(this.txtMegj);
            this.Controls.Add(this.txtEgys);
            this.Controls.Add(this.txtMenny);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCikk);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCikk);
            this.Name = "frmBevetelSor";
            this.ShowInTaskbar = false;
            this.Text = "Bevételezés tétel hozzáadaása";
            this.Load += new System.EventHandler(this.frmBevetelSor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rAKTARBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCAFEDataSetRAKTAR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCikk;
        private System.Windows.Forms.Label lblCikk;
        private System.Windows.Forms.TextBox txtMenny;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEgys;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMegj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblMert;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblPenz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbRaktar;
        private e_Cafe.SQL.ECAFEDataSetRAKTAR eCAFEDataSetRAKTAR;
        private System.Windows.Forms.BindingSource rAKTARBindingSource;
        private e_Cafe.SQL.ECAFEDataSetRAKTARTableAdapters.RAKTARTableAdapter rAKTARTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}