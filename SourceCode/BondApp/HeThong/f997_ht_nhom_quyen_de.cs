using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using IP.Core.IPSystemAdmin;
using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPUserService;
using IP.Core.IPData;
using IP.Core.IPData.DBNames;

using BondDS;
using BondUS;
using BondDS.CDBNames;

namespace BondApp
{
    public partial class f997_ht_nhom_quyen_de : Form
    {
        public f997_ht_nhom_quyen_de()
        {
            InitializeComponent();

            format_controls();
        }

        #region Public Intrface
        public void insert_new_user()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }
        public void update_new_user(US_HT_NHOM_NGUOI_SU_DUNG i_us_group)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_group = i_us_group;
            this.ShowDialog();

        }
        #endregion

        #region Data Structures
        private enum e_col_number{
			ID_QUYEN = 1
            , MA_QUYEN = 2
			, TEN_QUYEN = 3
			, LA_QUYEN_USER =4
		}
        #endregion

        #region Members
        US_HT_NHOM_NGUOI_SU_DUNG m_us_group = new US_HT_NHOM_NGUOI_SU_DUNG();
        ITransferDataRow m_obj_trans;
        DataEntryFormMode m_e_form_mode;
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201(), IPFormStyle.DialogForm);
            m_cbo_trang_thai.SelectedIndex = 0;
            m_fg.Cols[(int)e_col_number.ID_QUYEN].Visible = false;
            m_obj_trans = get_trans_object(m_fg);
            set_define_events();

        }
        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(HT_PHAN_QUYEN_HE_THONG.ID, e_col_number.ID_QUYEN);
            v_htb.Add(HT_PHAN_QUYEN_HE_THONG.GHI_CHU, e_col_number.TEN_QUYEN);
            v_htb.Add(HT_PHAN_QUYEN_HE_THONG.MA_PHAN_QUYEN, e_col_number.MA_QUYEN);
            DS_HT_PHAN_QUYEN_HE_THONG v_ds = new DS_HT_PHAN_QUYEN_HE_THONG();
            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, v_ds.HT_PHAN_QUYEN_HE_THONG.NewRow());
            return v_obj_trans;
        }
        private void load_data_2_grid()
        {
            US_HT_PHAN_QUYEN_HE_THONG v_us_phan_quyen = new US_HT_PHAN_QUYEN_HE_THONG();
            DS_HT_PHAN_QUYEN_HE_THONG v_ds_phan_quyen = new DS_HT_PHAN_QUYEN_HE_THONG();
            v_us_phan_quyen.FillDataset(v_ds_phan_quyen);
            CGridUtils.Dataset2C1Grid(v_ds_phan_quyen, m_fg, m_obj_trans);
            US_HT_PHAN_QUYEN_CHO_NHOM v_us_phan_quyen_cho_nhom = new US_HT_PHAN_QUYEN_CHO_NHOM();
            DS_HT_PHAN_QUYEN_CHO_NHOM v_ds_phan_quyen_cho_nhom = new DS_HT_PHAN_QUYEN_CHO_NHOM();
            v_us_phan_quyen_cho_nhom.FillDatasetByGroupUserID(m_us_group.dcID, v_ds_phan_quyen_cho_nhom);           
            //set not null quyen user
            for (int v_i_cur = m_fg.Rows.Fixed; v_i_cur < m_fg.Rows.Count; v_i_cur++)
            {
                m_fg[v_i_cur, (int)e_col_number.LA_QUYEN_USER] = false;
            }
            //set quyen
            foreach (DataRow v_dr in v_ds_phan_quyen_cho_nhom.HT_PHAN_QUYEN_CHO_NHOM.Rows)
            {
                for (int v_i_cur = m_fg.Rows.Fixed; v_i_cur < m_fg.Rows.Count; v_i_cur++)
                {
                    if ((decimal)m_fg[v_i_cur, (int)e_col_number.ID_QUYEN]
                        == (decimal)v_dr[HT_PHAN_QUYEN_CHO_NHOM.ID_PHAN_QUYEN_HE_THONG])
                    {
                        m_fg[v_i_cur, (int)e_col_number.LA_QUYEN_USER] = true;
                    }
                }
            }
        }
        private void form_2_us_object()
        {
            m_us_group.strMA_NHOM = m_txt_ten_nhom_ng_dung.Text;
            m_us_group.strGHI_CHU = m_txt_ghi_chu.Text;
            m_us_group.strTRANG_THAI_NHOM = m_cbo_trang_thai.SelectedIndex == 0 ? "ACTIVE" : "NO ACTIVE";
            if(m_e_form_mode == DataEntryFormMode.InsertDataState){
                m_us_group.dcID_INPUTED_BY = IP.Core.IPSystemAdmin.CAppContext_201.getCurrentUserID();
                m_us_group.SetID_LAST_UPDATED_BYNull();
                m_us_group.datINPUTED_DATE = m_date_ngay_tao.Value.Date;
            }
            if (m_e_form_mode == DataEntryFormMode.UpdateDataState)
            {
                m_us_group.dcID_LAST_UPDATED_BY = IP.Core.IPSystemAdmin.CAppContext_201.getCurrentUserID();
                m_us_group.datLAS_UPDATED_DATE = m_date_ngay_sua.Value.Date;
            }
        }
        private void us_object_2_form()
        {           
            m_txt_ten_nhom_ng_dung.Text = m_us_group.strMA_NHOM;
            m_txt_ghi_chu.Text = m_us_group.strGHI_CHU;
            if (!m_us_group.IsID_INPUTED_BYNull())
            {
                US_HT_NGUOI_SU_DUNG v_nguoi_lap = new US_HT_NGUOI_SU_DUNG(m_us_group.dcID_INPUTED_BY);
                m_txt_nguoi_tao.Text = v_nguoi_lap.strTEN;
                m_date_ngay_tao.Value = m_us_group.datINPUTED_DATE;
            }
            if (!m_us_group.IsID_LAST_UPDATED_BYNull())
            {
                US_HT_NGUOI_SU_DUNG v_nguoi_sua = new US_HT_NGUOI_SU_DUNG(m_us_group.dcID_LAST_UPDATED_BY);
                m_txt_nguoi_sua.Text = v_nguoi_sua.strTEN;
                m_date_ngay_sua.Value = m_us_group.datLAS_UPDATED_DATE;
            }
            m_cbo_trang_thai.SelectedIndex = m_us_group.strTRANG_THAI_NHOM == "ACTIVE"? 0 : 1;
        }
        private bool check_validate()
        {
            if (!CValidateTextBox.IsValid(m_txt_ten_nhom_ng_dung, DataType.StringType, allowNull.NO, true)) return false;            
            return true;
        }
        private void save_data()
        {
            if (!check_validate()) return;
            form_2_us_object();
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us_group.Insert();
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_group.Update();
                    break;
            }
            US_HT_PHAN_QUYEN_CHO_NHOM v_us_quyen_user = new US_HT_PHAN_QUYEN_CHO_NHOM();
            v_us_quyen_user.dcID_NHOM_NGUOI_SU_DUNG = m_us_group.dcID;
            v_us_quyen_user.DeleteAllQuyenOfGroupUser(m_us_group.dcID);
            for (int v_i_cur = m_fg.Rows.Fixed; v_i_cur < m_fg.Rows.Count; v_i_cur++)
            {
                if ((bool)m_fg[v_i_cur, (int)e_col_number.LA_QUYEN_USER] == true)
                {
                    v_us_quyen_user.dcID_PHAN_QUYEN_HE_THONG
                        = CIPConvert.ToDecimal(m_fg[v_i_cur, (int)e_col_number.ID_QUYEN]);
                    v_us_quyen_user.Insert();
                }
            }
            BaseMessages.MsgBox_Infor("Đã cập nhật thành công!");
            this.Close();

        }
       
        #endregion

        #region Events
        private void set_define_events()
        {
            this.m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            this.m_cmd_save.Click += new EventHandler(m_cmd_save_Click);
            this.Load += new EventHandler(f997_ht_nhom_quyen_de_Load);
        }

        void f997_ht_nhom_quyen_de_Load(object sender, EventArgs e)
        {
            try
            {
                load_data_2_grid();
                switch (m_e_form_mode)
                {
                    case DataEntryFormMode.InsertDataState:

                        break;
                    case DataEntryFormMode.UpdateDataState:
                        us_object_2_form();
                        break;
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }


        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                save_data();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion        

    }
}
