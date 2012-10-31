using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPData;
using IP.Core.IPUserService;

using BondUS;
using BondDS;
using BondDS.CDBNames;

using C1.Win.C1FlexGrid;
using System.Collections;
using IP.Core.IPExcelReport;
using IP.Core.IPSystemAdmin;

namespace BondApp.ChucNang
{
    public partial class f260_import_trai_chu_tu_excel : Form
    {
        public f260_import_trai_chu_tu_excel()
        {
            InitializeComponent();
            format_control();
        }

        #region Members
        ITransferDataRow m_obj_tran_xls;
        //US_DM_TRAI_PHIEU m_us_trai_phieu;
        US_V_DM_TRAI_PHIEU m_us_v_trai_phieu;
        DS_DM_TRAI_CHU_IMP m_ds_trai_chu_imp = new DS_DM_TRAI_CHU_IMP();
        decimal m_dc_ca_nhan_trong_nuoc, m_dc_ca_nhan_nuoc_ngoai, m_dc_to_chuc_trong_nuoc, m_dc_to_chuc_nuoc_ngoai;
        // cờ dùng để xác định dữ liệu có ok hay ko? 0: ko ok; 1: ok
        int m_i_flag = 0;
        #endregion

        #region Data Structure
        private enum e_col_number_xls
        {
            STT_ROW = 1,
            MA_TRAI_CHU = 2,
            TEN_TRAI_CHU = 3,          
            LOAI_HINH_CO_CONG = 4,
            DKHD_CMND = 5,
            NGAY_CAP = 6,
            NOI_CAP = 7,
            QUOC_TICH = 8,
            DIA_CHI = 9,
            DIEN_THOAI = 10,
            EMAIL = 11,
            SO_TAI_KHOAN = 12,
            NOI_MO_TAI_KHOAN = 13,
            SO_LUONG_TRAI_PHIEU_SO_HUU = 14,
            TEN_NGUOI_DAI_DIEN = 15,
            SO_CMND_NGUOI_DAI_DIEN = 16,
            NGAY_CAP_CMND_NGUOI_DAI_DIEN = 17,
            NOI_CAP_CMND_NGUOI_DAI_DIEN = 18,
            CHUC_VU_NGUOI_DAI_DIEN = 19,
            NGAY_BAT_DAU_SO_HUU_TP = 20,
            TRANG_THAI = 21,
            DIEN_GIAI = 22
        }
        #endregion

