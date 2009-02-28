namespace e_Cafe.Torzsek
{
    partial class frmCikkReceptAd
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
            this.txtMenny = new System.Windows.Forms.TextBox();
            this.lblMert = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCikk = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCikk = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.rECEPTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receptMentes = new e_Cafe.ReceptMentes();
            this.rECEPTTableAdapter = new e_Cafe.ReceptMentesTableAdapters.RECEPTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rECEPTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptMentes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMenny
            // 
            this.txtMenny.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMenny.Location = new System.Drawing.Point(155, 38);
            this.txtMenny.Name = "txtMenny";
            this.txtMenny.Size = new System.Drawing.Size(59, 20);
            this.txtMenny.TabIndex = 8;
            // 
            // lblMert
            // 
            this.lblMert.AutoSize = true;
            this.lblMert.Location = new System.Drawing.Point(220, 40);
            this.lblMert.Name = "lblMert";
            this.lblMert.Size = new System.Drawing.Size(0, 13);
            this.lblMert.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mennyiség";
            // 
            // lblCikk
            // 
            this.lblCikk.AutoSize = true;
            this.lblCikk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCikk.Location = new System.Drawing.Point(60, 15);
            this.lblCikk.Name = "lblCikk";
            this.lblCikk.Size = new System.Drawing.Size(182, 17);
            this.lblCikk.TabIndex = 5;
            this.lblCikk.Text = "Kérem válasszon cikket!";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "+ új cikk";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCikk
            // 
            this.btnCikk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCikk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikk.Location = new System.Drawing.Point(12, 12);
            this.btnCikk.Name = "btnCikk";
            this.btnCikk.Size = new System.Drawing.Size(42, 23);
            this.btnCikk.TabIndex = 4;
            this.btnCikk.Text = "Cikk";
            this.btnCikk.UseVisualStyleBackColor = false;
            this.btnCikk.Click += new System.EventHandler(this.btnCikk_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(255)))), ((int)(((byte)(189)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(134, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Felvisz";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(26, 65);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Mégse";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rECEPTBindingSource
            // 
            this.rECEPTBindingSource.DataMember = "RECEPT";
            this.rECEPTBindingSource.DataSource = this.receptMentes;
            // 
            // receptMentes
            // 
            this.receptMentes.DataSetName = "ReceptMentes";
            this.receptMentes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rECEPTTableAdapter
            // 
            this.rECEPTTableAdapter.ClearBeforeFill = true;
            // 
            // frmCikkReceptAd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 121);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtMenny);
            this.Controls.Add(this.lblMert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCikk);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCikk);
            this.Name = "frmCikkReceptAd";
            this.Text = "Recept pozició";
            this.Load += new System.EventHandler(this.frmCikkReceptAd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rECEPTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptMentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMenny;
        private System.Windows.Forms.Label lblMert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCikk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCikk;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private ReceptMentes receptMentes;
        private System.Windows.Forms.BindingSource rECEPTBindingSource;
        private e_Cafe.ReceptMentesTableAdapters.RECEPTTableAdapter rECEPTTableAdapter;
    }
}