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
            this.ciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikkcsoportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.alcsoportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikkcsoportokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikkcsoportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alcsoportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.áfaKódokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mmafa_kodok = new System.Windows.Forms.ToolStripMenuItem();
            this.helyekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.készletkezelésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ttBevetelezes = new System.Windows.Forms.ToolStripMenuItem();
            this.készletkartonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraméterekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.riportokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mmRaktar = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 738);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1123, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asztalokToolStripMenuItem,
            this.törzsekToolStripMenuItem,
            this.készletkezelésToolStripMenuItem,
            this.paraméterekToolStripMenuItem,
            this.riportokToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1123, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // asztalokToolStripMenuItem
            // 
            this.asztalokToolStripMenuItem.Name = "asztalokToolStripMenuItem";
            this.asztalokToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.asztalokToolStripMenuItem.Text = "Asztalok";
            this.asztalokToolStripMenuItem.Click += new System.EventHandler(this.asztalokToolStripMenuItem_Click);
            // 
            // törzsekToolStripMenuItem
            // 
            this.törzsekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cikkekToolStripMenuItem,
            this.cikkcsoportokToolStripMenuItem,
            this.áfaKódokToolStripMenuItem});
            this.törzsekToolStripMenuItem.Name = "törzsekToolStripMenuItem";
            this.törzsekToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.törzsekToolStripMenuItem.Text = "Törzsek";
            // 
            // cikkekToolStripMenuItem
            // 
            this.cikkekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ciToolStripMenuItem,
            this.cikkcsoportToolStripMenuItem1,
            this.alcsoportToolStripMenuItem});
            this.cikkekToolStripMenuItem.Name = "cikkekToolStripMenuItem";
            this.cikkekToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cikkekToolStripMenuItem.Text = "Cikk";
            // 
            // ciToolStripMenuItem
            // 
            this.ciToolStripMenuItem.Name = "ciToolStripMenuItem";
            this.ciToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ciToolStripMenuItem.Text = "Cikkek";
            this.ciToolStripMenuItem.Click += new System.EventHandler(this.cikkekToolStripMenuItem_Click);
            // 
            // cikkcsoportToolStripMenuItem1
            // 
            this.cikkcsoportToolStripMenuItem1.Name = "cikkcsoportToolStripMenuItem1";
            this.cikkcsoportToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.cikkcsoportToolStripMenuItem1.Text = "Cikkcsoport";
            // 
            // alcsoportToolStripMenuItem
            // 
            this.alcsoportToolStripMenuItem.Name = "alcsoportToolStripMenuItem";
            this.alcsoportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.alcsoportToolStripMenuItem.Text = "Alcsoport";
            // 
            // cikkcsoportokToolStripMenuItem
            // 
            this.cikkcsoportokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cikkcsoportToolStripMenuItem,
            this.alcsoportToolStripMenuItem1});
            this.cikkcsoportokToolStripMenuItem.Name = "cikkcsoportokToolStripMenuItem";
            this.cikkcsoportokToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cikkcsoportokToolStripMenuItem.Text = "Cikkcsoport";
            // 
            // cikkcsoportToolStripMenuItem
            // 
            this.cikkcsoportToolStripMenuItem.Name = "cikkcsoportToolStripMenuItem";
            this.cikkcsoportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cikkcsoportToolStripMenuItem.Text = "Cikkcsoport";
            this.cikkcsoportToolStripMenuItem.Click += new System.EventHandler(this.cikkcsoportToolStripMenuItem_Click);
            // 
            // alcsoportToolStripMenuItem1
            // 
            this.alcsoportToolStripMenuItem1.Name = "alcsoportToolStripMenuItem1";
            this.alcsoportToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.alcsoportToolStripMenuItem1.Text = "Alcsoport";
            this.alcsoportToolStripMenuItem1.Click += new System.EventHandler(this.alcsoportToolStripMenuItem1_Click);
            // 
            // áfaKódokToolStripMenuItem
            // 
            this.áfaKódokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmafa_kodok,
            this.helyekToolStripMenuItem,
            this.mmRaktar});
            this.áfaKódokToolStripMenuItem.Name = "áfaKódokToolStripMenuItem";
            this.áfaKódokToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.áfaKódokToolStripMenuItem.Text = "Egyéb törzsek";
            // 
            // mmafa_kodok
            // 
            this.mmafa_kodok.Name = "mmafa_kodok";
            this.mmafa_kodok.Size = new System.Drawing.Size(152, 22);
            this.mmafa_kodok.Text = "Áfa kódok";
            this.mmafa_kodok.Click += new System.EventHandler(this.áfaKódokToolStripMenuItem1_Click);
            // 
            // helyekToolStripMenuItem
            // 
            this.helyekToolStripMenuItem.Name = "helyekToolStripMenuItem";
            this.helyekToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.helyekToolStripMenuItem.Text = "Helyek";
            this.helyekToolStripMenuItem.Click += new System.EventHandler(this.helyekToolStripMenuItem_Click);
            // 
            // készletkezelésToolStripMenuItem
            // 
            this.készletkezelésToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ttBevetelezes,
            this.készletkartonToolStripMenuItem});
            this.készletkezelésToolStripMenuItem.Name = "készletkezelésToolStripMenuItem";
            this.készletkezelésToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.készletkezelésToolStripMenuItem.Text = "Készletkezelés";
            // 
            // ttBevetelezes
            // 
            this.ttBevetelezes.Name = "ttBevetelezes";
            this.ttBevetelezes.Size = new System.Drawing.Size(152, 22);
            this.ttBevetelezes.Text = "Bevételezés";
            this.ttBevetelezes.Click += new System.EventHandler(this.ttBevetelezes_Click);
            // 
            // készletkartonToolStripMenuItem
            // 
            this.készletkartonToolStripMenuItem.Name = "készletkartonToolStripMenuItem";
            this.készletkartonToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.készletkartonToolStripMenuItem.Text = "Készletkarton";
            // 
            // paraméterekToolStripMenuItem
            // 
            this.paraméterekToolStripMenuItem.Name = "paraméterekToolStripMenuItem";
            this.paraméterekToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.paraméterekToolStripMenuItem.Text = "Paraméterek";
            // 
            // riportokToolStripMenuItem
            // 
            this.riportokToolStripMenuItem.Name = "riportokToolStripMenuItem";
            this.riportokToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.riportokToolStripMenuItem.Text = "Riportok";
            // 
            // mmRaktar
            // 
            this.mmRaktar.Name = "mmRaktar";
            this.mmRaktar.Size = new System.Drawing.Size(152, 22);
            this.mmRaktar.Text = "Raktárak";
            this.mmRaktar.Click += new System.EventHandler(this.mmRaktar_Click);
            // 
            // AdminTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 760);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip);
            this.IsMdiContainer = true;
            this.Name = "AdminTools";
            this.Text = "Adminisztrátori funkciók";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminTools_Load);
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
        private System.Windows.Forms.ToolStripMenuItem készletkezelésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ttBevetelezes;
        private System.Windows.Forms.ToolStripMenuItem készletkartonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cikkcsoportokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem áfaKódokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mmafa_kodok;
        private System.Windows.Forms.ToolStripMenuItem cikkcsoportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cikkcsoportToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem alcsoportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alcsoportToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helyekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mmRaktar;
    }
}



