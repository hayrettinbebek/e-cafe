namespace e_Cafe.Admin
{
    partial class frmUjUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNEV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUSER_NAME = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.chkAdmin = new System.Windows.Forms.CheckBox();
            this.chkAktiv = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név";
            // 
            // txtNEV
            // 
            this.txtNEV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNEV.Location = new System.Drawing.Point(45, 7);
            this.txtNEV.Name = "txtNEV";
            this.txtNEV.Size = new System.Drawing.Size(151, 20);
            this.txtNEV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Felhasználói név";
            // 
            // txtUSER_NAME
            // 
            this.txtUSER_NAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUSER_NAME.Location = new System.Drawing.Point(121, 63);
            this.txtUSER_NAME.Name = "txtUSER_NAME";
            this.txtUSER_NAME.Size = new System.Drawing.Size(115, 20);
            this.txtUSER_NAME.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Jelszó";
            // 
            // txtPW
            // 
            this.txtPW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPW.Location = new System.Drawing.Point(121, 89);
            this.txtPW.Name = "txtPW";
            this.txtPW.PasswordChar = '*';
            this.txtPW.Size = new System.Drawing.Size(115, 20);
            this.txtPW.TabIndex = 1;
            this.txtPW.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPW_KeyDown);
            this.txtPW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPW_KeyPress);
            // 
            // chkAdmin
            // 
            this.chkAdmin.AutoSize = true;
            this.chkAdmin.Location = new System.Drawing.Point(32, 137);
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.Size = new System.Drawing.Size(91, 17);
            this.chkAdmin.TabIndex = 2;
            this.chkAdmin.Text = "Adminisztrátor";
            this.chkAdmin.UseVisualStyleBackColor = true;
            // 
            // chkAktiv
            // 
            this.chkAktiv.AutoSize = true;
            this.chkAktiv.Location = new System.Drawing.Point(32, 160);
            this.chkAktiv.Name = "chkAktiv";
            this.chkAktiv.Size = new System.Drawing.Size(52, 17);
            this.chkAktiv.TabIndex = 2;
            this.chkAktiv.Text = "Aktív";
            this.chkAktiv.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Mégse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblWarning.Location = new System.Drawing.Point(109, 112);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(141, 13);
            this.lblWarning.TabIndex = 5;
            this.lblWarning.Text = "!!! csak szám adható !!!";
            this.lblWarning.Visible = false;
            // 
            // frmUjUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.ControlBox = false;
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkAktiv);
            this.Controls.Add(this.chkAdmin);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.txtUSER_NAME);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNEV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUjUser";
            this.ShowInTaskbar = false;
            this.Text = "Új felhasználó rögzítése";
            this.Load += new System.EventHandler(this.frmUjUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNEV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUSER_NAME;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.CheckBox chkAdmin;
        private System.Windows.Forms.CheckBox chkAktiv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblWarning;
    }
}