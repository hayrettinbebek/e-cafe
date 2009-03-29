namespace BusinessLogic
{
    partial class frmProgress
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
            this.pg = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // pg
            // 
            this.pg.Location = new System.Drawing.Point(2, 1);
            this.pg.Name = "pg";
            this.pg.Size = new System.Drawing.Size(494, 57);
            this.pg.TabIndex = 0;
            // 
            // frmProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 81);
            this.ControlBox = false;
            this.Controls.Add(this.pg);
            this.Name = "frmProgress";
            this.Text = "frmProgress";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ProgressBar pg;

    }
}