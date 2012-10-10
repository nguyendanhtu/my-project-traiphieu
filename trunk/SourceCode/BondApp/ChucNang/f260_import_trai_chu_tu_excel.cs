using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

namespace BondApp.ChucNang
{
    public partial class f260_import_trai_chu_tu_excel : Form
    {
        public f260_import_trai_chu_tu_excel()
        {
            InitializeComponent();
        }

        //#region Members
        //ITransferDataRow m_obj_tran_xls;
        //#endregion

        //#region Data Structure
        //private enum e_col_number_xls
        //{
        //    stt_row = 1,
        //    MA_TRAI_CHU = 2,
        //    ho_dem = 3,
        //    ten = 4,
        //    ngay_sinh = 5,
        //    noi_sinh = 6,
        //    diem_chuyen_can = 7,
        //    diem_giua_ky = 8,
        //    diem_thi_lan1 = 9,
        //    //
        //    diem_tong_ket_lan1 = 10,
        //    //
        //    ghi_chu_diem = 11,
        //    trang_thai = 12,
        //    dien_giai = 13

        //}
        //#endregion

        //#region Private Method
        //private void format_control()
        //{
        //    CControlFormat.setFormStyle(this);
            
        //    set_define_event();
        //}
        //private void set_init_load_form()
        //{
        //    m_obj_tran_xls = get_2_us_obj_xls();

        //}
        //private void load_db_excel()
        //{
        //    if (m_txt_ma_mon.Text == "")
        //    {
        //        BaseMessages.MsgBox_Infor("Bạn hãy chọn môn học");
        //        m_cmd_chon_trai_phieu.Focus();
        //        return;
        //    }

        //    if (m_dgl_open_file.ShowDialog() == DialogResult.OK)
        //    {
        //        string v_str_path_and_file_name = m_dgl_open_file.FileName;
        //        string v_str_file_name = v_str_path_and_file_name.Substring(v_str_path_and_file_name.LastIndexOf("\\") + 1, v_str_path_and_file_name.Length - v_str_path_and_file_name.LastIndexOf("\\") - 1);
        //        if (v_str_path_and_file_name.Length == 0) return;

        //        CExcelReport v_xls_file = new CExcelReport(v_str_path_and_file_name);

        //        DS_V_DM_TRAI_CHU v_ds_tmp_dm_trai_chu = new DS_V_DM_TRAI_CHU();
        //        try
        //        {
        //            v_ds_tmp_dm_trai_chu.EnforceConstraints = false;
        //            v_xls_file.Export2DatasetDSPhongThi(v_ds_tmp_dm_trai_chu, v_ds_tmp_dm_trai_chu.V_DM_TRAI_CHU.TableName, 12);

        //            CGridUtils.Dataset2C1Grid(v_ds_tmp_dm_trai_chu, m_fg_load_file, m_obj_tran_xls);

        //            BaseMessages.MsgBox_Infor("Đã load dữ liệu file excel thành công.");
        //        }
        //        catch (Exception v_e)
        //        {
        //            if (v_e.Message.ToString() == "Cannot set Column 'STT' to be null. Please use DBNull instead.")
        //                BaseMessages.MsgBox_Error("Cột STT không được trống, kiểm tra lại đi");
        //            else CSystemLog_301.ExceptionHandle(v_e);
        //        }
        //    }

        //}
        //private void kiem_tra_data_tren_luoi()
        //{
        //    // kiem tra so luong hoc vien
        //    if (m_fg_load_file.Rows.Count <= 1) return;
        //    // kiem tra du lieu tren luoi
        //    try
        //    {

        //        C1.Win.C1FlexGrid.CellStyle v_cell_style_err = this.m_fg_load_file.Styles.Add("RowColorErr");
        //        v_cell_style_err.BackColor = Color.Red;
        //        C1.Win.C1FlexGrid.CellStyle v_cell_style = this.m_fg_load_file.Styles.Add("RowColor");
        //        v_cell_style.BackColor = Color.White;
        //        for (int i_stt = 1; i_stt <= m_fg_load_file.Rows.Count - 1; i_stt++)
        //        {
        //            string v_dien_giai = " ";
                    
        //            // 1. kiểm tra thông tin của trái chủ
        //            bool v_bol_co_trai_chu = false;
        //            if (m_fg_load_file[i_stt, (int)e_col_number_xls.MA_TRAI_CHU] != null)
        //            {
        //                string v_str_ma_trai_chu_xls = "";
        //                US_V_DM_TRAI_CHU v_us_trai_chu = new US_V_DM_TRAI_CHU();
        //                try
        //                {
        //                    v_str_ma_trai_chu_xls = CIPConvert.ToStr(m_fg_load_file[i_stt, (int)e_col_number_xls.MA_TRAI_CHU]);

