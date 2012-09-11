namespace BondApp
{
    partial class f800_lich_nhac_viec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f800_lich_nhac_viec));
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_lbl_lich_nhac_viec_tu = new System.Windows.Forms.Label();
            this.m_lbl_lich_nhac_viec_den = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            this.SuspendLayout();
            // 
            // m_fg
            // 
            this.m_fg.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_fg.Location = new System.Drawing.Point(0, 115);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(541, 190);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 21;
            // 
            // m_lbl_lich_nhac_viec_tu
            // 
            this.m_lbl_lich_nhac_viec_tu.AutoSize = true;
            this.m_lbl_lich_nhac_viec_tu.Location = new System.Drawing.Point(11, 42);
            this.m_lbl_lich_nhac_viec_tu.Name = "m_lbl_lich_nhac_viec_tu";
            this.m_lbl_lich_nhac_viec_tu.Size = new System.Drawing.Size(20, 13);
            this.m_lbl_lich_nhac_viec_tu.TabIndex = 22;
            this.m_lbl_lich_nhac_viec_tu.Text = "Từ";
            // 
            // m_lbl_lich_nhac_viec_den
            // 
            this.m_lbl_lich_nhac_viec_den.AutoSize = true;
            this.m_lbl_lich_nhac_viec_den.Location = new System.Drawing.Point(11, 75);
            this.m_lbl_lich_nhac_viec_den.Name = "m_lbl_lich_nhac_viec_den";
            this.m_lbl_lich_nhac_viec_den.Size = new System.Drawing.Size(27, 13);
            this.m_lbl_lich_nhac_viec_den.TabIndex = 23;
            this.m_lbl_lich_nhac_viec_den.Text = "Đến";
            this.m_lbl_lich_nhac_viec_den.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(54, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 24;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(54, 68);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 25;
            this.dateTimePicker2.Value = new System.DateTime(2012, 9, 23, 19, 12, 0, 0);
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "Tất cả";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(371, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 21);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.ValueMember = "Tất cả";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Loại công việc";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(455, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "     Lọc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(291, 71);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(87, 17);
            this.checkBox1.TabIndex = 30;
            this.checkBox1.Text = "Đã thực hiện";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(201, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Lịch nhắc việc";
            // 
            // f800_lich_nhac_viec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 305);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.m_lbl_lich_nhac_viec_den);
            this.Controls.Add(this.m_lbl_lich_nhac_viec_tu);
            this.Controls.Add(this.m_fg);
            this.Name = "f800_lich_nhac_viec";
            this.Text = "5";
            this.Load += new System.EventHandler(this.f800_lich_nhac_viec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
        private System.Windows.Forms.Label m_lbl_lich_nhac_viec_tu;
        private System.Windows.Forms.Label m_lbl_lich_nhac_viec_den;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
    }
}