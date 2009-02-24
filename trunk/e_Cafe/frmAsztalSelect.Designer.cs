namespace e_Cafe
{
    partial class frmAsztalSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsztalSelect));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlHelyek = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btmImgList = new System.Windows.Forms.ImageList(this.components);
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.panel2.Size = new System.Drawing.Size(184, 505);
            this.panel2.TabIndex = 2;
            // 
            // pnlHelyek
            // 
            this.pnlHelyek.BackColor = System.Drawing.Color.Transparent;
            this.pnlHelyek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHelyek.Location = new System.Drawing.Point(10, 55);
            this.pnlHelyek.Name = "pnlHelyek";
            this.pnlHelyek.Size = new System.Drawing.Size(150, 450);
            this.pnlHelyek.TabIndex = 9;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(160, 55);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(24, 450);
            this.panel9.TabIndex = 10;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 55);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 450);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(184, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(632, 505);
            this.panel3.TabIndex = 3;
            // 
            // btmImgList
            // 
            this.btmImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("btmImgList.ImageStream")));
            this.btmImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.btmImgList.Images.SetKeyName(0, "off.png");
            this.btmImgList.Images.SetKeyName(1, "aktiv.png");
            // 
            // frmAsztalSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 505);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "frmAsztalSelect";
            this.ShowInTaskbar = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAsztalSelect_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlHelyek;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.ImageList btmImgList;
    }
}