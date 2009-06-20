namespace e_Cafe.FrontOffice
{
    partial class frmMediaPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMediaPlayer));
            this.psVolume = new System.Windows.Forms.ProgressBar();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnFW = new System.Windows.Forms.Button();
            this.btnRW = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // psVolume
            // 
            this.psVolume.Location = new System.Drawing.Point(250, 83);
            this.psVolume.Maximum = 255;
            this.psVolume.Name = "psVolume";
            this.psVolume.Size = new System.Drawing.Size(334, 23);
            this.psVolume.Step = 1;
            this.psVolume.TabIndex = 2;
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.Transparent;
            this.btnUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUp.BackgroundImage")));
            this.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUp.FlatAppearance.BorderSize = 0;
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.Location = new System.Drawing.Point(269, 12);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(65, 65);
            this.btnUp.TabIndex = 3;
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.Transparent;
            this.btnDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDown.BackgroundImage")));
            this.btnDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDown.FlatAppearance.BorderSize = 0;
            this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDown.Location = new System.Drawing.Point(269, 124);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(65, 65);
            this.btnDown.TabIndex = 4;
            this.btnDown.Text = "button3";
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.BackgroundImage")));
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Location = new System.Drawing.Point(86, 12);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(65, 65);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnFW
            // 
            this.btnFW.BackColor = System.Drawing.Color.Transparent;
            this.btnFW.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFW.BackgroundImage")));
            this.btnFW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFW.FlatAppearance.BorderSize = 0;
            this.btnFW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFW.Location = new System.Drawing.Point(157, 74);
            this.btnFW.Name = "btnFW";
            this.btnFW.Size = new System.Drawing.Size(65, 65);
            this.btnFW.TabIndex = 3;
            this.btnFW.UseVisualStyleBackColor = false;
            this.btnFW.Click += new System.EventHandler(this.btnFW_Click);
            // 
            // btnRW
            // 
            this.btnRW.BackColor = System.Drawing.Color.Transparent;
            this.btnRW.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRW.BackgroundImage")));
            this.btnRW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRW.FlatAppearance.BorderSize = 0;
            this.btnRW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRW.Location = new System.Drawing.Point(12, 74);
            this.btnRW.Name = "btnRW";
            this.btnRW.Size = new System.Drawing.Size(65, 65);
            this.btnRW.TabIndex = 3;
            this.btnRW.UseVisualStyleBackColor = false;
            this.btnRW.Click += new System.EventHandler(this.btnRW_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStop.BackgroundImage")));
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Location = new System.Drawing.Point(86, 74);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(65, 65);
            this.btnStop.TabIndex = 3;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Transparent;
            this.button12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button12.BackgroundImage")));
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(545, 12);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(39, 45);
            this.button12.TabIndex = 5;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // frmMediaPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(596, 574);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRW);
            this.Controls.Add(this.btnFW);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.psVolume);
            this.Name = "frmMediaPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMediaPlayer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar psVolume;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnFW;
        private System.Windows.Forms.Button btnRW;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button button12;
    }
}