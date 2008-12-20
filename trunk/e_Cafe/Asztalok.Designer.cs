using GUI;

namespace e_Cafe
{
    partial class Asztalok
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Asztalok));
            this.AsztalType1List = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AsztalType1List
            // 
            this.AsztalType1List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("AsztalType1List.ImageStream")));
            this.AsztalType1List.TransparentColor = System.Drawing.Color.Transparent;
            this.AsztalType1List.Images.SetKeyName(0, "asztal_zold_T.bmp");
            this.AsztalType1List.Images.SetKeyName(1, "asztal_normal_T.bmp");
            this.AsztalType1List.Images.SetKeyName(2, "asztal_piros_T.bmp");
            this.AsztalType1List.Images.SetKeyName(3, "asztal_sarga_T.bmp");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Asztalok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.label1);
            this.Name = "Asztalok";
            this.Size = new System.Drawing.Size(743, 418);
            this.Click += new System.EventHandler(this.Asztalok_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Asztalok_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList AsztalType1List;
        private System.Windows.Forms.Label label1;
    }
}