        #region Private Method
        private void format_control()
        {
            CControlFormat.setFormStyle(this);
            set_define_event();
            m_lbl_header.Font = new Font("Arial", 16);
            m_lbl_header.ForeColor = Color.DarkRed;
            m_lbl_header.TextAlign = ContentAlignment.MiddleCenter;
        }
        private void set_init_load_form()
        {
            m_obj_tran_xls = get_2_us_obj_xls();
            m_dc_ca_nhan_trong_nuoc = CIPConvert.ToDecimal(System.Configuration.ConfigurationSettings.AppSettings["CA_NHAN_TRONG_NUOC"]);
            m_dc_to_chuc_trong_nuoc = CIPConvert.ToDecimal(System.Configuration.ConfigurationSettings.AppSettings["TO_CHUC_TRONG_NUOC"]);
            m_dc_ca_nhan_nuoc_ngoai = CIPConvert.ToDecimal(System.Configuration.ConfigurationSettings.AppSettings["CA_NHAN_NUOC_NGOAI"]);
            m_dc_to_chuc_nuoc_ngoai = CIPConvert.ToDecimal(System.Configuration.ConfigurationSettings.AppSettings["TO_CHUC_NUOC_NGOAI"]);
        }
        private void us_trai_phieu_2_form(US_V_DM_TRAI_PHIEU ip_us_trai_phieu)
        {
            m_txt_ma_trai_phieu.Text = ip_us_trai_phieu.strMA_TRAI_PHIEU;
            try
            {
                //US_DM_DOT_PHAT_HANH v_us_dm_dot_phat_hanh = new US_DM_DOT_PHAT_HANH(ip_us_trai_phieu.dcID_DOT_PHAT_HANH);
                //US_DM_TO_CHUC_PHAT_HANH v_us_dm_to_chuc_phat_hanh = new US_DM_TO_CHUC_PHAT_HANH(v_us_dm_dot_phat_hanh.dcID_TO_CHUC_PHAT_HANH);
                m_txt_ten_to_chuc_phat_hanh.Text = ip_us_trai_phieu.strTEN_TO_CHUC_PHAT_HANH;
                m_txt_ngay_phat_hanh.Text = CIPConvert.ToStr(ip_us_trai_phieu.datNGAY_PHAT_HANH, "dd/MM/yyyy");
            }
            catch (Exception v_e)
            {
                MessageBox.Show("Trái phiếu " + m_us_v_trai_phieu.strTEN_TRAI_PHIEU + " không có đơn vị kỳ hạn");
                throw v_e;
            }
        }
        private void load_db_excel()
        {
            if (m_txt_ma_trai_phieu.Text == "")
            {
                BaseMessages.MsgBox_Infor("Bạn hãy chọn trái phiếu");
                m_cmd_chon_trai_phieu.Focus();
                return;
            }

            if (m_dgl_open_file.ShowDialog() == DialogResult.OK)
            {
                string v_str_path_and_file_name = m_dgl_open_file.FileName;
                string v_str_file_name = v_str_path_and_file_name.Substring(v_str_path_and_file_name.LastIndexOf("\\") + 1, v_str_path_and_file_name.Length - v_str_path_and_file_name.LastIndexOf("\\") - 1);
                if (v_str_path_and_file_name.Length == 0) return;

                CExcelReport v_xls_file = new CExcelReport(v_str_path_and_file_name);

                DS_DM_TRAI_CHU_IMP v_ds_tmp_dm_trai_chu = new DS_DM_TRAI_CHU_IMP();
                US_CM_DM_TU_DIEN v_tu_dien;
                try
                {
                    v_ds_tmp_dm_trai_chu.EnforceConstraints = false;
                    v_xls_file.Export2DatasetDSPhongThi(v_ds_tmp_dm_trai_chu, v_ds_tmp_dm_trai_chu.DM_TRAI_CHU_IMP.TableName, 2);

                    CGridUtils.Dataset2C1Grid(v_ds_tmp_dm_trai_chu, m_fg_load_file, m_obj_tran_xls);
                    BaseMessages.MsgBox_Infor("Đã load dữ liệu file excel thành công.");
                }
                catch (Exception v_e)
                {
                    if (v_e.Message.ToString() == "Cannot set Column 'STT' to be null. Please use DBNull instead.")
                        BaseMessages.MsgBox_Error("Cột STT không được trống, kiểm tra lại đi");
                    else CSystemLog_301.ExceptionHandle(v_e);
                }
            }

        }
        private void select_trai_phieu()
        {
            f300_dm_trai_phieu v_frm300 = new f300_dm_trai_phieu();
            m_us_v_trai_phieu = new US_V_DM_TRAI_PHIEU();
            m_us_v_trai_phieu = v_frm300.select_trai_phieu();
            if (!m_us_v_trai_phieu.IsIDNull() && m_us_v_trai_phieu.dcID != -1)
                us_trai_phieu_2_form(m_us_v_trai_phieu);
        }
        private bool check_so_luong_is_ok()
        {
            decimal v_i_tong_so_luong_trai_phieu_nhap_vao= 0;
            for (int i_stt = 1; i_stt <= m_fg_load_file.Rows.Count - 1; i_stt++)
            {
                v_i_tong_so_luong_trai_phieu_nhap_vao += CIPConvert.ToDecimal(m_fg_load_file[i_stt, (int)e_col_number_xls.SO_LUONG_TRAI_PHIEU_SO_HUU]);
            }
            if (v_i_tong_so_luong_trai_phieu_nhap_vao > m_us_v_trai_phieu.dcTONG_SL_PHAT_HANH) return false;
            return true;
        }
        private void kiem_tra_data_tren_luoi()
        {
            // kiem tra so luong hoc vien
            if (m_fg_load_file.Rows.Count <= 1) return;
            // kiem tra du lieu tren luoi
            try
            {

                C1.Win.C1FlexGrid.CellStyle v_cell_style_err = this.m_fg_load_file.Styles.Add("RowColorErr");
                v_cell_style_err.BackColor = Color.Red;
                C1.Win.C1FlexGrid.CellStyle v_cell_style = this.m_fg_load_file.Styles.Add("RowColor");
                v_cell_style.BackColor = Color.White;

                C1.Win.C1FlexGrid.CellStyle v_cell_style_ok = this.m_fg_load_file.Styles.Add("RowColorOk");
                v_cell_style_ok.BackColor = Color.White;
                C1.Win.C1FlexGrid.CellStyle v_cell_style_chu_ok = this.m_fg_load_file.Styles.Add("RowColor");
                v_cell_style_chu_ok.BackColor = Color.Black;

                for (int i_stt = 1; i_stt <= m_fg_load_file.Rows.Count - 1; i_stt++)
                {
                    string v_dien_giai = " ";
                    
                    // 1. kiểm tra thông tin của trái chủ
                    bool v_bol_co_trai_chu = false;
                    if (m_fg_load_file[i_stt, (int)e_col_number_xls.MA_TRAI_CHU] != null)
                    {
                        string v_str_ma_trai_chu_xls = "";
                        US_V_DM_TRAI_CHU v_us_trai_chu = new US_V_DM_TRAI_CHU();
                        try
                        {
                            v_str_ma_trai_chu_xls = CIPConvert.ToStr(m_fg_load_file[i_stt, (int)e_col_number_xls.MA_TRAI_CHU]);

                            v_bol_co_trai_chu = v_us_trai_chu.InitByMA_TRAI_CHU(v_str_ma_trai_chu_xls);

                            if (v_bol_co_trai_chu)
                            {
                                v_dien_giai = "Mã trái chủ đã tồn tại trong hệ thống";
                                m_fg_load_file.SetCellStyle(i_stt, (int)e_col_number_xls.MA_TRAI_CHU, v_cell_style_err);
                            }
                            else
                            {
                                v_dien_giai = " ";
                                m_fg_load_file.SetCellStyle(i_stt, (int)e_col_number_xls.MA_TRAI_CHU, v_cell_style_ok);
                            }
                        }
                        catch (Exception v_e)
                        {

                            throw v_e;
                        }

                    }
                    else
                    {
                        v_dien_giai = "Mã trái chủ không được null, ";
                        m_fg_load_file.SetCellStyle(i_stt, (int)e_col_number_xls.MA_TRAI_CHU, v_cell_style_err);
                    }
                    if (m_fg_load_file[i_stt, (int)e_col_number_xls.TEN_TRAI_CHU] == null)
                    {
                        v_dien_giai += "Tên trái chủ không được null, ";
                        m_fg_load_file.SetCellStyle(i_stt, (int)e_col_number_xls.TEN_TRAI_CHU, v_cell_style_err);
                    }
                    else
                    {
                        m_fg_load_file.SetCellStyle(i_stt, (int)e_col_number_xls.TEN_TRAI_CHU, v_cell_style_ok);
                    }
                    // kiem tra loại hình cổ đông không được null và <0
                    if (m_fg_load_file[i_stt, (int)e_col_number_xls.LOAI_HINH_CO_CONG] != null)
                    {
                        if (CIPConvert.ToDecimal(m_fg_load_file[i_stt, (int)e_col_number_xls.LOAI_HINH_CO_CONG]) < 0)
                        {
                            v_dien_giai += "Loại hình cổ đông không hợp lệ, ";
                            m_fg_load_file.SetCellStyle(i_stt, (int)e_col_number_xls.LOAI_HINH_CO_CONG, v_cell_style_err);
                        }
                        else
                        {
                            m_fg_load_file.SetCellStyle(i_stt, (int)e_col_number_xls.LOAI_HINH_CO_CONG, v_cell_style_ok);
                        }
                    }
                    else
                    {
                        v_dien_giai = "Loại hình cổ đông không được null, ";
                        m_fg_load_file.SetCellStyle(i_stt, (int)e_col_number_xls.LOAI_HINH_CO_CONG, v_cell_style_err);
                    }
                    // Đăng ký kinh doanh or CMND
                    if (m_fg_load_file[i_stt, (int)e_col_number_xls.DKHD_CMND] == null)
                    {
                        v_dien_giai += "Số CMND hoặc đăng ký kinh doanh không được null, ";
                        m_fg_load_file.SetCellStyle(i_stt, (int)e_col_number_xls.DKHD_CMND, v_cell_style_err);
                    }
                    else
                    {
                        m_fg_load_file.SetCellStyle(i_stt, (int)e_col_number_xls.DKHD_CMND, v_cell_style_ok);
                    }
                    // kiem tra số lượng trái phiếu sở hữu
                    if (m_fg_load_file[i_stt, (int)e_col_number_xls.SO_LUONG_TRAI_PHIEU_SO_HUU] != null)
                    {
                        if (CIPConvert.ToDecimal(m_fg_load_file[i_stt, (int)e_col_number_xls.SO_LUONG_TRAI_PHIEU_SO_HUU]) < 0)
                        {

                            v_dien_giai += "Số lượng trái phiếu sở hữu phải lớn hơn 0, ";
                            m_fg_load_file.SetCellStyle(i_stt, (int)e_col_number_xls.SO_LUONG_TRAI_PHIEU_SO_HUU, v_cell_style_err);
                        }
                        else
                        {
                            m_fg_load_file.SetCellStyle(i_stt, (int)e_col_number_xls.SO_LUONG_TRAI_PHIEU_SO_HUU, v_cell_style_ok);
                        }
                    }
                    else
                    {
                        v_dien_giai = "Số lượng trái phiếu sở hữu không được null, ";
                        m_fg_load_file.SetCellStyle(i_stt, (int)e_col_number_xls.SO_LUONG_TRAI_PHIEU_SO_HUU, v_cell_style_err);
                    }
                    m_fg_load_file[i_stt, (int)e_col_number_xls.DIEN_GIAI] = v_dien_giai;
                    // gan gia tri cho cot kiem tra
                    if (v_dien_giai != " ") m_fg_load_file[i_stt, (int)e_col_number_xls.TRANG_THAI] = "N";
                    else m_fg_load_file[i_stt, (int)e_col_number_xls.TRANG_THAI] = "Y";
                }
                // THONG BAO THANH CONG NEU LA Y
                decimal v_count_ = 0;
                for (int i_stt = 1; i_stt <= m_fg_load_file.Rows.Count - 1; i_stt++)
                {
                    if (m_fg_load_file[i_stt, (int)e_col_number_xls.TRANG_THAI] != null)
                    {
                        if (CIPConvert.ToStr(m_fg_load_file[i_stt, (int)e_col_number_xls.TRANG_THAI]) == "Y")
                        {
                            v_count_ = v_count_ + 1;
                        }
                    }
                }
                // 
                if (v_count_ == m_fg_load_file.Rows.Count - 1)
                {
                    if (!check_so_luong_is_ok())
                    {
                        BaseMessages.MsgBox_Infor("Tổng số lượng trái phiếu nhập vào lớn hơn tổng số lượng trái phiếu này phát hành");
                        m_i_flag = 0;
                    }
                    else m_i_flag = 1;
                }
                else
                {
                    m_i_flag = 0;
                    BaseMessages.MsgBox_Infor("Tồn tại dữ liệu không hợp lệ. Xem thông báo trên lưới");
                }
            }
            catch (Exception v_e)
            {
                throw v_e;
            }

        }
        private void add_danh_sach_trai_chu()
        {
            US_DM_TRAI_CHU_IMP v_us_trai_chu_imp = new US_DM_TRAI_CHU_IMP();
            try
            {
                v_us_trai_chu_imp.BeginTransaction();
                for (int v_int_row = m_fg_load_file.Rows.Fixed; v_int_row < m_fg_load_file.Rows.Count; v_int_row++)
                {
                    form_2_us_object_hoc_vien_theo_hoc(v_us_trai_chu_imp, v_int_row);
                    v_us_trai_chu_imp.Insert_import(get_loai_trai_chu_by_loai_hinh_co_dong(v_us_trai_chu_imp.dcLOAI_HINH_CO_CONG)
                                                    , CAppContext_201.getCurrentUserID()
                                                    , m_us_v_trai_phieu.dcID);
                }
                v_us_trai_chu_imp.CommitTransaction();
                BaseMessages.MsgBox_Infor("Đã import trái chủ thành công");
            }
            catch (Exception v_e)
            {
                v_us_trai_chu_imp.Rollback();
                CDBExceptionHandler v_exceptionHander = new CDBExceptionHandler(v_e,
                    new CDBClientDBExceptionInterpret()); 
                v_exceptionHander.showErrorMessage();
            }
        }
        private void form_2_us_object_hoc_vien_theo_hoc(US_DM_TRAI_CHU_IMP v_us, int i_i_id)
        {
            v_us.strMA_TRAI_CHU = CIPConvert.ToStr(m_fg_load_file[i_i_id, (int)e_col_number_xls.MA_TRAI_CHU]);
            v_us.strTEN_TRAI_CHU = CIPConvert.ToStr(m_fg_load_file[i_i_id, (int)e_col_number_xls.TEN_TRAI_CHU]);
            v_us.dcLOAI_HINH_CO_CONG = CIPConvert.ToDecimal(m_fg_load_file[i_i_id, (int)e_col_number_xls.LOAI_HINH_CO_CONG]);
            v_us.strDKHD_CMND = CIPConvert.ToStr(m_fg_load_file[i_i_id, (int)e_col_number_xls.DKHD_CMND]);
            v_us.dcSO_LUONG_TRAI_PHIEU_SO_HUU = CIPConvert.ToDecimal(m_fg_load_file[i_i_id, (int)e_col_number_xls.SO_LUONG_TRAI_PHIEU_SO_HUU]);

            if (m_fg_load_file[i_i_id, (int)e_col_number_xls.NGAY_CAP] == null)
            {
                v_us.SetNGAY_CAPNull();
            }
            else
                v_us.datNGAY_CAP = CIPConvert.ToDatetime(CIPConvert.ToStr(m_fg_load_file[i_i_id, (int)e_col_number_xls.NGAY_CAP]));


            if ((m_fg_load_file[i_i_id, (int)e_col_number_xls.NOI_CAP] == null))
            {
                v_us.SetNOI_CAPNull();
            }
            else
                v_us.strNOI_CAP = CIPConvert.ToStr(m_fg_load_file[i_i_id, (int)e_col_number_xls.NOI_CAP]);
            if ((m_fg_load_file[i_i_id, (int)e_col_number_xls.QUOC_TICH] == null))
            {
                v_us.SetQUOC_TICHNull();
            }
            else
                v_us.strQUOC_TICH = CIPConvert.ToStr(m_fg_load_file[i_i_id, (int)e_col_number_xls.QUOC_TICH]);
            if ((m_fg_load_file[i_i_id, (int)e_col_number_xls.DIA_CHI] == null))
            {
                v_us.SetDIA_CHINull();
            }
            else
                v_us.strDIA_CHI = CIPConvert.ToStr(m_fg_load_file[i_i_id, (int)e_col_number_xls.DIA_CHI]);
            if (m_fg_load_file[i_i_id, (int)e_col_number_xls.DIEN_THOAI] == null)
            {
                v_us.SetDIEN_THOAINull();
            }
            else
                v_us.strDIEN_THOAI = CIPConvert.ToStr(m_fg_load_file[i_i_id, (int)e_col_number_xls.DIEN_THOAI]);
            if (m_fg_load_file[i_i_id, (int)e_col_number_xls.EMAIL] == null)
            {
                v_us.SetEMAILNull();
            }
            else
                v_us.strEMAIL = CIPConvert.ToStr(m_fg_load_file[i_i_id, (int)e_col_number_xls.EMAIL]);
              if (m_fg_load_file[i_i_id, (int)e_col_number_xls.SO_TAI_KHOAN] == null)
            {
                v_us.SetSO_TAI_KHOANNull();
            }
            else
                v_us.strSO_TAI_KHOAN = CIPConvert.ToStr(m_fg_load_file[i_i_id, (int)e_col_number_xls.SO_TAI_KHOAN]);
            if (m_fg_load_file[i_i_id, (int)e_col_number_xls.NOI_MO_TAI_KHOAN] == null)
            {
                v_us.SetNOI_MO_TAI_KHOANNull();
            }
            else
                v_us.strNOI_MO_TAI_KHOAN = CIPConvert.ToStr(m_fg_load_file[i_i_id, (int)e_col_number_xls.NOI_MO_TAI_KHOAN]);

          if (m_fg_load_file[i_i_id, (int)e_col_number_xls.NOI_MO_TAI_KHOAN] == null)
            {
                v_us.SetNOI_MO_TAI_KHOANNull();
            }
            else
                v_us.strNOI_MO_TAI_KHOAN = CIPConvert.ToStr(m_fg_load_file[i_i_id, (int)e_col_number_xls.NOI_MO_TAI_KHOAN]);
          if (m_fg_load_file[i_i_id, (int)e_col_number_xls.TEN_NGUOI_DAI_DIEN] == null)
          {
              v_us.SetTEN_NGUOI_DAI_DIENNull();
          }
          else
              v_us.strTEN_NGUOI_DAI_DIEN = CIPConvert.ToStr(m_fg_load_file[i_i_id, (int)e_col_number_xls.TEN_NGUOI_DAI_DIEN]);
          if (m_fg_load_file[i_i_id, (int)e_col_number_xls.SO_CMND_NGUOI_DAI_DIEN] == null)
          {
              v_us.SetSO_CMND_NGUOI_DAI_DIENNull();
          }
          else
              v_us.strSO_CMND_NGUOI_DAI_DIEN = CIPConvert.ToStr(m_fg_load_file[i_i_id, (int)e_col_number_xls.SO_CMND_NGUOI_DAI_DIEN]);
          if (m_fg_load_file[i_i_id, (int)e_col_number_xls.NGAY_CAP_CMND_NGUOI_DAI_DIEN] == null)
          {
              v_us.SetNGAY_CAP_CMND_NGUOI_DAI_DIENNull();
          }
          else
              v_us.datNGAY_CAP_CMND_NGUOI_DAI_DIEN = CIPConvert.ToDatetime(CIPConvert.ToStr(m_fg_load_file[i_i_id, (int)e_col_number_xls.NGAY_CAP_CMND_NGUOI_DAI_DIEN]));
          if (m_fg_load_file[i_i_id, (int)e_col_number_xls.NOI_CAP_CMND_NGUOI_DAI_DIEN] == null)
          {
              v_us.SetNOI_CAP_CMND_NGUOI_DAI_DIENNull();
          }
          else
              v_us.strNOI_CAP_CMND_NGUOI_DAI_DIEN = CIPConvert.ToStr(m_fg_load_file[i_i_id, (int)e_col_number_xls.NOI_CAP_CMND_NGUOI_DAI_DIEN]);
          if (m_fg_load_file[i_i_id, (int)e_col_number_xls.CHUC_VU_NGUOI_DAI_DIEN] == null)
          {
              v_us.SetCHUC_VU_NGUOI_DAI_DIENNull();
          }
          else
              v_us.strCHUC_VU_NGUOI_DAI_DIEN = CIPConvert.ToStr(m_fg_load_file[i_i_id, (int)e_col_number_xls.CHUC_VU_NGUOI_DAI_DIEN]);
          if (m_fg_load_file[i_i_id, (int)e_col_number_xls.NGAY_BAT_DAU_SO_HUU_TP] == null)
          {
              v_us.SetNGAY_BAT_DAU_SO_HUU_TPNull();
          }
          else
              v_us.datNGAY_BAT_DAU_SO_HUU_TP = CIPConvert.ToDatetime(CIPConvert.ToStr(m_fg_load_file[i_i_id, (int)e_col_number_xls.NGAY_BAT_DAU_SO_HUU_TP]));
            
            v_us.dcSTT = 1;
        }
        private decimal get_loai_trai_chu_by_loai_hinh_co_dong(decimal ip_dc_loai_hinh_co_dong)
        {
            decimal v_dc_loai_trai_chu = 0;
            if(ip_dc_loai_hinh_co_dong == m_dc_ca_nhan_trong_nuoc)
                 v_dc_loai_trai_chu = ID_LOAI_TRAI_CHU.CA_NHAN_TRONG_NUOC;
            else if(ip_dc_loai_hinh_co_dong == m_dc_ca_nhan_nuoc_ngoai)
                    v_dc_loai_trai_chu = ID_LOAI_TRAI_CHU.CA_NHAN_NUOC_NGOAI;
            else if(ip_dc_loai_hinh_co_dong == m_dc_to_chuc_trong_nuoc)
                    v_dc_loai_trai_chu = ID_LOAI_TRAI_CHU.TO_CHUC_TRONG_NUOC;
            else if(ip_dc_loai_hinh_co_dong == m_dc_to_chuc_nuoc_ngoai)
                    v_dc_loai_trai_chu = ID_LOAI_TRAI_CHU.TO_CHUC_NUOC_NGOAI;
            return v_dc_loai_trai_chu;
        }
        private ITransferDataRow get_2_us_obj_xls()
        {
            Hashtable v_hst = new Hashtable();
            v_hst.Add(DM_TRAI_CHU_IMP.STT, e_col_number_xls.STT_ROW);
            v_hst.Add(DM_TRAI_CHU_IMP.MA_TRAI_CHU, e_col_number_xls.MA_TRAI_CHU);
            v_hst.Add(DM_TRAI_CHU_IMP.TEN_TRAI_CHU, e_col_number_xls.TEN_TRAI_CHU);
            v_hst.Add(DM_TRAI_CHU_IMP.LOAI_HINH_CO_CONG, e_col_number_xls.LOAI_HINH_CO_CONG);
            v_hst.Add(DM_TRAI_CHU_IMP.DKHD_CMND, e_col_number_xls.DKHD_CMND);
            v_hst.Add(DM_TRAI_CHU_IMP.NGAY_CAP, e_col_number_xls.NGAY_CAP);
            v_hst.Add(DM_TRAI_CHU_IMP.NOI_CAP, e_col_number_xls.NOI_CAP);
            v_hst.Add(DM_TRAI_CHU_IMP.QUOC_TICH, e_col_number_xls.QUOC_TICH);
            v_hst.Add(DM_TRAI_CHU_IMP.DIA_CHI, e_col_number_xls.DIA_CHI);
            v_hst.Add(DM_TRAI_CHU_IMP.DIEN_THOAI, e_col_number_xls.DIEN_THOAI);
            v_hst.Add(DM_TRAI_CHU_IMP.EMAIL, e_col_number_xls.EMAIL);
            v_hst.Add(DM_TRAI_CHU_IMP.SO_TAI_KHOAN, e_col_number_xls.SO_TAI_KHOAN);
            v_hst.Add(DM_TRAI_CHU_IMP.NOI_MO_TAI_KHOAN, e_col_number_xls.NOI_MO_TAI_KHOAN);
            v_hst.Add(DM_TRAI_CHU_IMP.SO_LUONG_TRAI_PHIEU_SO_HUU, e_col_number_xls.SO_LUONG_TRAI_PHIEU_SO_HUU);
            v_hst.Add(DM_TRAI_CHU_IMP.TEN_NGUOI_DAI_DIEN, e_col_number_xls.TEN_NGUOI_DAI_DIEN);
            v_hst.Add(DM_TRAI_CHU_IMP.SO_CMND_NGUOI_DAI_DIEN, e_col_number_xls.SO_CMND_NGUOI_DAI_DIEN);
            v_hst.Add(DM_TRAI_CHU_IMP.NGAY_CAP_CMND_NGUOI_DAI_DIEN, e_col_number_xls.NGAY_CAP_CMND_NGUOI_DAI_DIEN);
            v_hst.Add(DM_TRAI_CHU_IMP.NOI_CAP_CMND_NGUOI_DAI_DIEN, e_col_number_xls.NOI_CAP_CMND_NGUOI_DAI_DIEN);
            v_hst.Add(DM_TRAI_CHU_IMP.CHUC_VU_NGUOI_DAI_DIEN, e_col_number_xls.CHUC_VU_NGUOI_DAI_DIEN);
            v_hst.Add(DM_TRAI_CHU_IMP.NGAY_BAT_DAU_SO_HUU_TP, e_col_number_xls.NGAY_BAT_DAU_SO_HUU_TP);
            CC1TransferDataRow v_obj = new CC1TransferDataRow(m_fg_load_file, v_hst, m_ds_trai_chu_imp.DM_TRAI_CHU_IMP.NewDM_TRAI_CHU_IMPRow());
            return v_obj;
        }
        private bool chua_load_file_excel()
        {
            if (m_dgl_open_file.FileName != "") return false;
            return true;
        }
        #endregion