        //                    v_bol_co_trai_chu = v_us_trai_chu.InitByMA_TRAI_CHU(v_str_ma_trai_chu_xls);

        //                    if (!v_bol_co_trai_chu)
        //                    {
        //                        v_dien_giai = "Mã trái chủ không tồn tại trong phần mềm";
        //                        m_fg_load_file.SetCellStyle(i_stt, (int)e_col_number_xls.MA_TRAI_CHU, v_cell_style_err);
        //                    }
        //                    else v_dien_giai = " ";
        //                }
        //                catch (Exception v_e)
        //                {

        //                    throw v_e;
        //                }

        //            }
        //            else
        //            {
        //                v_dien_giai = "Mã trái chủ không được null,";
        //                m_fg_load_file.SetCellStyle(i_stt, (int)e_col_number_xls.MA_TRAI_CHU, v_cell_style_err);
        //            }

        //            // kiem tra diem chuyen can co hop le khong(tu 0 den 10)
        //            if (m_fg_load_file[i_stt, (int)e_col_number_xls.diem_chuyen_can] != null)
        //            {
        //                if (CIPConvert.ToDecimal(m_fg_load_file[i_stt, (int)e_col_number_xls.diem_chuyen_can]) > 10 || CIPConvert.ToDecimal(m_fg_load_file[i_stt, (int)e_col_number_xls.diem_chuyen_can]) < 0)
        //                {
        //                    v_dien_giai += "Điểm chuyên cần không hợp lệ,";
        //                    m_fg_load_file.SetCellStyle(i_stt, (int)e_col_number_xls.diem_chuyen_can, v_cell_style_err);
        //                }
        //            }
        //            // kiem tra diem giua ky co hop le khong(tu 0 den 10)
        //            if (m_fg_load_file[i_stt, (int)e_col_number_xls.diem_giua_ky] != null)
        //            {
        //                if (CIPConvert.ToDecimal(m_fg_load_file[i_stt, (int)e_col_number_xls.diem_giua_ky]) > 10 || CIPConvert.ToDecimal(m_fg_load_file[i_stt, (int)e_col_number_xls.diem_giua_ky]) < 0)
        //                {

        //                    v_dien_giai += "Điểm giữa kỳ không hợp lệ,";
        //                    m_fg_load_file.SetCellStyle(i_stt, (int)e_col_number_xls.diem_giua_ky, v_cell_style_err);
        //                }
        //            }
        //            // kiem tra diem thi co hop le khong(tu 0 den 10)
        //            if (m_fg_load_file[i_stt, (int)e_col_number_xls.diem_thi_lan1] != null)
        //            {
        //                if (CIPConvert.ToDecimal(m_fg_load_file[i_stt, (int)e_col_number_xls.diem_thi_lan1]) > 10 || CIPConvert.ToDecimal(m_fg_load_file[i_stt, (int)e_col_number_xls.diem_thi_lan1]) < 0)
        //                {
        //                    v_dien_giai += "Điểm thi không hợp lệ,";
        //                    m_fg_load_file.SetCellStyle(i_stt, (int)e_col_number_xls.diem_thi_lan1, v_cell_style_err);
        //                }
        //            }
        //            // kiem tra diem tổng kết co hop le khong(tu 0 den 10)
        //            if (m_fg_load_file[i_stt, (int)e_col_number_xls.diem_tong_ket_lan1] != null)
        //            {
        //                if (CIPConvert.ToDecimal(m_fg_load_file[i_stt, (int)e_col_number_xls.diem_tong_ket_lan1]) > 10 || CIPConvert.ToDecimal(m_fg_load_file[i_stt, (int)e_col_number_xls.diem_tong_ket_lan1]) < 0)
        //                {
        //                    v_dien_giai += "Điểm tổng kết không hợp lệ,";
        //                    m_fg_load_file.SetCellStyle(i_stt, (int)e_col_number_xls.diem_tong_ket_lan1, v_cell_style_err);
        //                }
        //            }
        //            m_fg_load_file[i_stt, (int)e_col_number_xls.dien_giai] = v_dien_giai;
        //            // gan gia tri cho cot kiem tra
        //            if (v_dien_giai != " ") m_fg_load_file[i_stt, (int)e_col_number_xls.trang_thai] = "N";
        //            else m_fg_load_file[i_stt, (int)e_col_number_xls.trang_thai] = "Y";
        //        }
        //        // THONG BAO THANH CONG NEU LA Y
        //        decimal v_count_ = 0;
        //        for (int i_stt = 1; i_stt <= m_fg_load_file.Rows.Count - 1; i_stt++)
        //        {
        //            if (m_fg_load_file[i_stt, (int)e_col_number_xls.trang_thai] != null)
        //            {
        //                if (CIPConvert.ToStr(m_fg_load_file[i_stt, (int)e_col_number_xls.trang_thai]) == "Y")
        //                {
        //                    v_count_ = v_count_ + 1;
        //                }
        //            }
        //        }
        //        // 
        //        if (v_count_ == m_fg_load_file.Rows.Count - 1) BaseMessages.MsgBox_Infor("Bạn đã kiểm tra dữ liệu thành công");
        //        else BaseMessages.MsgBox_Infor("Tồn tại dữ liệu không hợp lệ");
        //    }
        //    catch (Exception v_e)
        //    {
        //        throw v_e;
        //    }

