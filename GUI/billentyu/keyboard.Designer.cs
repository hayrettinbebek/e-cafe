namespace GUI.billentyu
{
    partial class keyboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbBillentyuzet = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBillentyuzet)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBillentyuzet
            // 
            this.pbBillentyuzet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbBillentyuzet.Image = global::GUI.Properties.Resources.bill;
            this.pbBillentyuzet.Location = new System.Drawing.Point(0, 0);
            this.pbBillentyuzet.Name = "pbBillentyuzet";
            this.pbBillentyuzet.Size = new System.Drawing.Size(671, 240);
            this.pbBillentyuzet.TabIndex = 0;
            this.pbBillentyuzet.TabStop = false;
            this.pbBillentyuzet.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbBillentyuzet_MouseMove);
            this.pbBillentyuzet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(475, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "hhh";
            // 
            // keyboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbBillentyuzet);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "keyboard";
            this.Size = new System.Drawing.Size(671, 240);
            ((System.ComponentModel.ISupportInitialize)(this.pbBillentyuzet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBillentyuzet;
        private System.Windows.Forms.Label label1;
    }
}