        #region Public Interface
        public void display()
        {
            this.ShowDialog();
        }
        #endregion

        #region Events
        private void set_define_event()
        {
            m_cmd_open_template.Click += new EventHandler(m_cmd_open_template_Click);
            m_cmd_chon_trai_phieu.Click += new EventHandler(m_cmd_chon_trai_phieu_Click);
            m_cmd_load_ds_trai_chu.Click += new EventHandler(m_cmd_load_ds_trai_chu_Click);
            m_cmd_kiem_tra.Click += new EventHandler(m_cmd_kiem_tra_Click);
            m_cmd_luu.Click += new EventHandler(m_cmd_luu_Click);
            m_cmd_thoat.Click += new EventHandler(m_cmd_thoat_Click);
            this.Load += new EventHandler(f260_import_trai_chu_tu_excel_Load);
            this.KeyDown += new KeyEventHandler(f260_import_trai_chu_tu_excel_KeyDown);
        }

        void f260_import_trai_chu_tu_excel_KeyDown(object sender, KeyEventArgs e)
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

        void f260_import_trai_chu_tu_excel_Load(object sender, EventArgs e)
        {
            try
            {
                set_init_load_form();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_chon_trai_phieu_Click(object sender, EventArgs e)
        {
            try
            {
                select_trai_phieu();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_open_template_Click(object sender, EventArgs e)
        {
            try
            {
                CExcelReport v_excel = new CExcelReport("F260_file_template_import.xls");
                v_excel.OpenExcelFile();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (chua_load_file_excel())
                {
                    BaseMessages.MsgBox_Infor("Bạn chưa load file Danh sách trái chủ!");
                    return;
                }
                kiem_tra_data_tren_luoi();
                if (m_i_flag == 0) return;
                add_danh_sach_trai_chu();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_kiem_tra_Click(object sender, EventArgs e)
        {
            try
            {
                if (chua_load_file_excel())
                {
                    BaseMessages.MsgBox_Infor("Bạn chưa load file Danh sách trái chủ!");
                    return;
                }
                kiem_tra_data_tren_luoi();
               if (m_i_flag == 1) BaseMessages.MsgBox_Infor("Bạn đã kiểm tra dữ liệu thành công");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_load_ds_trai_chu_Click(object sender, EventArgs e)
        {
            try
            {
                load_db_excel();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_thoat_Click(object sender, EventArgs e)
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
        #endregion
    }
}
