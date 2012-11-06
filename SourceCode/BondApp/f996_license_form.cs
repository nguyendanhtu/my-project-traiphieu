using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using IP.Core.IPCommon;


namespace BondApp
{
	/// <summary>
	/// Summary description for f996_license_form.
	/// </summary>
	public class f996_license_form : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.Panel m_pnl_out_place_dm;
		internal SIS.Controls.Button.SiSButton m_cmd_tro_ve;
		internal System.Windows.Forms.ImageList ImageList;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private PictureBox pictureBox1;
		private System.ComponentModel.IContainer components;

		public f996_license_form()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f996_license_form));
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.m_cmd_tro_ve = new SIS.Controls.Button.SiSButton();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.label5);
            this.m_pnl_out_place_dm.Controls.Add(this.label4);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_tro_ve);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 278);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(564, 62);
            this.m_pnl_out_place_dm.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(4, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(464, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Bản quyền của BKIndex Group.";
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(464, 35);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sản phẩm này nằm trong bộ sản phẩm ứng dụng dành cho tổ chức quản lý phát hành tr" +
                "ái phiếu";
            // 
            // m_cmd_tro_ve
            // 
            this.m_cmd_tro_ve.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_tro_ve.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_tro_ve.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_tro_ve.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_tro_ve.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cmd_tro_ve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_tro_ve.ImageIndex = 0;
            this.m_cmd_tro_ve.ImageList = this.ImageList;
            this.m_cmd_tro_ve.Location = new System.Drawing.Point(468, 4);
            this.m_cmd_tro_ve.Name = "m_cmd_tro_ve";
            this.m_cmd_tro_ve.Size = new System.Drawing.Size(92, 54);
            this.m_cmd_tro_ve.TabIndex = 5;
            this.m_cmd_tro_ve.Text = "OK [Esc]";
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "");
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 48);
            this.label1.TabIndex = 52;
            this.label1.Text = "BKIndex Group";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(168, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(396, 24);
            this.label2.TabIndex = 53;
            this.label2.Text = "Bond Manager";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(168, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(396, 24);
            this.label3.TabIndex = 54;
            this.label3.Text = "Version 1.0";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(176, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(328, 24);
            this.label6.TabIndex = 55;
            this.label6.Text = "Liên hệ: Nguyễn Danh Tú";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(176, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(328, 24);
            this.label7.TabIndex = 56;
            this.label7.Text = "Di động: 0904 257 115";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(112, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 8);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(0, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 8);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(176, 232);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(328, 24);
            this.linkLabel1.TabIndex = 61;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Email: tund@bkindex.com";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 278);
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // f996_license_form
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(564, 340);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "f996_license_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F996 - Ban quyen phan mem";
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion


		#region public interface
		public void display(){
			this.ShowDialog();
		}
		#endregion

		#region Private Method
		private void format_controls(){
			set_define_events();
		}
		private void set_define_events(){
			this.m_cmd_tro_ve.Click+= new EventHandler(m_cmd_tro_ve_Click);
            this.KeyDown += new KeyEventHandler(f996_license_form_KeyDown);
		}

        void f996_license_form_KeyDown(object sender, KeyEventArgs e)
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

		private void m_cmd_tro_ve_Click(object sender, EventArgs e) {
			try{
				this.Close();
                
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}
	}
}
