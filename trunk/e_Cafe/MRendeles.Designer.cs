namespace e_Cafe
{
    partial class MRendeles
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
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pnlRendeles = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlButtonPlace = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnlButtons.SuspendLayout();
            this.pnlRendeles.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.Gray;
            this.pnlButtons.Controls.Add(this.pnlButtonPlace);
            this.pnlButtons.Controls.Add(this.panel5);
            this.pnlButtons.Controls.Add(this.panel6);
            this.pnlButtons.Controls.Add(this.panel2);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlButtons.Location = new System.Drawing.Point(0, 0);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(173, 624);
            this.pnlButtons.TabIndex = 0;
            this.pnlButtons.Click += new System.EventHandler(this.pnlButtons_Click);
            // 
            // pnlRendeles
            // 
            this.pnlRendeles.BackColor = System.Drawing.Color.Gray;
            this.pnlRendeles.Controls.Add(this.button4);
            this.pnlRendeles.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRendeles.Location = new System.Drawing.Point(703, 0);
            this.pnlRendeles.Name = "pnlRendeles";
            this.pnlRendeles.Size = new System.Drawing.Size(313, 624);
            this.pnlRendeles.TabIndex = 1;
            this.pnlRendeles.Click += new System.EventHandler(this.pnlRendeles_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(83, 441);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 39);
            this.button4.TabIndex = 0;
            this.button4.Text = "exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(173, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(530, 624);
            this.panel3.TabIndex = 1;
            this.panel3.Click += new System.EventHandler(this.panel3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 624);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1016, 117);
            this.panel4.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlButtonPlace
            // 
            this.pnlButtonPlace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtonPlace.Location = new System.Drawing.Point(16, 114);
            this.pnlButtonPlace.Name = "pnlButtonPlace";
            this.pnlButtonPlace.Size = new System.Drawing.Size(157, 381);
            this.pnlButtonPlace.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 114);
            this.panel2.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 114);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(16, 381);
            this.panel5.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 495);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(173, 129);
            this.panel6.TabIndex = 7;
            // 
            // MRendeles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 741);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlRendeles);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.panel4);
            this.Name = "MRendeles";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlButtons.ResumeLayout(false);
            this.pnlRendeles.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Panel pnlRendeles;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel pnlButtonPlace;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
    }
}