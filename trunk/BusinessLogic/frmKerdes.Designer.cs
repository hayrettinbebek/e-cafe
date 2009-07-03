namespace BusinessLogic
{
    partial class frmKerdes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKerdes));
            this.lblMessage = new System.Windows.Forms.RichTextBox();
            this.btnNem = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblMessage.Location = new System.Drawing.Point(12, 49);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(436, 128);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Text = "";
            // 
            // btnNem
            // 
            this.btnNem.BackColor = System.Drawing.Color.Transparent;
            this.btnNem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNem.BackgroundImage")));
            this.btnNem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNem.FlatAppearance.BorderSize = 0;
            this.btnNem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNem.Location = new System.Drawing.Point(360, 195);
            this.btnNem.Name = "btnNem";
            this.btnNem.Size = new System.Drawing.Size(39, 45);
            this.btnNem.TabIndex = 5;
            this.btnNem.UseVisualStyleBackColor = false;
            this.btnNem.Click += new System.EventHandler(this.btnNem_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOk.BackgroundImage")));
            this.btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Location = new System.Drawing.Point(105, 195);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(39, 45);
            this.btnOk.TabIndex = 5;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmKerdes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(460, 242);
            this.ControlBox = false;
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnNem);
            this.Controls.Add(this.lblMessage);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKerdes";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox lblMessage;
        private System.Windows.Forms.Button btnNem;
        private System.Windows.Forms.Button btnOk;
    }
}