        //}
        //private ITransferDataRow get_2_us_obj_xls()
        //{
        //    Hashtable v_hst = new Hashtable();
        //    //v_hst.Add(V_DM_TRAI_CHU.STT, e_col_number_xls.stt_row);
        //    v_hst.Add(V_DM_TRAI_CHU.NGAY_SINH, e_col_number_xls.ngay_sinh);
        //    v_hst.Add(V_DM_TRAI_CHU.MA_HV, e_col_number_xls.MA_TRAI_CHU);
        //    v_hst.Add(V_DM_TRAI_CHU.HO_VA_DEM, e_col_number_xls.ho_dem);
        //    v_hst.Add(V_DM_TRAI_CHU.TEN_HOC_VIEN, e_col_number_xls.ten);
        //    v_hst.Add(V_DM_TRAI_CHU.GIOI_TINH, e_col_number_xls.noi_sinh);
        //    v_hst.Add(V_DM_TRAI_CHU.GHI_CHU, e_col_number_xls.ghi_chu_diem);
        //    v_hst.Add(V_DM_TRAI_CHU.DIEM_TONG_KET, e_col_number_xls.diem_tong_ket_lan1);
        //    v_hst.Add(V_DM_TRAI_CHU.DIEM_THI, e_col_number_xls.diem_thi_lan1);
        //    v_hst.Add(V_DM_TRAI_CHU.DIEM_GIUA_KY, e_col_number_xls.diem_giua_ky);
        //    v_hst.Add(V_DM_TRAI_CHU.DIEM_CHUYEN_NGANH, e_col_number_xls.diem_chuyen_can);
        //    CC1TransferDataRow v_obj = new CC1TransferDataRow(m_fg_load_file, v_hst, m_ds_hoc_phan_v.V_DM_TRAI_CHU.NewV_DM_TRAI_CHURow());
        //    return v_obj;
        //}
        //#endregion

        //#region Public Interface
        //public void display()
        //{
        //    this.ShowDialog();
        //}
        //#endregion

        //#region Events
        //private void set_define_event()
        //{
        //    m_cmd_open_template.Click += new EventHandler(m_cmd_open_template_Click);
        //    m_cmd_chon_trai_phieu.Click += new EventHandler(m_cmd_chon_trai_phieu_Click);
        //    m_cmd_load_ds_trai_chu.Click += new EventHandler(m_cmd_load_ds_trai_chu_Click);
        //    m_cmd_kiem_tra.Click += new EventHandler(m_cmd_kiem_tra_Click);
        //    m_cmd_luu.Click += new EventHandler(m_cmd_luu_Click);
        //    m_cmd_thoat.Click += new EventHandler(m_cmd_thoat_Click);
        //}

        //void m_cmd_chon_trai_phieu_Click(object sender, EventArgs e)
        //{
        //    try
        //    {

        //    }
        //    catch (Exception v_e)
        //    {
        //        CSystemLog_301.ExceptionHandle(v_e);
        //    }
        //}

        //void m_cmd_open_template_Click(object sender, EventArgs e)
        //{
        //    try
        //    {

        //    }
        //    catch (Exception v_e)
        //    {
        //        CSystemLog_301.ExceptionHandle(v_e);
        //    }
        //}

        //void m_cmd_luu_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        add_hoc_vien_vao_lop();
        //        BaseMessages.MsgBox_Infor("Đã tạo bảng điểm thành công");
        //    }
        //    catch (Exception v_e)
        //    {
        //        CSystemLog_301.ExceptionHandle(v_e);
        //    }
        //}

        //void m_cmd_kiem_tra_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        kiem_tra_data_tren_luoi();
        //    }
        //    catch (Exception v_e)
        //    {
        //        CSystemLog_301.ExceptionHandle(v_e);
        //    }
        //}

        //void m_cmd_load_ds_trai_chu_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        load_db_excel();
        //    }
        //    catch (Exception v_e)
        //    {
        //        CSystemLog_301.ExceptionHandle(v_e);
        //    }
        //}

        //void m_cmd_thoat_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.Close();
        //    }
        //    catch (Exception v_e)
        //    {
        //        CSystemLog_301.ExceptionHandle(v_e);
        //    }
        //}
        //#endregion
    }
}
