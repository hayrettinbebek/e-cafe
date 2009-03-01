namespace e_Cafe.FrontOffice
{
    partial class frmUzenetek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUzenetek));
            this.button1 = new System.Windows.Forms.Button();
            this.ucMemo1 = new GUI.ucMemo();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(919, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 34);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ucMemo1
            // 
            this.ucMemo1.BackColor = System.Drawing.Color.Transparent;
            this.ucMemo1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucMemo1.BackgroundImage")));
            this.ucMemo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucMemo1.Location = new System.Drawing.Point(68, 55);
            this.ucMemo1.Name = "ucMemo1";
            this.ucMemo1.Size = new System.Drawing.Size(227, 259);
            this.ucMemo1.TabIndex = 3;
            // 
            // frmUzenetek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 583);
            this.ControlBox = false;
            this.Controls.Add(this.ucMemo1);
            this.Controls.Add(this.button1);
            this.Name = "frmUzenetek";
            this.Opacity = 0.95;
            this.ShowInTaskbar = false;
            this.TransparencyKey = System.Drawing.Color.White;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private GUI.ucMemo ucMemo1;
    }
}