namespace BondApp.ChucNang
{
    partial class f950_quan_ly_tra_goc
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
            this.m_lbl_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_lbl_title
            // 
            this.m_lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_title.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_title.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_title.Name = "m_lbl_title";
            this.m_lbl_title.Size = new System.Drawing.Size(834, 40);
            this.m_lbl_title.TabIndex = 3;
            this.m_lbl_title.Text = "F950 - Quản lý trả gốc";
            this.m_lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m_lbl_title.UseMnemonic = false;
            // 
            // f950_quan_ly_tra_goc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 262);
            this.Controls.Add(this.m_lbl_title);
            this.Name = "f950_quan_ly_tra_goc";
            this.Text = "f950_quan_ly_tra_goc";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label m_lbl_title;
    }
}