///************************************************
/// Generated by: LinhDH
/// Date: 25/10/2012 05:41:37
/// Goal: Create Form for V_DM_THAM_SO_NHAC_VIEC
///************************************************


using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPData;
using IP.Core.IPUserService;

using BondUS;
using BondDS;
using BondDS.CDBNames;

using C1.Win.C1FlexGrid;

namespace BondApp
{



	public class f106_dm_tham_so_nhac_viec : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.ImageList ImageList;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
		internal SIS.Controls.Button.SiSButton m_cmd_delete;
        internal SIS.Controls.Button.SiSButton m_cmd_update;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        private Label m_lbl_title;
        private GroupBox m_gru_thong_tin_trai_phieu;
        private Label label;
        private Label m_lbl_ngay_phat_hanh;
        private TextBox m_txt_ngay_thuc_hien_truoc;
        private ComboBox m_cbo_loai_nhac_viec;
        private Label label2;
        private TextBox m_txt_noi_dung_nhac;
        internal SIS.Controls.Button.SiSButton m_cmd_luu;
        private ComboBox m_cbo_truoc_sau;
        private Label label3;
        private Label label4;
        private TextBox m_txt_so_ngay_nhac_truoc;
        private C1FlexGrid m_fg;
        private Label label5;
        private TextBox m_txt_ghi_chu;
        private ComboBox m_cbo_ngay_lam_viec_yn;
		private System.ComponentModel.IContainer components;

