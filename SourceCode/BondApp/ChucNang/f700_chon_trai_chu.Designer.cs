namespace BondApp
{
    partial class f700_chon_trai_chu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f700_chon_trai_chu));
            this.m_lbl_ma_so_trai_phieu = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.m_lbl_ten_khach_hang_cam_co = new System.Windows.Forms.Label();
            this.m_txt_ten_khach_hang_cam_co = new System.Windows.Forms.TextBox();
            this.c1FlexGrid1 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_lbl_title = new System.Windows.Forms.Label();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            this.m_pnl_out_place_dm.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_lbl_ma_so_trai_phieu
            // 
            this.m_lbl_ma_so_trai_phieu.AutoSize = true;
            this.m_lbl_ma_so_trai_phieu.Location = new System.Drawing.Point(18, 89);
            this.m_lbl_ma_so_trai_phieu.Name = "m_lbl_ma_so_trai_phieu";
            this.m_lbl_ma_so_trai_phieu.Size = new System.Drawing.Size(82, 13);
            this.m_lbl_ma_so_trai_phieu.TabIndex = 40;
            this.m_lbl_ma_so_trai_phieu.Text = "Mã số trái phiếu";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 20);
            this.textBox1.TabIndex = 41;
            // 
            // m_lbl_ten_khach_hang_cam_co
            // 
            this.m_lbl_ten_khach_hang_cam_co.AutoSize = true;
            this.m_lbl_ten_khach_hang_cam_co.Location = new System.Drawing.Point(12, 63);
            this.m_lbl_ten_khach_hang_cam_co.Name = "m_lbl_ten_khach_hang_cam_co";
            this.m_lbl_ten_khach_hang_cam_co.Size = new System.Drawing.Size(90, 13);
            this.m_lbl_ten_khach_hang_cam_co.TabIndex = 38;
            this.m_lbl_ten_khach_hang_cam_co.Text = "Số CMND/ĐKKD";
            // 
            // m_txt_ten_khach_hang_cam_co
            // 
            this.m_txt_ten_khach_hang_cam_co.Location = new System.Drawing.Point(108, 60);
            this.m_txt_ten_khach_hang_cam_co.Name = "m_txt_ten_khach_hang_cam_co";
            this.m_txt_ten_khach_hang_cam_co.Size = new System.Drawing.Size(158, 20);
            this.m_txt_ten_khach_hang_cam_co.TabIndex = 39;
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.ColumnInfo = resources.GetString("c1FlexGrid1.ColumnInfo");
            this.c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.c1FlexGrid1.Location = new System.Drawing.Point(0, 112);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Size = new System.Drawing.Size(344, 54);
            this.c1FlexGrid1.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("c1FlexGrid1.Styles"));
            this.c1FlexGrid1.TabIndex = 37;
            // 
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_delete);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 166);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(344, 36);
            this.m_pnl_out_place_dm.TabIndex = 35;
            // 
            // m_lbl_title
            // 
            this.m_lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_title.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_title.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_title.Name = "m_lbl_title";
            this.m_lbl_title.Size = new System.Drawing.Size(344, 40);
            this.m_lbl_title.TabIndex = 36;
            this.m_lbl_title.Text = "F700 - Chọn trái chủ";
            this.m_lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_cmd_delete
            // 
            this.m_cmd_delete.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_delete.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_delete.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_delete.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_delete.Image")));
            this.m_cmd_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_delete.Location = new System.Drawing.Point(164, 4);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_delete.TabIndex = 4;
            this.m_cmd_delete.Text = "&Chọn";
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_exit.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_exit.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_exit.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_exit.Image")));
            this.m_cmd_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_exit.Location = new System.Drawing.Point(252, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 3;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // f700_chon_trai_chu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 202);
            this.Controls.Add(this.m_lbl_ma_so_trai_phieu);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.m_lbl_ten_khach_hang_cam_co);
            this.Controls.Add(this.m_txt_ten_khach_hang_cam_co);
            this.Controls.Add(this.c1FlexGrid1);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Controls.Add(this.m_lbl_title);
            this.Name = "f700_chon_trai_chu";
            this.Text = "F700 - Chon trai chu";
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            this.m_pnl_out_place_dm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_lbl_ma_so_trai_phieu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label m_lbl_ten_khach_hang_cam_co;
        private System.Windows.Forms.TextBox m_txt_ten_khach_hang_cam_co;
        private C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid1;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        internal SIS.Controls.Button.SiSButton m_cmd_delete;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        private System.Windows.Forms.Label m_lbl_title;
    }
}