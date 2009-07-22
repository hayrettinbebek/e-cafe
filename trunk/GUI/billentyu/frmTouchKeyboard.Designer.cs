namespace GUI.billentyu
{
    partial class frmTouchKeyboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTouchKeyboard));
            this.keyb21 = new GUI.billentyu.keyb2();
            this.SuspendLayout();
            // 
            // keyb21
            // 
            this.keyb21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("keyb21.BackgroundImage")));
            this.keyb21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.keyb21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keyb21.Location = new System.Drawing.Point(0, 0);
            this.keyb21.Name = "keyb21";
            this.keyb21.Size = new System.Drawing.Size(646, 254);
            this.keyb21.TabIndex = 0;
            this.keyb21.Load += new System.EventHandler(this.keyb21_Load);
            // 
            // frmTouchKeyboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(646, 254);
            this.ControlBox = false;
            this.Controls.Add(this.keyb21);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTouchKeyboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.frmTouchKeyboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private keyb2 keyb21;
    }
}