		public f106_dm_tham_so_nhac_viec()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			format_controls();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f106_dm_tham_so_nhac_viec));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_lbl_title = new System.Windows.Forms.Label();
            this.m_gru_thong_tin_trai_phieu = new System.Windows.Forms.GroupBox();
            this.m_cbo_ngay_lam_viec_yn = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.m_txt_so_ngay_nhac_truoc = new System.Windows.Forms.TextBox();
            this.m_cbo_truoc_sau = new System.Windows.Forms.ComboBox();
            this.m_cmd_luu = new SIS.Controls.Button.SiSButton();
            this.m_cbo_loai_nhac_viec = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_lbl_ngay_phat_hanh = new System.Windows.Forms.Label();
            this.m_txt_ghi_chu = new System.Windows.Forms.TextBox();
            this.m_txt_noi_dung_nhac = new System.Windows.Forms.TextBox();
            this.m_txt_ngay_thuc_hien_truoc = new System.Windows.Forms.TextBox();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_pnl_out_place_dm.SuspendLayout();
            this.m_gru_thong_tin_trai_phieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "");
            this.ImageList.Images.SetKeyName(1, "");
            this.ImageList.Images.SetKeyName(2, "");
            this.ImageList.Images.SetKeyName(3, "");
            this.ImageList.Images.SetKeyName(4, "");
            this.ImageList.Images.SetKeyName(5, "");
            this.ImageList.Images.SetKeyName(6, "");
            this.ImageList.Images.SetKeyName(7, "");
            this.ImageList.Images.SetKeyName(8, "");
            this.ImageList.Images.SetKeyName(9, "");
            this.ImageList.Images.SetKeyName(10, "");
            this.ImageList.Images.SetKeyName(11, "");
            this.ImageList.Images.SetKeyName(12, "");
            this.ImageList.Images.SetKeyName(13, "");
            this.ImageList.Images.SetKeyName(14, "");
            this.ImageList.Images.SetKeyName(15, "");
            this.ImageList.Images.SetKeyName(16, "");
            this.ImageList.Images.SetKeyName(17, "");
            this.ImageList.Images.SetKeyName(18, "");
            this.ImageList.Images.SetKeyName(19, "");
            this.ImageList.Images.SetKeyName(20, "");
            this.ImageList.Images.SetKeyName(21, "");
            // 
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_update);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_delete);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 464);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(860, 36);
            this.m_pnl_out_place_dm.TabIndex = 19;
            // 
            // m_cmd_update
            // 
            this.m_cmd_update.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_update.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_update.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_update.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_update.ImageIndex = 3;
            this.m_cmd_update.ImageList = this.ImageList;
            this.m_cmd_update.Location = new System.Drawing.Point(592, 4);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_update.TabIndex = 0;
            this.m_cmd_update.Text = "&Sửa";
            // 
            // m_cmd_delete
            // 
            this.m_cmd_delete.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_delete.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_delete.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_delete.ImageIndex = 4;
            this.m_cmd_delete.ImageList = this.ImageList;
            this.m_cmd_delete.Location = new System.Drawing.Point(680, 4);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_delete.TabIndex = 1;
            this.m_cmd_delete.Text = "&Xoá";
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_exit.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_exit.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_exit.ImageIndex = 12;
            this.m_cmd_exit.ImageList = this.ImageList;
            this.m_cmd_exit.Location = new System.Drawing.Point(768, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 2;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_lbl_title
            // 
            this.m_lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_title.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_title.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_title.Name = "m_lbl_title";
            this.m_lbl_title.Size = new System.Drawing.Size(860, 34);
            this.m_lbl_title.TabIndex = 21;
            this.m_lbl_title.Text = "F106 - Tham số nhắc việc";
            this.m_lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_gru_thong_tin_trai_phieu
            // 
            this.m_gru_thong_tin_trai_phieu.Controls.Add(this.m_cbo_ngay_lam_viec_yn);
            this.m_gru_thong_tin_trai_phieu.Controls.Add(this.label3);
            this.m_gru_thong_tin_trai_phieu.Controls.Add(this.label4);
            this.m_gru_thong_tin_trai_phieu.Controls.Add(this.m_txt_so_ngay_nhac_truoc);
            this.m_gru_thong_tin_trai_phieu.Controls.Add(this.m_cbo_truoc_sau);
            this.m_gru_thong_tin_trai_phieu.Controls.Add(this.m_cmd_luu);
            this.m_gru_thong_tin_trai_phieu.Controls.Add(this.m_cbo_loai_nhac_viec);
            this.m_gru_thong_tin_trai_phieu.Controls.Add(this.label);
            this.m_gru_thong_tin_trai_phieu.Controls.Add(this.label5);
            this.m_gru_thong_tin_trai_phieu.Controls.Add(this.label2);
            this.m_gru_thong_tin_trai_phieu.Controls.Add(this.m_lbl_ngay_phat_hanh);
            this.m_gru_thong_tin_trai_phieu.Controls.Add(this.m_txt_ghi_chu);
            this.m_gru_thong_tin_trai_phieu.Controls.Add(this.m_txt_noi_dung_nhac);
            this.m_gru_thong_tin_trai_phieu.Controls.Add(this.m_txt_ngay_thuc_hien_truoc);
            this.m_gru_thong_tin_trai_phieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_gru_thong_tin_trai_phieu.Location = new System.Drawing.Point(0, 34);
            this.m_gru_thong_tin_trai_phieu.Name = "m_gru_thong_tin_trai_phieu";
            this.m_gru_thong_tin_trai_phieu.Size = new System.Drawing.Size(860, 201);
            this.m_gru_thong_tin_trai_phieu.TabIndex = 22;
            this.m_gru_thong_tin_trai_phieu.TabStop = false;
            this.m_gru_thong_tin_trai_phieu.Text = "Thông tin nhắc việc";
            // 
            // m_cbo_ngay_lam_viec_yn
            // 
            this.m_cbo_ngay_lam_viec_yn.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.m_cbo_ngay_lam_viec_yn.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.m_cbo_ngay_lam_viec_yn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_ngay_lam_viec_yn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.m_cbo_ngay_lam_viec_yn.FormattingEnabled = true;
            this.m_cbo_ngay_lam_viec_yn.Items.AddRange(new object[] {
            "Ngày thường",
            "Ngày làm việc"});
            this.m_cbo_ngay_lam_viec_yn.Location = new System.Drawing.Point(274, 93);
            this.m_cbo_ngay_lam_viec_yn.MaxDropDownItems = 5;
            this.m_cbo_ngay_lam_viec_yn.Name = "m_cbo_ngay_lam_viec_yn";
            this.m_cbo_ngay_lam_viec_yn.Size = new System.Drawing.Size(124, 21);
            this.m_cbo_ngay_lam_viec_yn.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "ngày";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Nhắc trước";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_txt_so_ngay_nhac_truoc
            // 
            this.m_txt_so_ngay_nhac_truoc.BackColor = System.Drawing.Color.White;
            this.m_txt_so_ngay_nhac_truoc.Location = new System.Drawing.Point(128, 126);
            this.m_txt_so_ngay_nhac_truoc.Name = "m_txt_so_ngay_nhac_truoc";
            this.m_txt_so_ngay_nhac_truoc.Size = new System.Drawing.Size(65, 20);
            this.m_txt_so_ngay_nhac_truoc.TabIndex = 4;
            this.m_txt_so_ngay_nhac_truoc.TabStop = false;
            this.m_txt_so_ngay_nhac_truoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // m_cbo_truoc_sau
            // 
            this.m_cbo_truoc_sau.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.m_cbo_truoc_sau.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.m_cbo_truoc_sau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_truoc_sau.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.m_cbo_truoc_sau.FormattingEnabled = true;
            this.m_cbo_truoc_sau.Items.AddRange(new object[] {
            "Trước",
            "Sau"});
            this.m_cbo_truoc_sau.Location = new System.Drawing.Point(127, 93);
            this.m_cbo_truoc_sau.MaxDropDownItems = 5;
            this.m_cbo_truoc_sau.Name = "m_cbo_truoc_sau";
            this.m_cbo_truoc_sau.Size = new System.Drawing.Size(66, 21);
            this.m_cbo_truoc_sau.TabIndex = 1;
            // 
            // m_cmd_luu
            // 
            this.m_cmd_luu.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_luu.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_luu.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_luu.ImageIndex = 10;
            this.m_cmd_luu.ImageList = this.ImageList;
            this.m_cmd_luu.Location = new System.Drawing.Point(59, 162);
            this.m_cmd_luu.Name = "m_cmd_luu";
            this.m_cmd_luu.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_luu.TabIndex = 6;
            this.m_cmd_luu.Text = "&Lưu";
            // 
            // m_cbo_loai_nhac_viec
            // 
            this.m_cbo_loai_nhac_viec.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.m_cbo_loai_nhac_viec.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.m_cbo_loai_nhac_viec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_loai_nhac_viec.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.m_cbo_loai_nhac_viec.FormattingEnabled = true;
            this.m_cbo_loai_nhac_viec.Location = new System.Drawing.Point(128, 23);
            this.m_cbo_loai_nhac_viec.MaxDropDownItems = 5;
            this.m_cbo_loai_nhac_viec.Name = "m_cbo_loai_nhac_viec";
            this.m_cbo_loai_nhac_viec.Size = new System.Drawing.Size(327, 21);
            this.m_cbo_loai_nhac_viec.TabIndex = 0;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(39, 28);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(77, 13);
            this.label.TabIndex = 34;
            this.label.Text = "Loại nhắc việc";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Ghi chú";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nội dung nhắc";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_lbl_ngay_phat_hanh
            // 
            this.m_lbl_ngay_phat_hanh.AutoSize = true;
            this.m_lbl_ngay_phat_hanh.Location = new System.Drawing.Point(56, 101);
            this.m_lbl_ngay_phat_hanh.Name = "m_lbl_ngay_phat_hanh";
            this.m_lbl_ngay_phat_hanh.Size = new System.Drawing.Size(55, 13);
            this.m_lbl_ngay_phat_hanh.TabIndex = 37;
            this.m_lbl_ngay_phat_hanh.Text = "Thực hiện";
            this.m_lbl_ngay_phat_hanh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_txt_ghi_chu
            // 
            this.m_txt_ghi_chu.BackColor = System.Drawing.Color.White;
            this.m_txt_ghi_chu.Location = new System.Drawing.Point(323, 128);
            this.m_txt_ghi_chu.Name = "m_txt_ghi_chu";
            this.m_txt_ghi_chu.Size = new System.Drawing.Size(495, 20);
            this.m_txt_ghi_chu.TabIndex = 5;
            this.m_txt_ghi_chu.TabStop = false;
            // 
            // m_txt_noi_dung_nhac
            // 
            this.m_txt_noi_dung_nhac.BackColor = System.Drawing.Color.White;
            this.m_txt_noi_dung_nhac.Location = new System.Drawing.Point(128, 59);
            this.m_txt_noi_dung_nhac.Name = "m_txt_noi_dung_nhac";
            this.m_txt_noi_dung_nhac.Size = new System.Drawing.Size(690, 20);
            this.m_txt_noi_dung_nhac.TabIndex = 3;
            this.m_txt_noi_dung_nhac.TabStop = false;
            // 
            // m_txt_ngay_thuc_hien_truoc
            // 
            this.m_txt_ngay_thuc_hien_truoc.BackColor = System.Drawing.Color.White;
            this.m_txt_ngay_thuc_hien_truoc.Location = new System.Drawing.Point(199, 93);
            this.m_txt_ngay_thuc_hien_truoc.Name = "m_txt_ngay_thuc_hien_truoc";
            this.m_txt_ngay_thuc_hien_truoc.Size = new System.Drawing.Size(53, 20);
            this.m_txt_ngay_thuc_hien_truoc.TabIndex = 2;
            this.m_txt_ngay_thuc_hien_truoc.TabStop = false;
            this.m_txt_ngay_thuc_hien_truoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_fg.Location = new System.Drawing.Point(0, 235);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(860, 229);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 23;
            // 
            // f106_dm_tham_so_nhac_viec
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(860, 500);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.m_gru_thong_tin_trai_phieu);
            this.Controls.Add(this.m_lbl_title);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f106_dm_tham_so_nhac_viec";
            this.Text = "F106 - Tham số nhắc việc";
            this.Load += new System.EventHandler(this.f106_dm_tham_so_nhac_viec_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            this.m_gru_thong_tin_trai_phieu.ResumeLayout(false);
            this.m_gru_thong_tin_trai_phieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region Public Interface
		public void display(){			
			this.ShowDialog();
		}
		#endregion

		#region Data Structure
		private enum e_col_Number{
            NGAY_LAM_VIEC_YN = 4
  ,
            GHI_CHU = 6
                ,
            LOAI_NHAC_VIEC = 1
                ,
            NOI_DUNG_NHAC = 2
                ,
            SO_NGAY_LAM_TRUOC_NGAY_CHINH = 3
                , SO_NGAY_NHAC_TRUOC = 5
		}			
		#endregion

		#region Members
		ITransferDataRow m_obj_trans;		
		DS_V_DM_THAM_SO_NHAC_VIEC m_ds = new DS_V_DM_THAM_SO_NHAC_VIEC();
		US_V_DM_THAM_SO_NHAC_VIEC m_us = new US_V_DM_THAM_SO_NHAC_VIEC();
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.ViewDataState;
		#endregion

		#region Private Methods
		private void format_controls(){
			CControlFormat.setFormStyle(this);
			CControlFormat.setC1FlexFormat(m_fg);
            m_lbl_title.Font = new Font("Arial", 16);
            m_lbl_title.ForeColor = Color.DarkRed;
            m_lbl_title.TextAlign = ContentAlignment.MiddleCenter;
            m_fg.Tree.Column = (int)e_col_Number.NOI_DUNG_NHAC;
            m_fg.Tree.Style = TreeStyleFlags.SimpleLeaf;
            m_fg.Cols[(int)e_col_Number.LOAI_NHAC_VIEC].Visible = false;
			set_define_events();
			this.KeyPreview = true;		
		}
		private void set_initial_form_load(){						
			m_obj_trans = get_trans_object(m_fg);
            load_data_2_cbo_loai_nhac_viec();
            m_cbo_ngay_lam_viec_yn.SelectedIndex = 0;
            m_cbo_truoc_sau.SelectedIndex = 0;
			load_data_2_grid();		
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
			Hashtable v_htb = new Hashtable();
            v_htb.Add(V_DM_THAM_SO_NHAC_VIEC.NGAY_LAM_VIEC_YN, e_col_Number.NGAY_LAM_VIEC_YN);
            v_htb.Add(V_DM_THAM_SO_NHAC_VIEC.GHI_CHU, e_col_Number.GHI_CHU);
            v_htb.Add(V_DM_THAM_SO_NHAC_VIEC.LOAI_NHAC_VIEC, e_col_Number.LOAI_NHAC_VIEC);
            v_htb.Add(V_DM_THAM_SO_NHAC_VIEC.NOI_DUNG_NHAC, e_col_Number.NOI_DUNG_NHAC);
            v_htb.Add(V_DM_THAM_SO_NHAC_VIEC.SO_NGAY_LAM_TRUOC_NGAY_CHINH, e_col_Number.SO_NGAY_LAM_TRUOC_NGAY_CHINH);
            v_htb.Add(V_DM_THAM_SO_NHAC_VIEC.SO_NGAY_NHAC_TRUOC, e_col_Number.SO_NGAY_NHAC_TRUOC);									
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_ds.V_DM_THAM_SO_NHAC_VIEC.NewRow());
			return v_obj_trans;			
		}
		private void load_data_2_grid(){						
			m_ds = new DS_V_DM_THAM_SO_NHAC_VIEC();
            m_us.FillDataset(m_ds, " ORDER BY " + V_DM_THAM_SO_NHAC_VIEC.ID_LOAI_NHAC_VIEC);
			m_fg.Redraw = false;
			CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            //CGridUtils.MakeSoTT((int)e_col_Number.STT, m_fg);
            for (int v_i_grid_row = m_fg.Rows.Fixed; v_i_grid_row < m_fg.Rows.Count; v_i_grid_row++)
            {
                m_fg[v_i_grid_row, (int)e_col_Number.NOI_DUNG_NHAC] = convert_noi_dung_nhac(v_i_grid_row);
                m_fg[v_i_grid_row, (int)e_col_Number.SO_NGAY_LAM_TRUOC_NGAY_CHINH] = convert_ngay_thuc_hien(v_i_grid_row);
            }
            m_fg.Subtotal(AggregateEnum.None
             , 0
             , (int)e_col_Number.LOAI_NHAC_VIEC
             , (int)e_col_Number.NOI_DUNG_NHAC
             , "{0}");
			m_fg.Redraw = true;
            CGridUtils.stand_on_TopLeft_Cell(m_fg);
		}
		private void grid2us_object(US_V_DM_THAM_SO_NHAC_VIEC i_us
			, int i_grid_row) {
			DataRow v_dr;
			v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
			i_us.DataRow2Me(v_dr);
		}
        private void us_obj_2_form(US_V_DM_THAM_SO_NHAC_VIEC ip_us_tham_so_nhac_viec)
        {
            m_txt_noi_dung_nhac.Text = ip_us_tham_so_nhac_viec.strNOI_DUNG_NHAC;
            US_V_DM_THAM_SO_NHAC_VIEC v_us_nhac_viec = new US_V_DM_THAM_SO_NHAC_VIEC(ip_us_tham_so_nhac_viec.dcID);
            if (v_us_nhac_viec.dcSO_NGAY_LAM_TRUOC_NGAY_CHINH > 0)
            {
                m_txt_ngay_thuc_hien_truoc.Text = CIPConvert.ToStr(v_us_nhac_viec.dcSO_NGAY_LAM_TRUOC_NGAY_CHINH, "#,###");
                m_cbo_truoc_sau.SelectedIndex = 0;
            }
            else
            {
                m_txt_ngay_thuc_hien_truoc.Text = CIPConvert.ToStr(v_us_nhac_viec.dcSO_NGAY_LAM_TRUOC_NGAY_CHINH * (-1), "#,###");
                m_cbo_truoc_sau.SelectedIndex = 1;
            }
            m_cbo_loai_nhac_viec.SelectedValue = ip_us_tham_so_nhac_viec.dcID_LOAI_NHAC_VIEC;
            m_txt_so_ngay_nhac_truoc.Text = CIPConvert.ToStr(ip_us_tham_so_nhac_viec.dcSO_NGAY_NHAC_TRUOC,"#,###");
            m_txt_ghi_chu.Text = ip_us_tham_so_nhac_viec.strGHI_CHU;
            if (ip_us_tham_so_nhac_viec.strNGAY_LAM_VIEC_YN == "Y") m_cbo_ngay_lam_viec_yn.SelectedIndex = 1;
            else m_cbo_ngay_lam_viec_yn.SelectedIndex = 0;
        }
        private void form_2_us_object(US_V_DM_THAM_SO_NHAC_VIEC op_us_tham_so_nhac_viec)
        {
            op_us_tham_so_nhac_viec.strNOI_DUNG_NHAC = m_txt_noi_dung_nhac.Text.Trim();
            op_us_tham_so_nhac_viec.dcSO_NGAY_NHAC_TRUOC = CIPConvert.ToDecimal(m_txt_so_ngay_nhac_truoc.Text);
            op_us_tham_so_nhac_viec.dcID_LOAI_NHAC_VIEC = CIPConvert.ToDecimal(m_cbo_loai_nhac_viec.SelectedValue);
            op_us_tham_so_nhac_viec.strGHI_CHU = m_txt_ghi_chu.Text.Trim();
            if(m_cbo_truoc_sau.SelectedIndex == 0)
                op_us_tham_so_nhac_viec.dcSO_NGAY_LAM_TRUOC_NGAY_CHINH = CIPConvert.ToDecimal(m_txt_ngay_thuc_hien_truoc.Text);
            else op_us_tham_so_nhac_viec.dcSO_NGAY_LAM_TRUOC_NGAY_CHINH = CIPConvert.ToDecimal(m_txt_ngay_thuc_hien_truoc.Text) * (-1);
            if (m_cbo_ngay_lam_viec_yn.SelectedIndex == 0) op_us_tham_so_nhac_viec.strNGAY_LAM_VIEC_YN = "N";
            else op_us_tham_so_nhac_viec.strNGAY_LAM_VIEC_YN = "Y";
            op_us_tham_so_nhac_viec.dcID_TRAI_PHIEU = 1;
        }
        private void load_data_2_cbo_loai_nhac_viec()
        {
            US_CM_DM_TU_DIEN v_us_cm_dm_tu_dien = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_cm_dm_tu_dien = new DS_CM_DM_TU_DIEN();
            v_ds_cm_dm_tu_dien = v_us_cm_dm_tu_dien.getLoaiTuDienDS(CM_DM_DS_LOAI_TU_DIEN.LOAI_NHAC_NHAC_VIEC);
            m_cbo_loai_nhac_viec.DataSource = v_ds_cm_dm_tu_dien.Tables[0];
            m_cbo_loai_nhac_viec.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_cbo_loai_nhac_viec.ValueMember = CM_DM_TU_DIEN.ID;
        }
        private void reset_controls()
        {
            m_txt_ngay_thuc_hien_truoc.Text = "";
            m_txt_noi_dung_nhac.Text = "";
            m_cbo_loai_nhac_viec.SelectedIndex = 0;
            m_txt_so_ngay_nhac_truoc.Text = "";
            m_txt_ghi_chu.Text = "";
        }
        private bool check_data_is_ok()
        {
            if (!CValidateTextBox.IsValid(m_txt_ngay_thuc_hien_truoc, DataType.NumberType, allowNull.NO, true))
            {
                m_txt_ngay_thuc_hien_truoc.Focus();
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_noi_dung_nhac, DataType.StringType, allowNull.NO, true))
            {
                m_txt_noi_dung_nhac.Focus();
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_so_ngay_nhac_truoc, DataType.NumberType, allowNull.NO, true))
            {
                m_txt_so_ngay_nhac_truoc.Focus();
                return false;
            }
            return true;
        }
        private decimal convert_ngay_thuc_hien(int ip_grid_row)
        {
            decimal v_dc_content;
            if (CIPConvert.ToDecimal(m_fg[ip_grid_row, (int)e_col_Number.SO_NGAY_LAM_TRUOC_NGAY_CHINH]) < 0)
            {
                v_dc_content = CIPConvert.ToDecimal(m_fg[ip_grid_row, (int)e_col_Number.SO_NGAY_LAM_TRUOC_NGAY_CHINH]) * (-1);
            }
            else v_dc_content = CIPConvert.ToDecimal(m_fg[ip_grid_row, (int)e_col_Number.SO_NGAY_LAM_TRUOC_NGAY_CHINH]);
            return v_dc_content;
        }
        private string convert_noi_dung_nhac(int ip_grid_row)
        {
            string v_str_content;
            if (CIPConvert.ToDecimal(m_fg[ip_grid_row, (int)e_col_Number.SO_NGAY_LAM_TRUOC_NGAY_CHINH]) > 0)
            {
                v_str_content = CIPConvert.ToStr(m_fg[ip_grid_row, (int)e_col_Number.NOI_DUNG_NHAC]) + " thực hiện trước ";
            }
            else
            {
                v_str_content = CIPConvert.ToStr(m_fg[ip_grid_row, (int)e_col_Number.NOI_DUNG_NHAC]) + " thực hiện sau ";
            }
            return v_str_content;
        }
        private string convert_ngay_lam_viec_yn_to_string(int ip_grid_row)
        {
            string v_str_content;
            if (CIPConvert.ToStr(m_fg[ip_grid_row, (int)e_col_Number.NGAY_LAM_VIEC_YN]) == "Y")
            {
                v_str_content = " ngày làm việc";
            }
            else
            {
                v_str_content = " ngày thường";
            }
            return v_str_content;
        }
		private void us_object2grid(US_V_DM_THAM_SO_NHAC_VIEC i_us
			, int i_grid_row) {
			DataRow v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			i_us.Me2DataRow(v_dr);
			m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
		}        
		private void insert_v_dm_tham_so_nhac_viec(){			
		//	f106_dm_tham_so_nhac_viec_DE v_fDE = new  f106_dm_tham_so_nhac_viec_DE();								
		//	v_fDE.display();
			load_data_2_grid();
		}

		private void update_v_dm_tham_so_nhac_viec(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            if (m_fg.Rows[m_fg.Row].IsNode == true) return;
			grid2us_object(m_us, m_fg.Row);
            us_obj_2_form(m_us);
		}
				
		private void delete_v_dm_tham_so_nhac_viec(){
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
			if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted)  return;
			US_V_DM_THAM_SO_NHAC_VIEC v_us = new US_V_DM_THAM_SO_NHAC_VIEC();
			grid2us_object(v_us, m_fg.Row);
			try {			
				v_us.BeginTransaction();    											
				v_us.Delete();                      								
				v_us.CommitTransaction();
				m_fg.Rows.Remove(m_fg.Row);				
			}
			catch (Exception v_e) {
				v_us.Rollback();
				CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
					new CDBClientDBExceptionInterpret());
				v_objErrHandler.showErrorMessage();
			}
		}

		private void view_v_dm_tham_so_nhac_viec(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
			grid2us_object(m_us, m_fg.Row);
		//	f106_dm_tham_so_nhac_viec_DE v_fDE = new f106_dm_tham_so_nhac_viec_DE();			
		//	v_fDE.display(m_us);
		}
		private void set_define_events(){
			m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
			m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
			m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
            m_cmd_luu.Click += new EventHandler(m_cmd_luu_Click);
            this.KeyDown += new KeyEventHandler(f106_dm_tham_so_nhac_viec_KeyDown);
		}

        void f106_dm_tham_so_nhac_viec_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
		#endregion


		//
		//		EVENT HANLDERS
		//
		//
		private void f106_dm_tham_so_nhac_viec_Load(object sender, System.EventArgs e) {
			try{
				set_initial_form_load();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		
		}

		private void m_cmd_exit_Click(object sender, EventArgs e) {
			try{
				this.Close();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_insert_Click(object sender, EventArgs e) {
			try{
				insert_v_dm_tham_so_nhac_viec();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_update_Click(object sender, EventArgs e) {
			try{
                m_e_form_mode = DataEntryFormMode.UpdateDataState;
				update_v_dm_tham_so_nhac_viec();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_delete_Click(object sender, EventArgs e) {
			try{
				delete_v_dm_tham_so_nhac_viec();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

        private void save_data()
        {
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.UpdateDataState:
                    form_2_us_object(m_us);
                    m_us.Update();
                    m_e_form_mode = DataEntryFormMode.ViewDataState;
                    load_data_2_grid();
                    break;
                case DataEntryFormMode.ViewDataState:
                    form_2_us_object(m_us);
                    m_us.Insert();
                    load_data_2_grid();
                    break;
            }
            BaseMessages.MsgBox_Infor("Dữ liệu được cập nhật thành công!");
            reset_controls();
        }

        void m_cmd_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (!check_data_is_ok()) return;
                save_data();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

	}
}

