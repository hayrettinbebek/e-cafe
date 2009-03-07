namespace e_Cafe
{
    partial class MMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MMenu));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Button();
            this.btmImgList = new System.Windows.Forms.ImageList(this.components);
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlHelyek = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPartnerek = new System.Windows.Forms.Button();
            this.btnLevelek = new System.Windows.Forms.Button();
            this.btnReceptek = new System.Windows.Forms.Button();
            this.btnFoglalas = new System.Windows.Forms.RadioButton();
            this.btnKilep = new System.Windows.Forms.Button();
            this.btnKijelent = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(184, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(782, 470);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(966, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(128, 470);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.panel5.Controls.Add(this.lblTime);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(128, 113);
            this.panel5.TabIndex = 3;
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTime.Location = new System.Drawing.Point(3, 14);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(108, 41);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "button2";
            this.lblTime.UseVisualStyleBackColor = true;
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // btmImgList
            // 
            this.btmImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("btmImgList.ImageStream")));
            this.btmImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.btmImgList.Images.SetKeyName(0, "off.png");
            this.btmImgList.Images.SetKeyName(1, "aktiv.png");
            // 
            // tmrTime
            // 
            this.tmrTime.Enabled = true;
            this.tmrTime.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(184, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(782, 20);
            this.panel6.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.BackgroundImage = global::e_Cafe.Properties.Resources.oldal;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.pnlHelyek);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 470);
            this.panel2.TabIndex = 1;
            // 
            // pnlHelyek
            // 
            this.pnlHelyek.BackColor = System.Drawing.Color.Transparent;
            this.pnlHelyek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHelyek.Location = new System.Drawing.Point(10, 55);
            this.pnlHelyek.Name = "pnlHelyek";
            this.pnlHelyek.Size = new System.Drawing.Size(150, 415);
            this.pnlHelyek.TabIndex = 9;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(160, 55);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(24, 415);
            this.panel9.TabIndex = 10;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 55);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 415);
            this.panel8.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(184, 55);
            this.panel7.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(173)))), ((int)(((byte)(164)))));
            this.panel1.BackgroundImage = global::e_Cafe.Properties.Resources.also;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnPartnerek);
            this.panel1.Controls.Add(this.btnLevelek);
            this.panel1.Controls.Add(this.btnReceptek);
            this.panel1.Controls.Add(this.btnFoglalas);
            this.panel1.Controls.Add(this.btnKilep);
            this.panel1.Controls.Add(this.btnKijelent);
            this.panel1.Controls.Add(this.btnAdmin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 470);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 116);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(315, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Levelek";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(413, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Receptek";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(501, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Foglalás";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(625, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Partnerek";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(825, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Kijelentkezés";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(935, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(1003, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kilépés";
            // 
            // btnPartnerek
            // 
            this.btnPartnerek.BackColor = System.Drawing.Color.Transparent;
            this.btnPartnerek.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPartnerek.BackgroundImage")));
            this.btnPartnerek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPartnerek.FlatAppearance.BorderSize = 0;
            this.btnPartnerek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPartnerek.Location = new System.Drawing.Point(629, 14);
            this.btnPartnerek.Name = "btnPartnerek";
            this.btnPartnerek.Size = new System.Drawing.Size(70, 75);
            this.btnPartnerek.TabIndex = 9;
            this.btnPartnerek.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnPartnerek.UseVisualStyleBackColor = false;
            this.btnPartnerek.Click += new System.EventHandler(this.btnPartnerek_Click);
            // 
            // btnLevelek
            // 
            this.btnLevelek.BackColor = System.Drawing.Color.Transparent;
            this.btnLevelek.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLevelek.BackgroundImage")));
            this.btnLevelek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLevelek.FlatAppearance.BorderSize = 0;
            this.btnLevelek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLevelek.Location = new System.Drawing.Point(319, 14);
            this.btnLevelek.Name = "btnLevelek";
            this.btnLevelek.Size = new System.Drawing.Size(70, 75);
            this.btnLevelek.TabIndex = 7;
            this.btnLevelek.UseVisualStyleBackColor = false;
            this.btnLevelek.Click += new System.EventHandler(this.btnLevelek_Click);
            // 
            // btnReceptek
            // 
            this.btnReceptek.BackColor = System.Drawing.Color.Transparent;
            this.btnReceptek.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReceptek.BackgroundImage")));
            this.btnReceptek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReceptek.FlatAppearance.BorderSize = 0;
            this.btnReceptek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceptek.Location = new System.Drawing.Point(420, 14);
            this.btnReceptek.Name = "btnReceptek";
            this.btnReceptek.Size = new System.Drawing.Size(70, 75);
            this.btnReceptek.TabIndex = 7;
            this.btnReceptek.UseVisualStyleBackColor = false;
            this.btnReceptek.Click += new System.EventHandler(this.btnReceptek_Click);
            // 
            // btnFoglalas
            // 
            this.btnFoglalas.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnFoglalas.BackColor = System.Drawing.Color.Transparent;
            this.btnFoglalas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFoglalas.BackgroundImage")));
            this.btnFoglalas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFoglalas.FlatAppearance.BorderSize = 0;
            this.btnFoglalas.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFoglalas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoglalas.Location = new System.Drawing.Point(505, 14);
            this.btnFoglalas.Name = "btnFoglalas";
            this.btnFoglalas.Size = new System.Drawing.Size(70, 75);
            this.btnFoglalas.TabIndex = 7;
            this.btnFoglalas.UseVisualStyleBackColor = false;
            // 
            // btnKilep
            // 
            this.btnKilep.BackColor = System.Drawing.Color.Transparent;
            this.btnKilep.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKilep.BackgroundImage")));
            this.btnKilep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKilep.FlatAppearance.BorderSize = 0;
            this.btnKilep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKilep.Location = new System.Drawing.Point(1000, 14);
            this.btnKilep.Name = "btnKilep";
            this.btnKilep.Size = new System.Drawing.Size(70, 75);
            this.btnKilep.TabIndex = 4;
            this.btnKilep.UseVisualStyleBackColor = false;
            this.btnKilep.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnKijelent
            // 
            this.btnKijelent.BackColor = System.Drawing.Color.Transparent;
            this.btnKijelent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKijelent.BackgroundImage")));
            this.btnKijelent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKijelent.FlatAppearance.BorderSize = 0;
            this.btnKijelent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKijelent.Location = new System.Drawing.Point(838, 14);
            this.btnKijelent.Name = "btnKijelent";
            this.btnKijelent.Size = new System.Drawing.Size(70, 75);
            this.btnKijelent.TabIndex = 1;
            this.btnKijelent.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnKijelent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKijelent.UseVisualStyleBackColor = false;
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.Transparent;
            this.btnAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdmin.BackgroundImage")));
            this.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Location = new System.Drawing.Point(924, 14);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(70, 75);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.button2_Click);
            // 
            // MMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 586);
            this.ControlBox = false;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "MMenu";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MMenu_Load);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button lblTime;

        private System.Windows.Forms.Button btnKilep;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel pnlHelyek;
        private System.Windows.Forms.RadioButton btnFoglalas;
        private System.Windows.Forms.Button btnPartnerek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnReceptek;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLevelek;
        public System.Windows.Forms.ImageList btmImgList;
        private System.Windows.Forms.Button btnKijelent;
        private System.Windows.Forms.Label label8;
        
    }
}

