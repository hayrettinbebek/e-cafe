namespace e_Cafe.Admin
{
    partial class frmParams2
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
            this.seSHOW_ORDER_BEFORE = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.seSHOW_ORDER_BEFORE.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // seSHOW_ORDER_BEFORE
            // 
            this.seSHOW_ORDER_BEFORE.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seSHOW_ORDER_BEFORE.Location = new System.Drawing.Point(137, 12);
            this.seSHOW_ORDER_BEFORE.Name = "seSHOW_ORDER_BEFORE";
            this.seSHOW_ORDER_BEFORE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seSHOW_ORDER_BEFORE.Size = new System.Drawing.Size(47, 20);
            this.seSHOW_ORDER_BEFORE.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(119, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Asztal foglalások jelzése ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(190, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(95, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "órával érkezés előtt";
            // 
            // frmParams2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 380);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.seSHOW_ORDER_BEFORE);
            this.Name = "frmParams2";
            this.Text = "Rendszerparaméterek";
            ((System.ComponentModel.ISupportInitialize)(this.seSHOW_ORDER_BEFORE.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SpinEdit seSHOW_ORDER_BEFORE;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}