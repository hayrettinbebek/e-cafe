namespace e_Cafe
{
    partial class AdminTools
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.asztalokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.törzsekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikkekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraméterekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.riportokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 482);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(878, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(38, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asztalokToolStripMenuItem,
            this.törzsekToolStripMenuItem,
            this.paraméterekToolStripMenuItem,
            this.riportokToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(878, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // asztalokToolStripMenuItem
            // 
            this.asztalokToolStripMenuItem.Name = "asztalokToolStripMenuItem";
            this.asztalokToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.asztalokToolStripMenuItem.Text = "Asztalok";
            this.asztalokToolStripMenuItem.Click += new System.EventHandler(this.asztalokToolStripMenuItem_Click);
            // 
            // törzsekToolStripMenuItem
            // 
            this.törzsekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cikkekToolStripMenuItem});
            this.törzsekToolStripMenuItem.Name = "törzsekToolStripMenuItem";
            this.törzsekToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.törzsekToolStripMenuItem.Text = "Törzsek";
            // 
            // cikkekToolStripMenuItem
            // 
            this.cikkekToolStripMenuItem.Name = "cikkekToolStripMenuItem";
            this.cikkekToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cikkekToolStripMenuItem.Text = "Cikkek";
            this.cikkekToolStripMenuItem.Click += new System.EventHandler(this.cikkekToolStripMenuItem_Click);
            // 
            // paraméterekToolStripMenuItem
            // 
            this.paraméterekToolStripMenuItem.Name = "paraméterekToolStripMenuItem";
            this.paraméterekToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.paraméterekToolStripMenuItem.Text = "Paraméterek";
            // 
            // riportokToolStripMenuItem
            // 
            this.riportokToolStripMenuItem.Name = "riportokToolStripMenuItem";
            this.riportokToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.riportokToolStripMenuItem.Text = "Riportok";
            // 
            // AdminTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 504);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip);
            this.IsMdiContainer = true;
            this.Name = "AdminTools";
            this.Text = "Adminisztrátori funkciók";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem asztalokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem törzsekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cikkekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraméterekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem riportokToolStripMenuItem;
    }
}



