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

using BondDS;
using BondUS;
using BondDS.CDBNames;

using C1.Win.C1FlexGrid;
using System.Collections;
using System.Data.SqlTypes;

namespace BondApp.ChucNang
{
    public partial class f950_quan_ly_tra_goc : Form
    {
        public f950_quan_ly_tra_goc()
        {
            InitializeComponent();
            format_controls();
        }
        
		#region Public Interface
		public void display(){			
			this.ShowDialog();
		}
		#endregion

		#region Data Structure
		private enum e_col_Number{
			CMT_GIAY_DKKD = 7
,TEN_TRAI_CHU = 2
,ID_LOAI_TRAI_CHU = 13
,FAX = 12
,ID_TRANG_THAI = 16
,MA_TRAI_PHIEU = 3
,NGAY_CAP_CMT = 8
,MA_TRAI_CHU = 1
,SO_TAI_KHOAN = 14
,TEN_TRAI_PHIEU = 4
,DIA_CHI = 10
,MO_TAI_NGAN_HANG = 15
,MENH_GIA = 5
,MOBILE = 11
,TONG_SO_DU = 6
,NOI_CAP_CMT = 9

		}			
		#endregion

		#region Members
		ITransferDataRow m_obj_trans;		
		DS_V_GD_TRA_GOC m_ds = new DS_V_GD_TRA_GOC();
		US_V_GD_TRA_GOC m_us = new US_V_GD_TRA_GOC();
		#endregion

		#region Private Methods
		private void format_controls(){
			CControlFormat.setFormStyle(this);
			CControlFormat.setC1FlexFormat(m_fg);
			set_define_events();
			this.KeyPreview = true;		
		}
		private void set_initial_form_load(){						
			m_obj_trans = get_trans_object(m_fg);
			load_data_2_grid();		
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
			Hashtable v_htb = new Hashtable();
			v_htb.Add(V_GD_TRA_GOC.CMT_GIAY_DKKD, e_col_Number.CMT_GIAY_DKKD);
			v_htb.Add(V_GD_TRA_GOC.TEN_TRAI_CHU, e_col_Number.TEN_TRAI_CHU);
			v_htb.Add(V_GD_TRA_GOC.ID_LOAI_TRAI_CHU, e_col_Number.ID_LOAI_TRAI_CHU);
			v_htb.Add(V_GD_TRA_GOC.FAX, e_col_Number.FAX);
			v_htb.Add(V_GD_TRA_GOC.ID_TRANG_THAI, e_col_Number.ID_TRANG_THAI);
			v_htb.Add(V_GD_TRA_GOC.MA_TRAI_PHIEU, e_col_Number.MA_TRAI_PHIEU);
			v_htb.Add(V_GD_TRA_GOC.NGAY_CAP_CMT, e_col_Number.NGAY_CAP_CMT);
			v_htb.Add(V_GD_TRA_GOC.MA_TRAI_CHU, e_col_Number.MA_TRAI_CHU);
			v_htb.Add(V_GD_TRA_GOC.SO_TAI_KHOAN, e_col_Number.SO_TAI_KHOAN);
			v_htb.Add(V_GD_TRA_GOC.TEN_TRAI_PHIEU, e_col_Number.TEN_TRAI_PHIEU);
			v_htb.Add(V_GD_TRA_GOC.DIA_CHI, e_col_Number.DIA_CHI);
			v_htb.Add(V_GD_TRA_GOC.MO_TAI_NGAN_HANG, e_col_Number.MO_TAI_NGAN_HANG);
			v_htb.Add(V_GD_TRA_GOC.MENH_GIA, e_col_Number.MENH_GIA);
			v_htb.Add(V_GD_TRA_GOC.MOBILE, e_col_Number.MOBILE);
			v_htb.Add(V_GD_TRA_GOC.TONG_SO_DU, e_col_Number.TONG_SO_DU);
			v_htb.Add(V_GD_TRA_GOC.NOI_CAP_CMT, e_col_Number.NOI_CAP_CMT);
									
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_ds.V_GD_TRA_GOC.NewRow());
			return v_obj_trans;			
		}
		private void load_data_2_grid(){						
			m_ds = new DS_V_GD_TRA_GOC();			
			m_us.FillDataset(m_ds);
			m_fg.Redraw = false;
			CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
			m_fg.Redraw = true;
		}
		private void grid2us_object(US_V_GD_TRA_GOC i_us
			, int i_grid_row) {
			DataRow v_dr;
			v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
			i_us.DataRow2Me(v_dr);
		}

	
		private void us_object2grid(US_V_GD_TRA_GOC i_us
			, int i_grid_row) {
			DataRow v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			i_us.Me2DataRow(v_dr);
			m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
		}


		private void insert_v_gd_tra_goc(){			
		//	f8888_GD_TRA_GOC_DE v_fDE = new  f8888_GD_TRA_GOC_DE();								
		//	v_fDE.display();
			load_data_2_grid();
		}

		private void update_v_gd_tra_goc(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;			
			grid2us_object(m_us, m_fg.Row);
		//	f8888_GD_TRA_GOC_DE v_fDE = new f8888_GD_TRA_GOC_DE();
		//	v_fDE.display(m_us);
			load_data_2_grid();
		}
				
		private void delete_v_gd_tra_goc(){
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
			if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted)  return;
			US_V_GD_TRA_GOC v_us = new US_V_GD_TRA_GOC();
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

		private void view_v_gd_tra_goc(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
			grid2us_object(m_us, m_fg.Row);
		//	f8888_GD_TRA_GOC_DE v_fDE = new f8888_GD_TRA_GOC_DE();			
		//	v_fDE.display(m_us);
		}
		private void set_define_events(){
			
		}
		#endregion

//
		//
		//		EVENT HANLDERS
		//
		//
		private void f8888_GD_TRA_GOC_Load(object sender, System.EventArgs e) {
			try{
				set_initial_form_load();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		
		}

	}
}